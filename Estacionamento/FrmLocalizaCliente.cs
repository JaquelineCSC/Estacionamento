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
    public partial class FrmLocalizaCliente : MetroFramework.Forms.MetroForm
    {
        public FrmLocalizaCliente()
        {
            InitializeComponent();
        }
        Cliente cliente = new Cliente();
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }

        private void FrmLocalizarProduto_Load(object sender, EventArgs e)
        {
            cliente.Nome = "";
            dataGridView1.DataSource = cliente.ListarCliente().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            dataGridView1.DataSource = cliente.ListarCliente().Tables[0];
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IdCliente = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }
    }
}
