using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Estacionamento
{
    class Estacionamento
    {
        private int idEstacionamento;
        private string nomeEstacionamento;
        private double valorHora;
        private string endereco;

        public int IdEstacionamento { get => idEstacionamento; set => idEstacionamento = value; }
        public string NomeEstacionamento { get => nomeEstacionamento; set => nomeEstacionamento = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        Conexao objConexao = new Conexao();

        public void IncluirEstacionamento()
        {
            string sql = "INSERT INTO Estacionamento (nomeEstacionamento, valorHora, endereco)" +
                 "VALUES ('" + NomeEstacionamento + "','" + ValorHora.ToString().Replace(",", ".") + "','" + Endereco + "')";
            objConexao.Executar(sql);
        }
        public DataSet ListarEstacionamento()
        {
            string sql = "SELECT * FROM Estacionamento  WHERE nomeEstacionamento LIKE '" + NomeEstacionamento + "%'";
            return objConexao.Listar(sql);
        }
        public void ConsultarEstacionamento()
        {
            string sql = "";
            sql += "SELECT * FROM Estacionamento WHERE idEstacionamento = " + IdEstacionamento.ToString();
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            NomeEstacionamento = aux[1];
            ValorHora = double.Parse(aux[2]);
            Endereco = aux[3];
        }
        public void AlterarEstacionamento()
        {
            string sql = "UPDATE Estacionamento SET nomeEstacionamento ='" + NomeEstacionamento + "', valorHora ='" + ValorHora.ToString().Replace(",", ".") +
                "',endereco = '" + Endereco + "'WHERE idEstacionamento = " + IdEstacionamento.ToString();
            objConexao.Executar(sql);
        }
        public void ExcluirEstacionamento()
        {
            string sql = "DELETE FROM Estacionamento WHERE idEstacionamento = " + IdEstacionamento.ToString();
            objConexao.Executar(sql);
        }
    }
}
