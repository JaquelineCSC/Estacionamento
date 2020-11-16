namespace Estacionamento
{
    partial class FrmBox
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
            this.cmdGerarBox = new MetroFramework.Controls.MetroButton();
            this.cmdSair = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbEstacionamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nudQtdBox = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Teal;
            this.metroPanel2.Controls.Add(this.cmdGerarBox);
            this.metroPanel2.Controls.Add(this.cmdSair);
            this.metroPanel2.Controls.Add(this.cmdSalvar);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 223);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(364, 92);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmdGerarBox
            // 
            this.cmdGerarBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGerarBox.Location = new System.Drawing.Point(23, 12);
            this.cmdGerarBox.Name = "cmdGerarBox";
            this.cmdGerarBox.Size = new System.Drawing.Size(88, 66);
            this.cmdGerarBox.TabIndex = 5;
            this.cmdGerarBox.Text = "Gerar Box";
            this.cmdGerarBox.Click += new System.EventHandler(this.cmdGerarBox_Click);
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
            this.cmdSalvar.Location = new System.Drawing.Point(134, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(88, 66);
            this.cmdSalvar.TabIndex = 2;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.cmbEstacionamento);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.nudQtdBox);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(364, 142);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmbEstacionamento
            // 
            this.cmbEstacionamento.FormattingEnabled = true;
            this.cmbEstacionamento.ItemHeight = 23;
            this.cmbEstacionamento.Location = new System.Drawing.Point(167, 27);
            this.cmbEstacionamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstacionamento.Name = "cmbEstacionamento";
            this.cmbEstacionamento.Size = new System.Drawing.Size(170, 29);
            this.cmbEstacionamento.TabIndex = 10;
            this.cmbEstacionamento.SelectedIndexChanged += new System.EventHandler(this.cmbEstacionamento_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(24, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Estacionamento";
            // 
            // nudQtdBox
            // 
            this.nudQtdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdBox.Location = new System.Drawing.Point(167, 87);
            this.nudQtdBox.Name = "nudQtdBox";
            this.nudQtdBox.Size = new System.Drawing.Size(48, 29);
            this.nudQtdBox.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(42, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Qtd de Box:";
            // 
            // FrmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 323);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmBox";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastro de Box";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FrmBox_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton cmdGerarBox;
        private MetroFramework.Controls.MetroButton cmdSair;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.NumericUpDown nudQtdBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbEstacionamento;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}