using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Estacionamento
{
    class Veiculo
    {
        int idVeiculo;
        string placa;
        string marca;
        string modelo;
        string kmVeiculo;
        int idCliente;

        public int IdVeiculo { get => idVeiculo; set => idVeiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string KmVeiculo { get => kmVeiculo; set => kmVeiculo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        Conexao objConexao = new Conexao();

        public void IncluirVeiculo()
        {
            string sql = "INSERT INTO Veiculo (placa, marca, modelo, kmVeiculo,idCliente)" +
                 "VALUES ('" + Placa + "','" + Marca + "','" + Modelo + "','" + KmVeiculo.ToString() + "',"+ IdCliente+ ")";
            objConexao.Executar(sql);
        }
        public DataSet ListarVeiculo()
        {
            string sql = "SELECT * FROM Veiculo  WHERE placa LIKE '" + Placa + "%'";
            return objConexao.Listar(sql);
        }
        public void ConsultarVeiculo()
        {
            string sql = "";
            sql += "SELECT * FROM Veiculo WHERE idVeiculo = " + IdVeiculo.ToString();
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            Placa = aux[1];
            Marca = aux[2];
            Modelo = aux[3];
            KmVeiculo = aux[4];
            IdCliente = int.Parse(aux[5]);
        }
        public void AlterarDadosVeiculo()
        {
            string sql = "UPDATE Veiculo SET placa ='" + Placa + "', marca ='" + Marca + "',modelo ='" + Modelo + "',kmVeiculo ='" + KmVeiculo +
                "',idCliente = " + IdCliente + "WHERE idVeiculo = " + IdVeiculo.ToString();
            objConexao.Executar(sql);
        }
        public void ExcluirDadosVeiculo()
        {
            string sql = "DELETE FROM Veiculo WHERE idVeiculo = " + IdVeiculo.ToString();
            objConexao.Executar(sql);
        }
    }
}
