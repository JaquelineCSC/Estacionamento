using System;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class FrmAcesso : MetroFramework.Forms.MetroForm
    {
        public FrmAcesso()
        {
            InitializeComponent();
        }
        private int idLogin;
        private int idEstacionamento;
        Login lg = new Login();
        Estacionamento park = new Estacionamento();

        public int IdLogin { get => idLogin; set => idLogin = value; }
        public int IdEstacionamento { get => idEstacionamento; set => idEstacionamento = value; }

        private void FrmAcesso_Load(object sender, EventArgs e)
        {
            cmbPark.DisplayMember = "nomeEstacionamento";
            cmbPark.ValueMember = "idEstacionamento";
            cmbPark.DataSource = park.ListarEstacionamento().Tables[0];
            cmdEntrar.Enabled = false;
            cmbPark.Text = "";

            cmbLogin.Enabled = false;
            cmbLogin.Text = "";
            txtSenha.Enabled = false;            
        }

        private void cmbPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdEstacionamento = int.Parse(cmbPark.SelectedValue.ToString());
            cmbLogin.DisplayMember = "nomeLogin";
            cmbLogin.ValueMember = "idLogin";
            cmbLogin.DataSource = lg.ListarLogin().Tables[0];

            cmbLogin.Enabled = true;
            cmbLogin.Text = "";
            txtSenha.Enabled = true;
        }

        private void cmbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdLogin = int.Parse(cmbLogin.SelectedValue.ToString());
            cmdEntrar.Enabled = true;
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            lg.IdLogin = IdLogin;
            lg.ConsultarLogin();

            if (txtSenha.Text == lg.Senha)
            {
                MessageBox.Show("Bem vindo " + lg.NomeLogin + "!", "Login Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPrincipal fp = new FrmPrincipal(IdEstacionamento);
                fp.ShowDialog();
            }
            else
                MessageBox.Show("Caso não tenha um login contate seu gerente!", "Login Negado, tente novamente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
