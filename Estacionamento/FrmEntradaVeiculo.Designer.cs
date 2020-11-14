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
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmdValidarEntrada = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(132, 113);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(276, 20);
            this.dtpDataEntrada.TabIndex = 0;
            this.dtpDataEntrada.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(12, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Data/Hora:";
            // 
            // cmdValidarEntrada
            // 
            this.cmdValidarEntrada.Location = new System.Drawing.Point(138, 6);
            this.cmdValidarEntrada.Name = "cmdValidarEntrada";
            this.cmdValidarEntrada.Size = new System.Drawing.Size(106, 50);
            this.cmdValidarEntrada.TabIndex = 2;
            this.cmdValidarEntrada.Text = "Validar";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Teal;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 81);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(392, 75);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Teal;
            this.metroPanel2.Controls.Add(this.cmdValidarEntrada);
            this.metroPanel2.CustomBackground = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 187);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(392, 63);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // FrmEntradaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 292);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "FrmEntradaVeiculo";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Entrada Veiculo";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cmdValidarEntrada;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}