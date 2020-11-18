using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    class Funcionario
    {
        private int idFuncionario;
        private string nome;
        private string cpf;
        private string fone;
        private string dataCadastro;
        private string cargo;
        private int idLogin;
        private int idEstacionamento;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Fone { get => fone; set => fone = value; }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int IdLogin { get => idLogin; set => idLogin = value; }
        public int IdEstacionamento { get => idEstacionamento; set => idEstacionamento = value; }

        Conexao objConexao = new Conexao();

        public void IncluirFuncionario()
        {
            string sql = "INSERT INTO Funcionario (nomeFuncionario, cpfFuncionario, foneFuncionario, dataCadastro,cargoFuncionario,idEstacionamento)" +
                 "VALUES ('" + Nome + "','" + Cpf + "','" + Fone + "','" + DataCadastro + "','" + Cargo + "'," + IdEstacionamento + ")";
            objConexao.Executar(sql);
        }
        public DataSet ListarFuncionario()
        {
            string sql = "SELECT * FROM Funcionario WHERE nomeFuncionario LIKE '" + Nome + "%'";
            return objConexao.Listar(sql);
        }
        public void ConsultarFuncionario()
        {
            string sql = "";
            sql += "SELECT * FROM Funcionario WHERE idFuncionario = " + IdFuncionario.ToString();
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            Nome = aux[1];
            Cpf = aux[2];
            Fone = aux[3];
            DataCadastro = aux[4];
            Cargo = aux[5];
            IdEstacionamento = int.Parse(aux[7]);
        }
        public void AlterarDadosFunc()
        {
            string sql = "UPDATE Funcionario SET nomeFuncionario ='" + Nome + "', cpfFuncionario ='" + Cpf + "',foneFuncionario ='" + Fone + "',dataCadastro ='" + DataCadastro + 
                "',cargoFuncionario = '"+ Cargo+"',idEstacionamento="+IdEstacionamento+"WHERE idFuncionario = " + IdFuncionario.ToString();
            objConexao.Executar(sql);
        }
        public void ExcluirDados()
        {
            string sql = "DELETE FROM Funcionario WHERE idFuncionario = " + IdFuncionario.ToString();
            objConexao.Executar(sql);
        }
    }
}
