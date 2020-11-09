using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Estacionamento
{
    public partial class FrmPesquisaVeiculo : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaVeiculo()
        {
            InitializeComponent();
        }
        private int idVeiculo;
        Veiculo car = new Veiculo();

        public int IdVeiculo { get => idVeiculo; set => idVeiculo = value; }

        private void FrmPesquisaVeiculo_Load(object sender, EventArgs e)
        {
            car.Placa = "";
            dataGridView1.DataSource = car.ListarVeiculo().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            car.Placa = txtPlaca.Text;
            dataGridView1.DataSource = car.ListarVeiculo().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdVeiculo= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
