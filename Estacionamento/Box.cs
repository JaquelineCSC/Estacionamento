using System;
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

        public int IdBox { get => idBox; set => idBox = value; }
        public int NumBox { get => numBox; set => numBox = value; }
        public int IdEstacionamento { get => idEstacionamento; set => idEstacionamento = value; }

        Conexao objConexao = new Conexao();

        public void IncluirBox()
        {
            string sql = "INSERT INTO Box (numBox, idEstacionamento)" +
                 "VALUES (" + NumBox + "," + IdEstacionamento + ")";
            objConexao.Executar(sql);
        }
        public void AlterarBox()
        {
            string sql = "UPDATE Box SET numBox =" + NumBox + ", idEstacionamento =" + IdEstacionamento + "WHERE idBox = " + IdBox.ToString();
            objConexao.Executar(sql);
        }
        public void ExcluirBox()
        {
            string sql = "DELETE FROM Box WHERE idBox = " + IdBox.ToString();
            objConexao.Executar(sql);
        }
        public DataSet ListarBox()
        {
            string sql = "SELECT * FROM Box  WHERE idControle = " + IdBox.ToString();
            return objConexao.Listar(sql);
        }
    }
}
