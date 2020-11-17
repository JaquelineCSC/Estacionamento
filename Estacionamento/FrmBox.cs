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
    public partial class FrmBox : MetroFramework.Forms.MetroForm
    {
        public FrmBox()
        {
            InitializeComponent();
        }
        private string status;
        private int IdEstacionamento;
        private Estacionamento park = new Estacionamento();
        private Box box = new Box();
        private void LimpaControle()
        {
            foreach (Control item in this.metroPanel1.Controls)
            {
                if (item is MetroTextBox)
                    item.Text = "";
                if (item is NumericUpDown)
                    item.Text = "";
            }

        }
        private void HabilitaControle()
        {
            cmdGerarBox.Enabled = (status == "Navegando");
            cmdSalvar.Enabled = (status == "Inserindo" || status == "Editando");            

            if (status == "Inserindo")
            {
                foreach (Control item in this.metroPanel1.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is MetroComboBox)
                        item.Enabled = true;
                    if (item is NumericUpDown)
                        item.Enabled = true;
                }
            }
            if (status == "Inserindo" || status == "Editando")
            {
                foreach (Control item in this.metroPanel1.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is MetroComboBox)
                        item.Enabled = true;
                    if (item is NumericUpDown)
                        item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in this.metroPanel1.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = false;
                    if (item is MetroComboBox)
                        item.Enabled = false;
                    if (item is NumericUpDown)
                        item.Enabled = false;
                }
            }
        }

        private void FrmBox_Load(object sender, EventArgs e)
        {
            cmbEstacionamento.DisplayMember = "nomeEstacionamento";
            cmbEstacionamento.ValueMember = "idEstacionamento";
            cmbEstacionamento.DataSource = park.ListarEstacionamento().Tables[0];
            status = "Navegando";
            HabilitaControle();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdGerarBox_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudQtdBox.Value; i++)
            {
                box.NumBox = i;
                box.IdEstacionamento = IdEstacionamento;
                box.Status = "free";
                if (status == "Inserindo")
                {
                    box.IncluirBox();
                }
                if (status == "Editando")
                {
                    box.AlterarBox();
                }
            }
            MessageBox.Show("Box cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            status = "Navegando";
            LimpaControle();
            HabilitaControle();
        }

        private void cmbEstacionamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEstacionamento = int.Parse(cmbEstacionamento.SelectedValue.ToString());
        }
    }
}
