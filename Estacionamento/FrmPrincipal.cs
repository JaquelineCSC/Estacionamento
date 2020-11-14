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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

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
            
            cc.ShowDialog();
        }
    }
}
