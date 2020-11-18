using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MetroFramework.Controls;

namespace Estacionamento
{
    public partial class FrmConsulta : MetroFramework.Forms.MetroForm
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }
        private Cliente cliente = new Cliente();
        private Veiculo veiculo = new Veiculo();
        private Controle controle = new Controle();
        private int idVeiculo;
        private void FrmConsulta_Load(object sender, EventArgs e)
        {            
            cmbPlaca.DisplayMember = "placa";
            cmbPlaca.ValueMember = "idVeiculo";
            cmbPlaca.DataSource = veiculo.ListarVeiculo().Tables[0];
            cmbCliente.Text = "";
            cmbPlaca.Text = "";
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            idVeiculo = int.Parse(cmbPlaca.SelectedValue.ToString());
            veiculo.IdVeiculo = idVeiculo;
            cmbCliente.DisplayMember = "nomeCliente";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = veiculo.ListarVeiculoporCliente().Tables[0];                       
        }
        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            cmbCliente.Text = "";
            cmbPlaca.Text = "";
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Movimentação de Cliente";
            pd.BeginPrint += Pd_BeginPrint;// sera executada antes de começar a impressão
            pd.PrintPage += Imprimir;//toda vez que tiver uma nova pagina ele ira executar

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();

        }
        private int i;
        private double y;
        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
            y = 0;
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            veiculo.IdVeiculo = idVeiculo;
            //config da pagina
            float linhaPorPagina = 0;
            float posicaoHorizontal = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";

            //definição da fonte
            Font fonte = new Font("Arial", 14);
            Font titulo = new Font("Arial", 22);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);

            //titulo do relatorio
            linha = "Movimentação de Cliente";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, titulo, Brushes.DarkBlue, margemEsquerda + 140, posicaoHorizontal);

            contador += 4;//para dar espaço estre o titulo e subtitulo

            //subtitulo 
            linha = "Placa";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda, posicaoHorizontal);

            linha = "Carro";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 110, posicaoHorizontal);

            linha = "Cliente";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 190, posicaoHorizontal);

            linha = "Cpf";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 400, posicaoHorizontal);

            linha = "Data";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 550, posicaoHorizontal);

            linha = "Valor R$";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 700, posicaoHorizontal);

            contador++;

            //passar traço
            linha = "__________________________________________________________________________________";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoHorizontal);

            contador++;

            //dados
            DataSet ds = veiculo.ListarConsulta();

            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    linha = item["placa"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda , posicaoHorizontal);


                    linha = item["modelo"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 110, posicaoHorizontal);

                    linha = item["nomeCliente"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 190, posicaoHorizontal);

                    linha = item["cpfCliente"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 400, posicaoHorizontal);

                    linha = item["dataEntrada"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 550, posicaoHorizontal);

                    if (item["valorTotal"] is DBNull)
                    {
                        linha = "Em aberto";
                        posicaoHorizontal = margemSuperior + contador * alturaFonte;
                        ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 709, posicaoHorizontal);
                    }
                    else
                    {
                        y += Convert.ToDouble(item["valorTotal"]);
                        linha = item["valorTotal"].ToString();
                        posicaoHorizontal = margemSuperior + contador * alturaFonte;
                        ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 750, posicaoHorizontal);
                    }

                    contador += 3;
                    i++;

                }

                if (contador < linhaPorPagina)
                {
                    linha = "__________________________________________________________________________________";
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoHorizontal);

                    contador++;

                    linha = "Quantidade de Entrada: " + i.ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.DarkBlue, margemEsquerda + 10, posicaoHorizontal);
                    
                    contador += 2;

                    linha = "Valor Total Gasto: " + y.ToString("R$0.00");
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.DarkBlue, margemEsquerda + 10, posicaoHorizontal);

                    contador += 4;

                    linha = "A Pare e Pague Sistemas de Estacionamento agradece a preferencia!";
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.DarkBlue, margemEsquerda + 80, posicaoHorizontal);

                }
            }
            else MessageBox.Show("Tabela Vazia!!", "Atenção");
            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;//cria outra pagina e começa dnv
            }
            else
            {
                ev.HasMorePages = false;
            }
        }       
    }
}
