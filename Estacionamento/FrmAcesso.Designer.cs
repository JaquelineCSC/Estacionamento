namespace Estacionamento
{
    partial class FrmAcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmdEntrar = new MetroFramework.Controls.MetroButton();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.cmbPark = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(198, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Login de Acesso";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cmbPark);
            this.metroPanel1.Controls.Add(this.cmbLogin);
            this.metroPanel1.Controls.Add(this.cmdSair);
            this.metroPanel1.Controls.Add(this.cmdEntrar);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtSenha);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 113);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(518, 249);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(130, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenha.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSenha.Location = new System.Drawing.Point(226, 127);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(123, 30);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(130, 127);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Senha";
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEntrar.Location = new System.Drawing.Point(152, 187);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(75, 43);
            this.cmdEntrar.TabIndex = 6;
            this.cmdEntrar.Text = "Entrar";
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(312, 187);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(75, 43);
            this.cmdSair.TabIndex = 7;
            this.cmdSair.Text = "Sair";
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmbLogin
            // 
            this.cmbLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(226, 75);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(222, 32);
            this.cmbLogin.TabIndex = 16;
            this.cmbLogin.SelectedIndexChanged += new System.EventHandler(this.cmbLogin_SelectedIndexChanged);
            // 
            // cmbPark
            // 
            this.cmbPark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPark.FormattingEnabled = true;
            this.cmbPark.Location = new System.Drawing.Point(226, 17);
            this.cmbPark.Name = "cmbPark";
            this.cmbPark.Size = new System.Drawing.Size(248, 32);
            this.cmbPark.TabIndex = 17;
            this.cmbPark.SelectedIndexChanged += new System.EventHandler(this.cmbPark_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(63, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 25);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Estacionamento";
            // 
            // FrmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 375);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmAcesso";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Pare e Pague Controle de Estacionamento";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmAcesso_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdEntrar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cmbLogin;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cmbPark;
    }
}