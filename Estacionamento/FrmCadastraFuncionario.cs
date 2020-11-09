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
    public partial class FrmCadastraFuncionario : MetroFramework.Forms.MetroForm
    {
        public FrmCadastraFuncionario()
        {
            InitializeComponent();
        }
        private string status = "Navegando";
        Funcionario func = new Funcionario();
        private void cmdSair_Click(object sender, EventArgs e)
        {           
            this.FindForm();
            this.Close();
        }

        private void cmdCadastraLogin_Click(object sender, EventArgs e)
        {
            FrmCadastroLogin cl = new FrmCadastroLogin();
            cl.ShowDialog();

            func.IdLogin = cl.IdLogin;

            status = "Editando";
            HabilitaControle();
        }

        private void FrmCadastraFuncionario_Load(object sender, EventArgs e)
        {
            status = "Navegando";
            HabilitaControle();
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
            if (status == "Editando")
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
            func.Nome = txtNomeFunc.Text;
            func.Cpf = txtCpfFunc.Text;
            func.DataCadastro = dtpDataCadastroFunc.Value.ToString("yyyy-MM-dd");
            func.Fone = txtFoneFunc.Text;
            func.Cargo = txtCargo.Text;
            func.IdEstacionamento = int.Parse(txtIdEstacionamento.Text);
 
            if (status == "Inserindo")
            {
                func.IncluirFuncionario();
                MessageBox.Show("Colaborador Cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (status == "Editando")
            {
                func.AlterarDadosFunc();
                MessageBox.Show("Colaborador alterado com sucesso!!!");
            }
            status = "Navegando";
            LimpaControle();
            HabilitaControle();
            dtpDataCadastroFunc.ResetText();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (status == "Editando")
                {
                    func.ExcluirDados();
                    MessageBox.Show("Excluido com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }

            }
        }

        private void cmdLocalizaFunc_Click(object sender, EventArgs e)
        {
            FrmPesquisaFunc pf = new FrmPesquisaFunc();
            pf.ShowDialog();

            func.IdFuncionario = pf.IdFunc;
            if (func.IdFuncionario != 0)
            {
                func.ConsultarFuncionario();

                txtNomeFunc.Text = func.Nome;
                txtCpfFunc.Text = func.Cpf;
                dtpDataCadastroFunc.Text = func.DataCadastro;
                txtFoneFunc.Text = func.Fone;
                txtCargo.Text = func.Cargo;
                txtIdEstacionamento.Text = func.IdEstacionamento.ToString();
            }
            status = "Editando";
            HabilitaControle();        
        }
    }
}
