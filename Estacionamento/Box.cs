﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Estacionamento
{
    class Box
    {
        private int idBox;
        private int numBox;
        private int idEstacionamento;
        private string status;
        private float valor;

        public int IdBox { get => idBox; set => idBox = value; }
        public int NumBox { get => numBox; set => numBox = value; }
        public int IdEstacionamento { get => idEstacionamento; set => idEstacionamento = value; }
        public string Status { get => status; set => status = value; }
        public float Valor { get => valor; set => valor = value; }

        Conexao objConexao = new Conexao();

        public void IncluirBox()
        {
            string sql = "INSERT INTO Box (numBox, idEstacionamento,status)" +
                 "VALUES (" + NumBox + "," + IdEstacionamento + ",'" + Status + "')";
            objConexao.Executar(sql);
        }
        public void AlterarBox()
        {
            string sql = "UPDATE Box SET status='" + Status + "'WHERE idBox = " + IdBox.ToString();
            objConexao.Executar(sql);
        }
        public void ExcluirBox()
        {
            string sql = "DELETE FROM Box WHERE idBox = " + IdBox.ToString();
            objConexao.Executar(sql);
        }
        public DataSet ListarBox()
        {
            string sql = "SELECT * FROM Box WHERE idEstacionamento = " + IdEstacionamento + "AND status LIKE 'free%'";
            return objConexao.Listar(sql);
        }
        public void ConsultaValor()
        {
            string sql = "SELECT DISTINCT e.valorHora FROM Box b inner join Estacionamento e on b.idEstacionamento = e.idEstacionamento WHERE b.idEstacionamento = " + IdEstacionamento;
            objConexao.Consultar(sql);
            string[] aux = objConexao.Campos.Split(';');
            Valor = float.Parse(aux[0]);
        }
    }
}
