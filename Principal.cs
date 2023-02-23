using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
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
using Newtonsoft.Json;

namespace AWSLambdaUrlCall
{
    public partial class Principal : Form
    {

        private List<LambdaURL> lambdaUrlConfigs;
        private LambdaURL lastUsedLambda;
        private string SavePath;
        private string LastUsedPath;

        public Principal()
        {
            InitializeComponent();

            this.SavePath = "assets/lambda_configs.json";

            this.LastUsedPath = "assets/lambda_last_used_config.json";

            this.lambdaUrlConfigs = new List<LambdaURL>();

            this.LoadSavings();
            this.LoadLastUsed();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private String formatJson(String jsonData)
        {
            object content = JsonConvert.DeserializeObject<object>(jsonData);
            String content_str = JsonConvert.SerializeObject(content, Formatting.Indented);
            return content_str;
        }

        private bool validateJson(String jsonData)
        {
            try
            {
                object content = JsonConvert.DeserializeObject<object>(jsonData);
                return true;
            } catch
            {
                return false;
            }

        }

        public bool LoadLastUsed()
        {
            if (File.Exists(this.LastUsedPath))
            {
                String lambda = File.ReadAllText(this.LastUsedPath);
                this.lastUsedLambda = JsonConvert.DeserializeObject<LambdaURL>(lambda);

                if (this.lastUsedLambda != null)
                {
                    this.LoadLambdaConfig(this.lastUsedLambda);
                } 

                return true;
            }
            return false;
        }

        private void SaveLastUsed()
        {
            this.lastUsedLambda = new LambdaURL();

            this.lastUsedLambda.Name = this.txtName.Text;
            this.lastUsedLambda.Profile = this.txtProfile.Text;
            this.lastUsedLambda.Region = this.txtRegion.Text;
            this.lastUsedLambda.Url = this.txtUrl.Text;
            this.lastUsedLambda.Content = this.txtContent.Text;

            string lambda = JsonConvert.SerializeObject(this.lastUsedLambda);
            File.WriteAllText(this.LastUsedPath, lambda);
        }

        public bool LoadSavings()
        {
            if (File.Exists(this.SavePath))
            {
                String lambdas = File.ReadAllText(this.SavePath);
                this.lambdaUrlConfigs = JsonConvert.DeserializeObject<List<LambdaURL>>(lambdas);

                return true;
            }
            return false;
        }

        public void LoadLambdaConfig(LambdaURL lambda)
        {
            this.LoadSavings();

            this.txtName.Text = lambda.Name;
            this.txtProfile.Text = lambda.Profile;
            this.txtRegion.Text = lambda.Region;
            this.txtUrl.Text = lambda.Url;
            this.txtContent.Text = lambda.Content;
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

                    this.txtResultado.Text = "";
                }
            } else
            {
                String msg = "Não foi possível obter as credenciais.\nPreencha o profile, URL e região e tente novamente.";
                MessageBox.Show(msg, "Erro");
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

            if (this.validateJson(this.txtContent.Text))
            {
                String content = this.formatJson(this.txtContent.Text);
                this.txtContent.Text = content;

                this.SaveLastUsed();
                this.requestSigned();
            } else
            {
                MessageBox.Show("Conteúdo inválido. O JSON contém erros.", "Erro");
            }
           
        }

        private async void requestSigned()
        {
            this.txtResultado.Text = "";

            if (this.txtAccessKeyId.Text == "" || this.txtSecretAccessKey.Text == "" || this.txtSessionToken.Text == "")
            {
                MessageBox.Show("As credenciais não podem estar vazias ou inválidas.", "Erro");
                return;
            }

            var signer = new AWS4RequestSigner(this.txtAccessKeyId.Text, this.txtSecretAccessKey.Text);
            var content = new StringContent(this.txtContent.Text, Encoding.UTF8, "application/json");
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

            if (this.validateJson(this.txtResultado.Text))
            {
                this.txtResultado.Text = this.formatJson(this.txtResultado.Text);
            }
        }

        private void sobreMenuItem_Click(object sender, EventArgs e)
        {
            String mensagem = "Ricardo Teixeira\n";
            mensagem += "github.com/ricardoteix\n\n";
            mensagem += "Versão 1.0\n\n";
            MessageBox.Show(mensagem, "Sobre " + this.Text);
        }

        private void abrirMenuItem_Click(object sender, EventArgs e)
        {
            SavedLambdas formSaved = new SavedLambdas(SavedLambdas.ModeOpen);
            formSaved.Show();
        }

        private void excluirMenuItem_Click(object sender, EventArgs e)
        {
            SavedLambdas formSaved = new SavedLambdas(SavedLambdas.ModeDelete);
            formSaved.Show();
        }

        private void salvarMenuItem_Click(object sender, EventArgs e)
        {

            this.LoadSavings();

            LambdaURL lambda = new LambdaURL();
            lambda.Name = this.txtName.Text;
            lambda.Profile = this.txtProfile.Text;
            lambda.Region = this.txtRegion.Text;
            lambda.Url = this.txtUrl.Text;
            lambda.Content = this.txtContent.Text;

            bool exits= this.lambdaUrlConfigs.Any(item => item.Name == this.txtName.Text || item.Url == this.txtUrl.Text);

            if (exits)
            {
                MessageBox.Show("Já existe uma configuração com mesmo nome ou url.", "Atenção");
                return;
            }

            this.lambdaUrlConfigs.Add(lambda);

            string lambdas = JsonConvert.SerializeObject(this.lambdaUrlConfigs);
            File.WriteAllText(this.SavePath, lambdas);

            MessageBox.Show("Configuração salva com sucesso.", "Informação");
        }

        private void onLambdaChanged(object sender, EventArgs e)
        {
            this.SaveLastUsed();
        }

        private void sobreURLLambdaMenuItem_Click(object sender, EventArgs e)
        {
            String url = "https://docs.aws.amazon.com/pt_br/lambda/latest/dg/lambda-urls.html?icmpid=docs_lambda_help";
            Process.Start(url);
        }

        private void novoMenuItem_Click(object sender, EventArgs e)
        {

            this.txtAccessKeyId.Text = "";
            this.txtSecretAccessKey.Text = "";
            this.txtSessionToken.Text = "";

            this.txtRegion.Text = "";
            this.txtName.Text = "";
            this.txtUrl.Text = "";
            this.txtProfile.Text = "";

            this.txtContent.Text = "";
            this.txtResultado.Text = "";

        }
    }
}
