using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWSLambdaUrlCall
{
    public partial class SavedLambdas : Form
    {
        public static string ModeOpen = "open";
        public static string ModeDelete = "delete";
        
        private string SavePath;
        private BindingList<LambdaURL> lambdaUrlConfigs;

        public SavedLambdas(String mode)
        {
            InitializeComponent();

            this.btnOpen.Visible = false;
            this.btnDelete.Visible = false;

            if (mode == ModeOpen)
            {
                this.btnOpen.Visible = true;
            }
            if (mode == ModeDelete)
            {
                this.btnDelete.Visible = true;
            }

            this.SavePath = "assets/lambda_configs.json";

            this.lambdaUrlConfigs = new BindingList<LambdaURL>();

            this.LoadSavings();

        }

        private bool LoadSavings()
        {
            if (File.Exists(this.SavePath))
            {
                String lambdas = File.ReadAllText(this.SavePath);
                this.lambdaUrlConfigs = JsonConvert.DeserializeObject<BindingList<LambdaURL>>(lambdas);

                this.lstLambdaUrl.DisplayMember = "Name";
                this.lstLambdaUrl.DataSource = this.lambdaUrlConfigs;

                return true;
            }
            return false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            LambdaURL lambda = (LambdaURL)this.lstLambdaUrl.SelectedItem;

            if (Application.OpenForms["Principal"] != null)
            {
                Principal formPrincipal = (Application.OpenForms["Principal"] as Principal);
                formPrincipal.LoadLambdaConfig(lambda);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            LambdaURL lambda = (LambdaURL)this.lstLambdaUrl.SelectedItem;

            this.lambdaUrlConfigs.Remove(lambda);

            string lambdas = JsonConvert.SerializeObject(this.lambdaUrlConfigs);
            File.WriteAllText(this.SavePath, lambdas);
            
            Principal formPrincipal = (Application.OpenForms["Principal"] as Principal);
            formPrincipal.LoadSavings();

            MessageBox.Show("Configuração excluída com sucesso.", "Informação");
        }
    }
}
