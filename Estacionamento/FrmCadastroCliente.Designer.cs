namespace Estacionamento
{
    partial class FrmCadastroCliente
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
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmdHistorico = new MetroFramework.Controls.MetroButton();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmdLocalizaCliente = new MetroFramework.Controls.MetroButton();
            this.cmdVeiculos = new MetroFramework.Controls.MetroButton();
            this.txtContato = new MetroFramework.Controls.MetroTextBox();
            this.txtCpfCliente = new MetroFramework.Controls.MetroTextBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtNomeCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
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
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.Controls.Add(this.cmdHistorico);
            this.metroPanel1.Controls.Add(this.cmdSair);
            this.metroPanel1.Controls.Add(this.cmdExcluir);
            this.metroPanel1.Controls.Add(this.cmdSalvar);
            this.metroPanel1.Controls.Add(this.cmdNovo);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 346);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(765, 81);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmdHistorico
            // 
            this.cmdHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdHistorico.Enabled = false;
            this.cmdHistorico.Location = new System.Drawing.Point(359, 12);
            this.cmdHistorico.Name = "cmdHistorico";
            this.cmdHistorico.Size = new System.Drawing.Size(110, 56);
            this.cmdHistorico.TabIndex = 13;
            this.cmdHistorico.Text = "Historico";
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
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Gray;
            this.metroPanel2.Controls.Add(this.cmdLocalizaCliente);
            this.metroPanel2.Controls.Add(this.cmdVeiculos);
            this.metroPanel2.Controls.Add(this.txtContato);
            this.metroPanel2.Controls.Add(this.txtCpfCliente);
            this.metroPanel2.Controls.Add(this.dtpDataCadastro);
            this.metroPanel2.Controls.Add(this.txtNomeCliente);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 107);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(765, 233);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmdLocalizaCliente
            // 
            this.cmdLocalizaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLocalizaCliente.Location = new System.Drawing.Point(475, 173);
            this.cmdLocalizaCliente.Name = "cmdLocalizaCliente";
            this.cmdLocalizaCliente.Size = new System.Drawing.Size(110, 46);
            this.cmdLocalizaCliente.TabIndex = 23;
            this.cmdLocalizaCliente.Text = "Localizar Cliente";
            this.cmdLocalizaCliente.Click += new System.EventHandler(this.cmdLocalizaCliente_Click);
            // 
            // cmdVeiculos
            // 
            this.cmdVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVeiculos.Location = new System.Drawing.Point(641, 173);
            this.cmdVeiculos.Name = "cmdVeiculos";
            this.cmdVeiculos.Size = new System.Drawing.Size(110, 46);
            this.cmdVeiculos.TabIndex = 22;
            this.cmdVeiculos.Text = "Cadastrar Veiculo";
            this.cmdVeiculos.Click += new System.EventHandler(this.cmdVeiculos_Click);
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtContato.CustomBackground = true;
            this.txtContato.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtContato.Location = new System.Drawing.Point(185, 130);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(242, 23);
            this.txtContato.TabIndex = 21;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCpfCliente.CustomBackground = true;
            this.txtCpfCliente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCpfCliente.Location = new System.Drawing.Point(185, 79);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(242, 23);
            this.txtCpfCliente.TabIndex = 20;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(185, 173);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(100, 26);
            this.dtpDataCadastro.TabIndex = 19;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomeCliente.CustomBackground = true;
            this.txtNomeCliente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeCliente.Location = new System.Drawing.Point(185, 36);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(546, 23);
            this.txtNomeCliente.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtNomeCliente.TabIndex = 18;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(44, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 25);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Data Cadastro";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(93, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Contato";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(127, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "CPF";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Tag = "";
            this.metroLabel1.Text = "Nome Completo";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cadastro de Cliente";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdHistorico;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton cmdLocalizaCliente;
        private MetroFramework.Controls.MetroButton cmdVeiculos;
        private MetroFramework.Controls.MetroTextBox txtContato;
        private MetroFramework.Controls.MetroTextBox txtCpfCliente;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private MetroFramework.Controls.MetroTextBox txtNomeCliente;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}