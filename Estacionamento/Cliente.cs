using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Cliente
    {
        private int idCliente;
        private string nome;
        private string cpf;
        private string fone;
        private string dataCadastro;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Fone { get => fone; set => fone = value; }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }

        Conexao objConexao = new Conexao();

        public void IncluirCliente()
        {
            string sql = "INSERT INTO Cliente (nomeCliente, cpfCliente, foneCliente, dataCadastro)" +
                 "VALUES ('" + Nome + "','" + Cpf + "','" + Fone + "','" + DataCadastro + "')";
            objConexao.Executar(sql);
        }

        public DataSet ListarCliente()
        {
            string sql = "SELECT * FROM Cliente  WHERE nomeCliente LIKE '" + Nome + "%'";
            return objConexao.Listar(sql);
        }

        public void ConsultarCliente()
        {
            string sql = "";
            sql += "SELECT * FROM Cliente WHERE idCliente = " + IdCliente.ToString();
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            Nome = aux[1];
            Cpf = aux[2];
            Fone = aux[3];
            DataCadastro = aux[4];
        }

        public void AlterarDados()
        {
            string sql = "UPDATE Cliente SET nomeCliente ='" + Nome + "', cpfCliente ='" + Cpf + "',foneCliente ='" + Fone + "',dataCadastro ='" + DataCadastro + "'WHERE idCliente = " + IdCliente.ToString();
            objConexao.Executar(sql);
        }
        public void ExcluirDados()
        {
            string sql = "DELETE FROM Cliente WHERE idCliente = " + IdCliente.ToString();
            objConexao.Executar(sql);
        }
    }
}
