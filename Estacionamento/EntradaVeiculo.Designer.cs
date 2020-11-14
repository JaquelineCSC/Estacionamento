namespace Estacionamento
{
    partial class EntradaVeiculo
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
            this.SuspendLayout();
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Location = new System.Drawing.Point(103, 107);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(313, 20);
            this.dtpDataEntrada.TabIndex = 0;
            this.dtpDataEntrada.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Data/Hora:";
            // 
            // cmdValidarEntrada
            // 
            this.cmdValidarEntrada.Location = new System.Drawing.Point(181, 140);
            this.cmdValidarEntrada.Name = "cmdValidarEntrada";
            this.cmdValidarEntrada.Size = new System.Drawing.Size(75, 23);
            this.cmdValidarEntrada.TabIndex = 2;
            this.cmdValidarEntrada.Text = "Validar";
            // 
            // EntradaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 186);
            this.Controls.Add(this.cmdValidarEntrada);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtpDataEntrada);
            this.Name = "EntradaVeiculo";
            this.Text = "EntradaVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cmdValidarEntrada;
    }
}