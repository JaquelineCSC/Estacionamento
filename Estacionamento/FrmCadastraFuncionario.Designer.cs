namespace Estacionamento
{
    partial class FrmCadastraFuncionario
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
            this.txtCargo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmdCadastraLogin = new MetroFramework.Controls.MetroButton();
            this.cmdLocalizaFunc = new MetroFramework.Controls.MetroButton();
            this.txtFoneFunc = new MetroFramework.Controls.MetroTextBox();
            this.txtCpfFunc = new MetroFramework.Controls.MetroTextBox();
            this.dtpDataCadastroFunc = new System.Windows.Forms.DateTimePicker();
            this.txtNomeFunc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtIdEstacionamento = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Gray;
            this.metroPanel2.Controls.Add(this.txtIdEstacionamento);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.txtCargo);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.cmdCadastraLogin);
            this.metroPanel2.Controls.Add(this.cmdLocalizaFunc);
            this.metroPanel2.Controls.Add(this.txtFoneFunc);
            this.metroPanel2.Controls.Add(this.txtCpfFunc);
            this.metroPanel2.Controls.Add(this.dtpDataCadastroFunc);
            this.metroPanel2.Controls.Add(this.txtNomeFunc);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 114);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(765, 233);
            this.metroPanel2.TabIndex = 16;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCargo.CustomBackground = true;
            this.txtCargo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCargo.Location = new System.Drawing.Point(520, 79);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(184, 23);
            this.txtCargo.TabIndex = 25;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(442, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 25);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Cargo";
            // 
            // cmdCadastraLogin
            // 
            this.cmdCadastraLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCadastraLogin.Location = new System.Drawing.Point(454, 173);
            this.cmdCadastraLogin.Name = "cmdCadastraLogin";
            this.cmdCadastraLogin.Size = new System.Drawing.Size(110, 46);
            this.cmdCadastraLogin.TabIndex = 13;
            this.cmdCadastraLogin.Text = "Cadastrar Login";
            this.cmdCadastraLogin.Click += new System.EventHandler(this.cmdCadastraLogin_Click);
            // 
            // cmdLocalizaFunc
            // 
            this.cmdLocalizaFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLocalizaFunc.Location = new System.Drawing.Point(621, 173);
            this.cmdLocalizaFunc.Name = "cmdLocalizaFunc";
            this.cmdLocalizaFunc.Size = new System.Drawing.Size(110, 46);
            this.cmdLocalizaFunc.TabIndex = 23;
            this.cmdLocalizaFunc.Text = "Colaboladores";
            this.cmdLocalizaFunc.Click += new System.EventHandler(this.cmdLocalizaFunc_Click);
            // 
            // txtFoneFunc
            // 
            this.txtFoneFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFoneFunc.CustomBackground = true;
            this.txtFoneFunc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFoneFunc.Location = new System.Drawing.Point(185, 130);
            this.txtFoneFunc.Name = "txtFoneFunc";
            this.txtFoneFunc.Size = new System.Drawing.Size(192, 23);
            this.txtFoneFunc.TabIndex = 21;
            // 
            // txtCpfFunc
            // 
            this.txtCpfFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCpfFunc.CustomBackground = true;
            this.txtCpfFunc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCpfFunc.Location = new System.Drawing.Point(185, 79);
            this.txtCpfFunc.Name = "txtCpfFunc";
            this.txtCpfFunc.Size = new System.Drawing.Size(192, 23);
            this.txtCpfFunc.TabIndex = 20;
            // 
            // dtpDataCadastroFunc
            // 
            this.dtpDataCadastroFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastroFunc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroFunc.Location = new System.Drawing.Point(185, 173);
            this.dtpDataCadastroFunc.Name = "dtpDataCadastroFunc";
            this.dtpDataCadastroFunc.Size = new System.Drawing.Size(100, 26);
            this.dtpDataCadastroFunc.TabIndex = 19;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomeFunc.CustomBackground = true;
            this.txtNomeFunc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeFunc.Location = new System.Drawing.Point(185, 36);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(546, 23);
            this.txtNomeFunc.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtNomeFunc.TabIndex = 18;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(44, 174);
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
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.Controls.Add(this.cmdSair);
            this.metroPanel1.Controls.Add(this.cmdExcluir);
            this.metroPanel1.Controls.Add(this.cmdSalvar);
            this.metroPanel1.Controls.Add(this.cmdNovo);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 353);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(765, 81);
            this.metroPanel1.TabIndex = 15;
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(442, 128);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(154, 25);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "IdEstacionamento";
            // 
            // txtIdEstacionamento
            // 
            this.txtIdEstacionamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIdEstacionamento.CustomBackground = true;
            this.txtIdEstacionamento.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtIdEstacionamento.Location = new System.Drawing.Point(611, 128);
            this.txtIdEstacionamento.Name = "txtIdEstacionamento";
            this.txtIdEstacionamento.Size = new System.Drawing.Size(53, 23);
            this.txtIdEstacionamento.TabIndex = 27;
            // 
            // FrmCadastraFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmCadastraFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cadastro de Colaborador";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmCadastraFuncionario_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton cmdLocalizaFunc;
        private MetroFramework.Controls.MetroTextBox txtFoneFunc;
        private MetroFramework.Controls.MetroTextBox txtCpfFunc;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroFunc;
        private MetroFramework.Controls.MetroTextBox txtNomeFunc;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroTextBox txtCargo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton cmdCadastraLogin;
        private MetroFramework.Controls.MetroTextBox txtIdEstacionamento;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}