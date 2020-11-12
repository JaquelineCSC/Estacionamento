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
    public partial class FrmVeiculo : MetroFramework.Forms.MetroForm
    {    
        public FrmVeiculo()
        {
            InitializeComponent();
        }
        Veiculo veiculo = new Veiculo();
        Cliente cliente = new Cliente();
        private string status = "Navegando";
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }

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
            if (status == "Inserindo" || status == "Editando")
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

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            cmbCliente.DisplayMember = "nomeCliente";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = cliente.ListarCliente().Tables[0];
            status = "Navegando";
            HabilitaControle();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCliente = int.Parse(cmbCliente.SelectedValue.ToString());
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            veiculo.Placa = txtPlaca.Text;
            veiculo.Marca = txtMarca.Text;
            veiculo.Modelo = txtModelo.Text;
            veiculo.KmVeiculo = txtKm.Text;
            veiculo.IdCliente = IdCliente;

            if (status == "Inserindo")
            {
                veiculo.IncluirVeiculo();
                MessageBox.Show("Veiculo Cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (status == "Editando")
            {
                veiculo.AlterarDadosVeiculo();
                MessageBox.Show("Veiculo alterado com sucesso!!!");
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
                    veiculo.ExcluirDadosVeiculo();
                    MessageBox.Show("Excluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }

        private void cmdPesquisaCar_Click(object sender, EventArgs e)
        {
            FrmPesquisaVeiculo pv = new FrmPesquisaVeiculo();
            pv.ShowDialog();

            veiculo.IdVeiculo = pv.IdVeiculo;
            if (veiculo.IdVeiculo != 0)
            {
                veiculo.ConsultarVeiculo();
                
                txtPlaca.Text = veiculo.Placa;
                txtMarca.Text = veiculo.Marca;
                txtModelo.Text = veiculo.Modelo;
                txtKm.Text = veiculo.KmVeiculo;

                cliente.IdCliente = veiculo.IdCliente;
                cliente.ConsultarCliente();
                cmbCliente.Text = cliente.Nome;
            }
            status = "Editando";
            HabilitaControle();
        }
    }
}
