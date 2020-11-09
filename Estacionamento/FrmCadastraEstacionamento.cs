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
    public partial class FrmCadastraEstacionamento : MetroFramework.Forms.MetroForm
    {
        public FrmCadastraEstacionamento()
        {
            InitializeComponent();
        }
        private string status = "Navegando";
        Estacionamento park = new Estacionamento();
        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }
        private void LimpaControle()
        {
            foreach (Control item in this.metroPanel2.Controls)
            {
                if (item is MetroTextBox)
                    item.Text = "";
            }

        }
        private void HabilitaControle()
        {
            cmdNovo.Enabled = (status == "Navegando");
            cmdSalvar.Enabled = (status == "Inserindo" || status == "Editando");
            cmdExcluir.Enabled = (status == "Editando");

            if (status == "Inserindo")
            {
                foreach (Control item in this.metroPanel2.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is DateTimePicker)
                        item.Enabled = true;
                    if (item is MetroComboBox)
                        item.Enabled = true;
                }
            }
            if (status == "Editando")
            {
                foreach (Control item in this.metroPanel2.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is DateTimePicker)
                        item.Enabled = true;
                    if (item is MetroComboBox)
                        item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in this.metroPanel2.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = false;
                    if (item is DateTimePicker)
                        item.Enabled = false;
                    if (item is MetroComboBox)
                        item.Enabled = false;
                }
            }
        }
        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            park.NomeEstacionamento = txtNome.Text;
            park.ValorHora = double.Parse(txtValorHora.Text);
            park.Endereco = txtEndereco.Text;

            if (status == "Inserindo")
            {
                park.IncluirEstacionamento();
                MessageBox.Show("Estacionamento Cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (status == "Editando")
            {
                park.AlterarEstacionamento();
                MessageBox.Show("Estacionamento alterado com sucesso!!!");
            }
            status = "Navegando";
            LimpaControle();
            HabilitaControle();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (status == "Editando")
                {
                    park.ExcluirEstacionamento();
                    MessageBox.Show("Excluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }

        private void cmdLocalizaEstacionamento_Click(object sender, EventArgs e)
        {
            FrmPesquisaEstacionamento pe = new FrmPesquisaEstacionamento();
            pe.ShowDialog();

            park.IdEstacionamento = pe.IdEstacionamento;
            if (park.IdEstacionamento > 0)
            {
                park.ConsultarEstacionamento();

                txtNome.Text = park.NomeEstacionamento;
                txtValorHora.Text = park.ValorHora.ToString();
                txtEndereco.Text = park.Endereco;
            }
            status = "Editando";
            HabilitaControle();
        }

        private void FrmCadastraEstacionamento_Load(object sender, EventArgs e)
        {
            status = "Navegando";
            HabilitaControle();
        }
    }
}
