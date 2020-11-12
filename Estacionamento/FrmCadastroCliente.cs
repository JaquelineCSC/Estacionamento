using MetroFramework.Controls;
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
    public partial class FrmCadastroCliente : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private string status = "Navegando";
        Cliente cliente = new Cliente();
        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdVeiculos_Click(object sender, EventArgs e)
        {
            FrmVeiculo car = new FrmVeiculo();
            car.ShowDialog();
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
                }
            }
            if (status == "Inserindo" || status == "Editando")
            {
                foreach (Control item in this.metroPanel2.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is DateTimePicker)
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
            cliente.Nome = txtNomeCliente.Text;
            cliente.Cpf = txtCpfCliente.Text;
            cliente.DataCadastro = dtpDataCadastro.Value.ToString("yyyy-MM-dd");
            cliente.Fone = txtContato.Text;           

            if (status == "Inserindo")
            {
                cliente.IncluirCliente();
                MessageBox.Show("Cliente Cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (status == "Editando")
            {
                cliente.AlterarDados();
                MessageBox.Show("Cliente alterado com sucesso!!!");
            }
            status = "Navegando";
            LimpaControle();
            HabilitaControle();
            dtpDataCadastro.ResetText();
        }

        private void cmdLocalizaCliente_Click(object sender, EventArgs e)
        {
            FrmLocalizaCliente lc = new FrmLocalizaCliente();
            lc.ShowDialog();
            cliente.IdCliente = lc.IdCliente;
            if (cliente.IdCliente > 0)
            {
                cliente.ConsultarCliente();

                txtNomeCliente.Text = cliente.Nome;
                txtCpfCliente.Text = cliente.Cpf;
                dtpDataCadastro.Text = cliente.DataCadastro;
                txtContato.Text = cliente.Fone;
            }
            status = "Editando";
            HabilitaControle();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (status == "Editando")
                {
                    cliente.ExcluirDados();
                    MessageBox.Show("Excluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }

            }
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            status = "Navegando";
            HabilitaControle();
        }
    }
}
