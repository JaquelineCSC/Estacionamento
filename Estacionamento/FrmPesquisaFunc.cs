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
    public partial class FrmPesquisaFunc : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaFunc()
        {
            InitializeComponent();
        }
        Funcionario func = new Funcionario();
        private int idFunc;

        public int IdFunc { get => idFunc; set => idFunc = value; }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            func.Nome = txtNome.Text;
            dataGridView1.DataSource = func.ListarFuncionario().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void FrmPesquisaFunc_Load(object sender, EventArgs e)
        {
            func.Nome = "";
            dataGridView1.DataSource = func.ListarFuncionario().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFunc = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
