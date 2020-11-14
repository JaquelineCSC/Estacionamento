namespace Estacionamento
{
    partial class FrmPesquisaEstacionamento
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
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.cmdSair);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.cmdPesquisar);
            this.metroPanel1.Controls.Add(this.txtNome);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 370);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmdSair
            // 
            this.cmdSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSair.Location = new System.Drawing.Point(575, 28);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(84, 34);
            this.cmdSair.TabIndex = 8;
            this.cmdSair.Text = "Cancelar";
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 260);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPesquisar.Location = new System.Drawing.Point(469, 28);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(85, 32);
            this.cmdPesquisar.TabIndex = 6;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // txtNome
            // 
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNome.Location = new System.Drawing.Point(186, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 23);
            this.txtNome.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(111, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nome:";
            // 
            // FrmPesquisaEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmPesquisaEstacionamento";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Pesquisa Estacionamentos";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmPesquisaEstacionamento_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton cmdSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}