using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Estacionamento
{
    class Login
    {
        int idLogin;
        string nomeLogin;
        string senha;

        public int IdLogin { get => idLogin; set => idLogin = value; }
        public string NomeLogin { get => nomeLogin; set => nomeLogin = value; }
        public string Senha { get => senha; set => senha = value; }

        Conexao objConexao = new Conexao();

        public void IncluirLogin()
        {
            string sql = "INSERT INTO Login (nomeLogin, senhaLogin)" +
                 "VALUES ('" + NomeLogin + "','" + Senha + "')";
            objConexao.Executar(sql);
        }
        public void AlterarLogin()
        {
            string sql = "UPDATE Login SET nomeLogin ='" + NomeLogin + "', senhaLogin ='" + Senha + "WHERE idLogin = " + IdLogin.ToString();
            objConexao.Executar(sql);
        }
        public DataSet ListarLogin()
        {
            string sql = "SELECT * FROM Login  WHERE nomeLogin LIKE '" + NomeLogin + "%'";
            return objConexao.Listar(sql);
        }
        public void ConsultarLogin()
        {
            string sql = "";
            sql += "SELECT * FROM Login WHERE idLogin = " + IdLogin.ToString();
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            NomeLogin = aux[1];
            Senha = aux[2];
        }
    }
}
