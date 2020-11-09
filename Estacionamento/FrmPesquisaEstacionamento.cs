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
    public partial class FrmPesquisaEstacionamento : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaEstacionamento()
        {
            InitializeComponent();
        }
        Estacionamento park = new Estacionamento();
        private int idEstacionamento;

        public int IdEstacionamento { get => idEstacionamento; set => idEstacionamento = value; }

        private void FrmPesquisaEstacionamento_Load(object sender, EventArgs e)
        {
            park.NomeEstacionamento = "";
            dataGridView1.DataSource = park.ListarEstacionamento().Tables[0];
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
            park.NomeEstacionamento = txtNome.Text;
            dataGridView1.DataSource = park.ListarEstacionamento().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEstacionamento = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
