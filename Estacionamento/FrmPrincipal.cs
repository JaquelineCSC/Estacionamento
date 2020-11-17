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
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal(int IdEstacionamento)
        {
            InitializeComponent();
            this.IdEstacionamento = IdEstacionamento;
        }
        private int IdEstacionamento;
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cc = new FrmCadastroCliente();
            cc.ShowDialog();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastraFuncionario cf = new FrmCadastraFuncionario();
            cf.ShowDialog();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeiculo car = new FrmVeiculo();
            car.ShowDialog();
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cc = new FrmCadastroCliente();
            cc.ShowDialog();
        }

        private void estacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastraEstacionamento ce = new FrmCadastraEstacionamento();
            ce.ShowDialog();
        }

        private void entradaVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaVeiculo fev = new FrmEntradaVeiculo(IdEstacionamento);
            fev.ShowDialog();
        }

        private void cmdEntada_Click(object sender, EventArgs e)
        {
            FrmEntradaVeiculo fev = new FrmEntradaVeiculo(IdEstacionamento);
            fev.ShowDialog();
        }

        private void saidaVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaidaVeiculo fsv = new FrmSaidaVeiculo(IdEstacionamento);
            fsv.ShowDialog();
        }

        private void cmdSaida_Click(object sender, EventArgs e)
        {
            FrmSaidaVeiculo fsv = new FrmSaidaVeiculo(IdEstacionamento);
            fsv.ShowDialog();
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta fc = new FrmConsulta();
            fc.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta fc = new FrmConsulta();
            fc.ShowDialog();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JaquelineCSC/Estacionamento");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
