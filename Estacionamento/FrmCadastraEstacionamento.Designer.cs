namespace Estacionamento
{
    partial class FrmCadastraEstacionamento
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmdLocalizaEstacionamento = new MetroFramework.Controls.MetroButton();
            this.txtEndereco = new MetroFramework.Controls.MetroTextBox();
            this.txtValorHora = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Teal;
            this.metroPanel2.Controls.Add(this.cmdLocalizaEstacionamento);
            this.metroPanel2.Controls.Add(this.txtEndereco);
            this.metroPanel2.Controls.Add(this.txtValorHora);
            this.metroPanel2.Controls.Add(this.txtNome);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(18, 109);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(765, 233);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel2.TabIndex = 15;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmdLocalizaEstacionamento
            // 
            this.cmdLocalizaEstacionamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLocalizaEstacionamento.Location = new System.Drawing.Point(556, 170);
            this.cmdLocalizaEstacionamento.Name = "cmdLocalizaEstacionamento";
            this.cmdLocalizaEstacionamento.Size = new System.Drawing.Size(175, 46);
            this.cmdLocalizaEstacionamento.TabIndex = 23;
            this.cmdLocalizaEstacionamento.Text = "Localizar Estacionamento";
            this.cmdLocalizaEstacionamento.Click += new System.EventHandler(this.cmdLocalizaEstacionamento_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEndereco.CustomBackground = true;
            this.txtEndereco.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEndereco.Location = new System.Drawing.Point(252, 128);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(479, 23);
            this.txtEndereco.TabIndex = 21;
            // 
            // txtValorHora
            // 
            this.txtValorHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValorHora.CustomBackground = true;
            this.txtValorHora.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtValorHora.Location = new System.Drawing.Point(252, 81);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(165, 23);
            this.txtValorHora.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNome.CustomBackground = true;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNome.Location = new System.Drawing.Point(252, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(479, 23);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtNome.TabIndex = 18;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(161, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Endereco:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(117, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Valor por Hora:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(226, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Tag = "";
            this.metroLabel1.Text = "Nome do Estabelecimento:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.cmdSair);
            this.metroPanel1.Controls.Add(this.cmdExcluir);
            this.metroPanel1.Controls.Add(this.cmdSalvar);
            this.metroPanel1.Controls.Add(this.cmdNovo);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(18, 348);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(765, 81);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmdSair
            // 
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.Location = new System.Drawing.Point(641, 12);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(110, 56);
            this.cmdSair.TabIndex = 12;
            this.cmdSair.Text = "Sair";
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExcluir.Enabled = false;
            this.cmdExcluir.Location = new System.Drawing.Point(243, 12);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(110, 56);
            this.cmdExcluir.TabIndex = 11;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Location = new System.Drawing.Point(127, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(110, 56);
            this.cmdSalvar.TabIndex = 8;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNovo.Location = new System.Drawing.Point(20, 12);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(101, 56);
            this.cmdNovo.TabIndex = 9;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // FrmCadastraEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "FrmCadastraEstacionamento";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastro de Estacionamento";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmCadastraEstacionamento_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton cmdLocalizaEstacionamento;
        private MetroFramework.Controls.MetroTextBox txtEndereco;
        private MetroFramework.Controls.MetroTextBox txtValorHora;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroButton cmdNovo;
    }
}