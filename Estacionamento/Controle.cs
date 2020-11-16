using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Estacionamento
{
    class Controle
    {
        private int idControle;
        private string dataEntrada;
        private string horaEntrada;
        private string horaSaida;
        private double valorTotal;
        private int idVeiculo;
        private int idBox;
        private double valor;

        public int IdControle { get => idControle; set => idControle = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public int IdVeiculo { get => idVeiculo; set => idVeiculo = value; }
        public int IdBox { get => idBox; set => idBox = value; }
        public double Valor { get => valor; set => valor = value; }

        Conexao objConexao = new Conexao();

        public void IncluirControle()
        {
            string sql = "INSERT INTO Controle (dataEntrada, horaEntrada,  idVeiculo, idBox)" +
                 "VALUES ('" + DataEntrada + "','" + HoraEntrada + "'," + IdVeiculo.ToString() + "," + IdBox.ToString() + ")";
            objConexao.Executar(sql);
        }
        public void AlterarControle()
        {
            string sql = "UPDATE Controle SET horaSaida = '" + HoraSaida + "',valorTotal ='" + ValorTotal.ToString().Replace(",", ".") + "'" +
                "WHERE idControle =" + IdControle.ToString();
            objConexao.Executar(sql);
        }
        public DataSet ListarControle()
        {
            string sql = "SELECT * FROM Controle  WHERE idControle = " + IdControle.ToString();
            return objConexao.Listar(sql);
        }
        public void ConsultaEstacionamento()
        {
            string sql = "SELECT valorHora FROM Controle c INNER JOIN Box b ON c.idBox = b.iBox INNER JOIN Estacionamento e ON b.idEstacionamento = e.idEstacionamento" +
                "WHERE c.idBox=" + IdBox.ToString();
            objConexao.Consultar(sql);
            Valor = double.Parse(objConexao.Campos);
        }
        public void ConsultarControle()
        {
            string sql = "";
            sql += "SELECT * FROM Controle WHERE idControle = " + IdControle.ToString();
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            DataEntrada = aux[1];
            HoraEntrada = aux[2];
            HoraSaida = aux[3];
            ValorTotal = double.Parse(aux[4]);
            IdVeiculo = int.Parse(aux[5]);
            IdBox = int.Parse(aux[6]);
        }
    }
}
