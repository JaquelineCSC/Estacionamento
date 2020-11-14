namespace Estacionamento
{
    partial class SaidaVeiculo
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
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtValorTotal = new MetroFramework.Controls.MetroTextBox();
            this.cmdValidarSaida = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Location = new System.Drawing.Point(128, 124);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(235, 20);
            this.dtpDataSaida.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Data/Hora:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 177);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Valor Total (R$):";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(155, 177);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(75, 23);
            this.txtValorTotal.TabIndex = 3;
            // 
            // cmdValidarSaida
            // 
            this.cmdValidarSaida.Location = new System.Drawing.Point(176, 222);
            this.cmdValidarSaida.Name = "cmdValidarSaida";
            this.cmdValidarSaida.Size = new System.Drawing.Size(75, 23);
            this.cmdValidarSaida.TabIndex = 4;
            this.cmdValidarSaida.Text = "Validar";
            // 
            // SaidaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 292);
            this.Controls.Add(this.cmdValidarSaida);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtpDataSaida);
            this.Name = "SaidaVeiculo";
            this.Text = "SaidaVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtValorTotal;
        private MetroFramework.Controls.MetroButton cmdValidarSaida;
    }
}