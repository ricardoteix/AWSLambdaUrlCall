using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Auth;
using Amazon.SecurityToken;
using Amazon.Util;
using Aws4RequestSigner;

namespace AWSLambdaUrlCall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
        }

        private void btnGetCredentials_Click(object sender, EventArgs e)
        {
            var chain = new CredentialProfileStoreChain();
            AWSCredentials awsCredentials;
            if (chain.TryGetAWSCredentials(this.txtProfile.Text, out awsCredentials))
            {
                using (var sts_client = new AmazonSecurityTokenServiceClient(awsCredentials ))
                {
                    var response = sts_client.GetSessionToken();
                    // this.txtResultado.Text += "AccessKeyId: " + response.Credentials.AccessKeyId + "\n";
                    // this.txtResultado.Text += "SecretAccessKey: " + response.Credentials.SecretAccessKey + "\n";
                    // this.txtResultado.Text += "SessionToken: " + response.Credentials.SessionToken + "\n";

                    this.txtAccessKeyId.Text = response.Credentials.AccessKeyId;
                    this.txtSecretAccessKey.Text = response.Credentials.SecretAccessKey;
                    this.txtSessionToken.Text = response.Credentials.SessionToken;
                }
            } else
            {
                this.txtResultado.Text = "Não foi possível obter as credenciais.";
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
           this.requestSigned();
        }

        private async void requestSigned()
        {
            var signer = new AWS4RequestSigner(this.txtAccessKeyId.Text, this.txtSecretAccessKey.Text);
            var content = new StringContent("", Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(this.txtUrl.Text),
                Content = content
            };

            request = await signer.Sign(request, "lambda", "us-east-1");
            var client = new HttpClient();

            client.DefaultRequestHeaders.TryAddWithoutValidation("X-Amz-Security-Token", this.txtSessionToken.Text);

            var response = await client.SendAsync(request);

            this.txtResultado.Text = await response.Content.ReadAsStringAsync();
        }

        private void sobreMenuItem_Click(object sender, EventArgs e)
        {
            String mensagem = "Desenvolvido por Ricardo Teixeira\n";
            mensagem += "github.com/ricardoteix\n\n";
            MessageBox.Show(mensagem, "Sobre " + this.Text);
        }
    }
}
