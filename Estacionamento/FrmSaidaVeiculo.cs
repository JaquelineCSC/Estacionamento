using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class FrmSaidaVeiculo : MetroFramework.Forms.MetroForm
    {
        public FrmSaidaVeiculo(int IdEstacionamento)
        {
            InitializeComponent();
            this.IdEstacionamento = IdEstacionamento;
        }

        private int IdEstacionamento;
        Controle controle = new Controle();
        Box box = new Box();
        private int idControle;
        
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    idControle = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        //}

        private void FrmSaidaVeiculo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dataGridView1.DataSource = controle.ListarControleSaida().Tables[0];
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpHoraSaida.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            TimeSpan timeTotal = new TimeSpan();

            controle.IdControle = idControle;
            controle.ConsultarControle();

            timeTotal =TimeSpan.Parse(dtpHoraSaida.Text) - TimeSpan.Parse(controle.HoraEntrada); 

            double tempo = timeTotal.Hours;
            txtTotalHora.Text = tempo.ToString();
            box.IdEstacionamento = IdEstacionamento;
            box.ConsultaValor();
            controle.HoraSaida = dtpHoraSaida.Text;
            controle.ValorTotal = (((float)tempo) * box.Valor);

            txtValorTotal.Text = controle.ValorTotal.ToString("R$0.00");
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idControle = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
