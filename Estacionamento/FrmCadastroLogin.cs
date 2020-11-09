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
    public partial class FrmCadastroLogin : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroLogin()
        {
            InitializeComponent();
        }

        Login lg = new Login();
        private int idFunc;
        private int idLogin;
        public int IdFunc { get => idFunc; set => idFunc = value; }
        public int IdLogin { get => idLogin; set => idLogin = value; }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            lg.NomeLogin = txtNomeLogin.Text;
            lg.Senha = txtSenha.Text;

            lg.IncluirLogin();
        }
    }
}
