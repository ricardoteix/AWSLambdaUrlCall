
namespace AWSLambdaUrlCall
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetCredentials = new System.Windows.Forms.Button();
            this.txtSessionToken = new System.Windows.Forms.TextBox();
            this.txtSecretAccessKey = new System.Windows.Forms.TextBox();
            this.txtAccessKeyId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sobreURLsDeFunçãoLambdaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AWS CLI Profile*";
            // 
            // txtProfile
            // 
            this.txtProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfile.Location = new System.Drawing.Point(103, 58);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(685, 20);
            this.txtProfile.TabIndex = 1;
            this.txtProfile.TextChanged += new System.EventHandler(this.onLambdaChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(103, 84);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(685, 20);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.TextChanged += new System.EventHandler(this.onLambdaChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lambda URL*";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGetCredentials);
            this.groupBox1.Controls.Add(this.txtSessionToken);
            this.groupBox1.Controls.Add(this.txtSecretAccessKey);
            this.groupBox1.Controls.Add(this.txtAccessKeyId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciais";
            // 
            // btnGetCredentials
            // 
            this.btnGetCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetCredentials.Location = new System.Drawing.Point(513, 113);
            this.btnGetCredentials.Name = "btnGetCredentials";
            this.btnGetCredentials.Size = new System.Drawing.Size(240, 23);
            this.btnGetCredentials.TabIndex = 12;
            this.btnGetCredentials.Text = "Obter Credenciais Automaticamente";
            this.btnGetCredentials.UseVisualStyleBackColor = true;
            this.btnGetCredentials.Click += new System.EventHandler(this.btnGetCredentials_Click);
            // 
            // txtSessionToken
            // 
            this.txtSessionToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSessionToken.Location = new System.Drawing.Point(103, 86);
            this.txtSessionToken.Name = "txtSessionToken";
            this.txtSessionToken.Size = new System.Drawing.Size(650, 20);
            this.txtSessionToken.TabIndex = 11;
            // 
            // txtSecretAccessKey
            // 
            this.txtSecretAccessKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecretAccessKey.Location = new System.Drawing.Point(103, 54);
            this.txtSecretAccessKey.Name = "txtSecretAccessKey";
            this.txtSecretAccessKey.Size = new System.Drawing.Size(650, 20);
            this.txtSecretAccessKey.TabIndex = 10;
            // 
            // txtAccessKeyId
            // 
            this.txtAccessKeyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessKeyId.Location = new System.Drawing.Point(103, 22);
            this.txtAccessKeyId.Name = "txtAccessKeyId";
            this.txtAccessKeyId.Size = new System.Drawing.Size(650, 20);
            this.txtAccessKeyId.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SessionToken";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SecretAccessKey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "AccessKeyId";
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(15, 316);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(773, 279);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resultado";
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Location = new System.Drawing.Point(528, 601);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(260, 23);
            this.btnRequest.TabIndex = 13;
            this.btnRequest.Text = "Executar Lambda";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Região*";
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegion.Location = new System.Drawing.Point(103, 110);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(685, 20);
            this.txtRegion.TabIndex = 14;
            this.txtRegion.Text = "us-east-1";
            this.txtRegion.TextChanged += new System.EventHandler(this.onLambdaChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirMenuItem,
            this.salvarMenuItem,
            this.toolStripSeparator1,
            this.sairMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirMenuItem
            // 
            this.abrirMenuItem.Name = "abrirMenuItem";
            this.abrirMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirMenuItem.Text = "Abrir";
            this.abrirMenuItem.Click += new System.EventHandler(this.abrirMenuItem_Click);
            // 
            // salvarMenuItem
            // 
            this.salvarMenuItem.Name = "salvarMenuItem";
            this.salvarMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarMenuItem.Text = "Salvar";
            this.salvarMenuItem.Click += new System.EventHandler(this.salvarMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairMenuItem
            // 
            this.sairMenuItem.Name = "sairMenuItem";
            this.sairMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairMenuItem.Text = "Sair";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreURLsDeFunçãoLambdaMenuItem,
            this.sobreMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreMenuItem
            // 
            this.sobreMenuItem.Name = "sobreMenuItem";
            this.sobreMenuItem.Size = new System.Drawing.Size(237, 22);
            this.sobreMenuItem.Text = "Sobre este programa";
            this.sobreMenuItem.Click += new System.EventHandler(this.sobreMenuItem_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(103, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(685, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.onLambdaChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nome da função";
            // 
            // sobreURLsDeFunçãoLambdaMenuItem
            // 
            this.sobreURLsDeFunçãoLambdaMenuItem.Name = "sobreURLsDeFunçãoLambdaMenuItem";
            this.sobreURLsDeFunçãoLambdaMenuItem.Size = new System.Drawing.Size(237, 22);
            this.sobreURLsDeFunçãoLambdaMenuItem.Text = "Sobre URLs de Função Lambda";
            this.sobreURLsDeFunçãoLambdaMenuItem.Click += new System.EventHandler(this.sobreURLsDeFunçãoLambdaMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "AWS Lambda Url Call";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSessionToken;
        private System.Windows.Forms.TextBox txtSecretAccessKey;
        private System.Windows.Forms.TextBox txtAccessKeyId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetCredentials;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairMenuItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem sobreURLsDeFunçãoLambdaMenuItem;
    }
}

