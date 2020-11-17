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
    public partial class FrmEntradaVeiculo : MetroFramework.Forms.MetroForm
    {
        public FrmEntradaVeiculo(int IdEstacionamento)
        {
            InitializeComponent();
            this.IdEstacionamento = IdEstacionamento;
        }

        Controle controle = new Controle();
        Veiculo veiculo = new Veiculo();
        Cliente cliente = new Cliente();
        Box box = new Box();

        private int IdEstacionamento;
        private int idVeiculo;
        private string status = "Navegando";
        private int idCliente;
        private int idBox;
        private void LimpaControle()
        {
            foreach (Control item in this.metroPanel1.Controls)
            {
                if (item is MetroTextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
            }

        }
        private void HabilitaControle()
        {
            cmdNovo.Enabled = (status == "Navegando");
            cmdSaida.Enabled = (status == "Inserindo" || status == "Editando");
            cmdSalvar.Enabled = (status == "Inserindo" || status == "Editando");

            if (status == "Inserindo")
            {
                foreach (Control item in this.metroPanel1.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is DateTimePicker)
                        item.Enabled = true;
                    if (item is ComboBox)
                        item.Enabled = true;
                }
            }
            if (status == "Inserindo" || status == "Editando")
            {
                foreach (Control item in this.metroPanel1.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = true;
                    if (item is DateTimePicker)
                        item.Enabled = true;
                    if (item is ComboBox)
                        item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in this.metroPanel1.Controls)
                {
                    if (item is MetroTextBox)
                        item.Enabled = false;
                    if (item is DateTimePicker)
                        item.Enabled = false;
                    if (item is ComboBox)
                        item.Enabled = false;
                }
            }
        }


        private void cmdCadastraCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cc = new FrmCadastroCliente();
            cc.ShowDialog();
        }

        private void cmdCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            FrmVeiculo car = new FrmVeiculo();
            car.ShowDialog();
            cmbPlaca.DataSource = veiculo.ListarVeiculo().Tables[0];
            cmbCliente.DataSource = veiculo.ListarVeiculoporCliente().Tables[0];
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
            box.IdEstacionamento = IdEstacionamento;
            box.ConsultaValor();
            txtValorHora.Text = box.Valor.ToString("R$0.00");
        }

        private void FrmEntradaVeiculo_Load(object sender, EventArgs e)
        {
            cmbPlaca.DisplayMember = "placa";
            cmbPlaca.ValueMember = "idVeiculo";
            cmbPlaca.DataSource = veiculo.ListarVeiculo().Tables[0];

            box.IdEstacionamento = IdEstacionamento;
            cmbBox.DisplayMember = "numBox";
            cmbBox.ValueMember = "idBox";
            cmbBox.DataSource = box.ListarBox().Tables[0];

            timer1.Enabled = true;
            LimpaControle();
            status = "Navegando";
            HabilitaControle();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            controle.IdVeiculo = idVeiculo;
            controle.IdBox = idBox;
            controle.DataEntrada = dtpData.Text;
            controle.HoraEntrada = dtpHoraEntrada.Text;
            box.IdBox = idBox;
            box.Status = "busy";
            box.AlterarBox();

            if (status == "Inserindo")
            {
                controle.IncluirControle();
                MessageBox.Show("Entrada de veiculo registrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (status == "Editando")
            {
                controle.AlterarControle();
                MessageBox.Show("Entrada de veiculo alterado com sucesso!!!");
            }
            status = "Navegando";
            LimpaControle();
            HabilitaControle();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = int.Parse(cmbCliente.SelectedValue.ToString());
        }

        private void cmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            idVeiculo = int.Parse(cmbPlaca.SelectedValue.ToString());
            veiculo.IdVeiculo = idVeiculo;
            cmbCliente.DisplayMember = "nomeCliente";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = veiculo.ListarVeiculoporCliente().Tables[0];
        }

        private void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idBox = int.Parse(cmbBox.SelectedValue.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpHoraEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmdSaida_Click(object sender, EventArgs e)
        {
            FrmSaidaVeiculo sv = new FrmSaidaVeiculo(IdEstacionamento);
            sv.ShowDialog();
        }
    }
}
