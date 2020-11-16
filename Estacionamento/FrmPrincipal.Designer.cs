namespace Estacionamento
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estacionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmdConsulta = new MetroFramework.Controls.MetroButton();
            this.cmdSaida = new MetroFramework.Controls.MetroButton();
            this.cmdEntada = new MetroFramework.Controls.MetroButton();
            this.cmdCliente = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.lblDataHora = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.processosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1507, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.colaboradorToolStripMenuItem,
            this.veiculoToolStripMenuItem,
            this.estacionamentoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // colaboradorToolStripMenuItem
            // 
            this.colaboradorToolStripMenuItem.Name = "colaboradorToolStripMenuItem";
            this.colaboradorToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.colaboradorToolStripMenuItem.Text = "Colaborador";
            this.colaboradorToolStripMenuItem.Click += new System.EventHandler(this.colaboradorToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // estacionamentoToolStripMenuItem
            // 
            this.estacionamentoToolStripMenuItem.Name = "estacionamentoToolStripMenuItem";
            this.estacionamentoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.estacionamentoToolStripMenuItem.Text = "Estacionamento";
            this.estacionamentoToolStripMenuItem.Click += new System.EventHandler(this.estacionamentoToolStripMenuItem_Click);
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaVeiculoToolStripMenuItem,
            this.saidaVeiculoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.processosToolStripMenuItem.Text = "Processos";
            // 
            // entradaVeiculoToolStripMenuItem
            // 
            this.entradaVeiculoToolStripMenuItem.Name = "entradaVeiculoToolStripMenuItem";
            this.entradaVeiculoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.entradaVeiculoToolStripMenuItem.Text = "Entrada Veiculo";
            this.entradaVeiculoToolStripMenuItem.Click += new System.EventHandler(this.entradaVeiculoToolStripMenuItem_Click);
            // 
            // saidaVeiculoToolStripMenuItem
            // 
            this.saidaVeiculoToolStripMenuItem.Name = "saidaVeiculoToolStripMenuItem";
            this.saidaVeiculoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saidaVeiculoToolStripMenuItem.Text = "Saida Veiculo";
            this.saidaVeiculoToolStripMenuItem.Click += new System.EventHandler(this.saidaVeiculoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.cmdSair);
            this.metroPanel1.Controls.Add(this.cmdConsulta);
            this.metroPanel1.Controls.Add(this.cmdSaida);
            this.metroPanel1.Controls.Add(this.cmdEntada);
            this.metroPanel1.Controls.Add(this.cmdCliente);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(15, 86);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1499, 58);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // cmdSair
            // 
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.Location = new System.Drawing.Point(981, 2);
            this.cmdSair.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(156, 52);
            this.cmdSair.TabIndex = 6;
            this.cmdSair.Text = "Sair";
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdConsulta.Location = new System.Drawing.Point(721, 2);
            this.cmdConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(156, 52);
            this.cmdConsulta.TabIndex = 5;
            this.cmdConsulta.Text = "Consulta";
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // cmdSaida
            // 
            this.cmdSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSaida.Location = new System.Drawing.Point(488, 2);
            this.cmdSaida.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSaida.Name = "cmdSaida";
            this.cmdSaida.Size = new System.Drawing.Size(156, 52);
            this.cmdSaida.TabIndex = 4;
            this.cmdSaida.Text = "Saida Veiculo";
            this.cmdSaida.Click += new System.EventHandler(this.cmdSaida_Click);
            // 
            // cmdEntada
            // 
            this.cmdEntada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEntada.Location = new System.Drawing.Point(245, 2);
            this.cmdEntada.Margin = new System.Windows.Forms.Padding(2);
            this.cmdEntada.Name = "cmdEntada";
            this.cmdEntada.Size = new System.Drawing.Size(156, 52);
            this.cmdEntada.TabIndex = 3;
            this.cmdEntada.Text = "Entrada Veiculo";
            this.cmdEntada.Click += new System.EventHandler(this.cmdEntada_Click);
            // 
            // cmdCliente
            // 
            this.cmdCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCliente.Location = new System.Drawing.Point(9, 2);
            this.cmdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(156, 52);
            this.cmdCliente.TabIndex = 2;
            this.cmdCliente.Text = "Clientes";
            this.cmdCliente.Click += new System.EventHandler(this.cmdCliente_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.metroLink1);
            this.metroPanel2.Controls.Add(this.lblDataHora);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 8;
            this.metroPanel2.Location = new System.Drawing.Point(15, 765);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1502, 55);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.Tag = "a";
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(312, 16);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 4;
            // 
            // metroLink1
            // 
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.Location = new System.Drawing.Point(20, 16);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(2);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(175, 28);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "GitHub";
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDataHora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDataHora.Location = new System.Drawing.Point(1323, 16);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(114, 25);
            this.lblDataHora.TabIndex = 2;
            this.lblDataHora.Text = "Data e Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Estacionamento.Properties.Resources.estacionamento_carros;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1499, 605);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 839);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Pare e Pague Estacionamentos";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdConsulta;
        private MetroFramework.Controls.MetroButton cmdSaida;
        private MetroFramework.Controls.MetroButton cmdEntada;
        private MetroFramework.Controls.MetroButton cmdCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel lblDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estacionamentoToolStripMenuItem;
    }
}