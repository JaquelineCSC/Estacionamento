namespace Estacionamento
{
    partial class FrmCadastroLogin
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.txtSenha);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtNomeLogin);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 79);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(364, 125);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSenha.Location = new System.Drawing.Point(141, 73);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(149, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(68, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Senha:";
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeLogin.Location = new System.Drawing.Point(141, 22);
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(149, 23);
            this.txtNomeLogin.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(18, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome Login:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Teal;
            this.metroPanel2.Controls.Add(this.cmdSair);
            this.metroPanel2.Controls.Add(this.cmdSalvar);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 210);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(364, 92);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmdSair
            // 
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.Location = new System.Drawing.Point(258, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(88, 66);
            this.cmdSair.TabIndex = 4;
            this.cmdSair.Text = "Sair";
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalvar.Location = new System.Drawing.Point(18, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(88, 66);
            this.cmdSalvar.TabIndex = 2;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // FrmCadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 322);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmCadastroLogin";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastro de Login";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNomeLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdSalvar;
    }
}