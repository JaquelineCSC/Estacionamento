namespace Estacionamento
{
    partial class FrmEntradaVeiculo
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
            this.components = new System.ComponentModel.Container();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmdSaida = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.cmdCadastrarVeiculo = new MetroFramework.Controls.MetroButton();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmdCadastraCliente = new MetroFramework.Controls.MetroButton();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtValorHora = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "dd/MM/yyy HH:mm:ss";
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(89, 167);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(116, 29);
            this.dtpHoraEntrada.TabIndex = 0;
            this.dtpHoraEntrada.Value = new System.DateTime(2020, 11, 15, 23, 15, 0, 0);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(14, 171);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Horário";
            // 
            // cmdSaida
            // 
            this.cmdSaida.Location = new System.Drawing.Point(254, 6);
            this.cmdSaida.Name = "cmdSaida";
            this.cmdSaida.Size = new System.Drawing.Size(106, 50);
            this.cmdSaida.TabIndex = 2;
            this.cmdSaida.Text = "Saida Veiculo";
            this.cmdSaida.Click += new System.EventHandler(this.cmdSaida_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.cmbBox);
            this.metroPanel1.Controls.Add(this.cmdCadastrarVeiculo);
            this.metroPanel1.Controls.Add(this.cmbPlaca);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cmdCadastraCliente);
            this.metroPanel1.Controls.Add(this.cmbCliente);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtValorHora);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dtpData);
            this.metroPanel1.Controls.Add(this.dtpHoraEntrada);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(681, 212);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmbBox
            // 
            this.cmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Location = new System.Drawing.Point(89, 94);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(60, 32);
            this.cmbBox.TabIndex = 16;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SelectedIndexChanged);
            // 
            // cmdCadastrarVeiculo
            // 
            this.cmdCadastrarVeiculo.Location = new System.Drawing.Point(511, 61);
            this.cmdCadastrarVeiculo.Name = "cmdCadastrarVeiculo";
            this.cmdCadastrarVeiculo.Size = new System.Drawing.Size(158, 45);
            this.cmdCadastrarVeiculo.TabIndex = 13;
            this.cmdCadastrarVeiculo.Text = "Cadastrar Novo Veiculo";
            this.cmdCadastrarVeiculo.Click += new System.EventHandler(this.cmdCadastrarVeiculo_Click);
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Location = new System.Drawing.Point(89, 56);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(116, 32);
            this.cmbPlaca.TabIndex = 15;
            this.cmbPlaca.SelectedIndexChanged += new System.EventHandler(this.cmbPlaca_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(14, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Placa";
            // 
            // cmdCadastraCliente
            // 
            this.cmdCadastraCliente.Location = new System.Drawing.Point(511, 10);
            this.cmdCadastraCliente.Name = "cmdCadastraCliente";
            this.cmdCadastraCliente.Size = new System.Drawing.Size(158, 45);
            this.cmdCadastraCliente.TabIndex = 12;
            this.cmdCadastraCliente.Text = "Cadastrar Novo Cliente";
            this.cmdCadastraCliente.Click += new System.EventHandler(this.cmdCadastraCliente_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(89, 10);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(244, 32);
            this.cmbCliente.TabIndex = 11;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(14, 17);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 25);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Cliente";
            // 
            // txtValorHora
            // 
            this.txtValorHora.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtValorHora.Location = new System.Drawing.Point(357, 169);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(86, 23);
            this.txtValorHora.TabIndex = 9;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(228, 167);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(123, 25);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Valor por Hora";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(14, 101);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Box";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(14, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyy HH:mm:ss";
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(89, 132);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(116, 29);
            this.dtpData.TabIndex = 2;
            this.dtpData.Value = new System.DateTime(2020, 11, 15, 0, 0, 0, 0);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Teal;
            this.metroPanel2.Controls.Add(this.cmdSalvar);
            this.metroPanel2.Controls.Add(this.cmdNovo);
            this.metroPanel2.Controls.Add(this.cmdSair);
            this.metroPanel2.Controls.Add(this.cmdSaida);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 281);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(681, 63);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(133, 6);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(106, 50);
            this.cmdSalvar.TabIndex = 5;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(14, 6);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(106, 50);
            this.cmdNovo.TabIndex = 4;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(563, 6);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(106, 50);
            this.cmdSair.TabIndex = 3;
            this.cmdSair.Text = "Cancelar";
            this.cmdSair.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmEntradaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 367);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "FrmEntradaVeiculo";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Entrada Veiculo";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmEntradaVeiculo_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cmdSaida;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private MetroFramework.Controls.MetroButton cmdCadastrarVeiculo;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton cmdCadastraCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtValorHora;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.Timer timer1;
    }
}