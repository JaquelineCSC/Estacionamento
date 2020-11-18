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
    public partial class FrmSaidaVeiculo : MetroFramework.Forms.MetroForm
    {
        public FrmSaidaVeiculo(int IdEstacionamento)
        {
            InitializeComponent();
            this.IdEstacionamento = IdEstacionamento;
        }

        private int IdEstacionamento;
        Controle controle = new Controle();
        Box box = new Box();
        private int idControle;
        private string horaSaida;
        private float valorTotal;
        private double tempo;
        private int idBox;

        private void FrmSaidaVeiculo_Load(object sender, EventArgs e)
        {
            cmdConfirmar.Enabled = false;
            cmdImprimir.Enabled = false;
            timer1.Enabled = true;
            dataGridView1.DataSource = controle.ListarControleSaida().Tables[0];
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpHoraSaida.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            cmdConfirmar.Enabled = true;
            TimeSpan timeTotal = new TimeSpan();

            controle.IdControle = IdControle;
            controle.ConsultarControle();

            timeTotal = TimeSpan.Parse(dtpHoraSaida.Text) - TimeSpan.Parse(controle.HoraEntrada);

            tempo = timeTotal.Hours;
            if (tempo < 1)
                tempo = 1;
            txtTotalHora.Text = tempo.ToString();
            box.IdEstacionamento = IdEstacionamento;
            box.ConsultaValor();           
            controle.HoraSaida = dtpHoraSaida.Text;
            horaSaida = dtpHoraSaida.Text;
            controle.ValorTotal = (((float)tempo) * box.Valor);
            valorTotal = controle.ValorTotal;
            txtValorTotal.Text = controle.ValorTotal.ToString("R$0.00");
            box.GetBox();
            IdBox1 = box.IdBox;
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.FindForm();
            this.Close();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            box.IdBox = IdBox1;
            box.Status = "free";
            box.AlterarBox();
            controle.IdControle = IdControle;
            controle.HoraSaida = horaSaida;
            controle.ValorTotal = valorTotal;
            controle.AlterarControle();
            MessageBox.Show("Efetuar Pagamento!", "Saida Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmdConfirmar.Enabled = false;
            cmdImprimir.Enabled = true;
            LimpaControle();

            dataGridView1.DataSource = controle.ListarControleSaida().Tables[0];
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }
        private void LimpaControle()
        {
            foreach (Control item in this.metroPanel1.Controls)
            {
                if (item is MetroTextBox)
                    item.Text = "";
            }
        }
        private int i;
        public int IdBox1 { get => idBox; set => idBox = value; }
        public int IdControle { get => idControle; set => idControle = value; }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Comprovante de Estacionamento";
            pd.BeginPrint += Pd_BeginPrint;// sera executada antes de começar a impressão
            pd.PrintPage += Imprimir;//toda vez que tiver uma nova pagina ele ira executar

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();

            cmdConfirmar.Enabled = false;
            cmdImprimir.Enabled = false;            
        }

        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            controle.IdControle = IdControle;
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
            linha = "Comprovante de Estacionamento";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, titulo, Brushes.DarkBlue, margemEsquerda + 140, posicaoHorizontal);

            contador += 4;//para dar espaço estre o titulo e subtitulo

            //subtitulo 
            linha = "Num Box";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda , posicaoHorizontal);

            linha = "Placa";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 100, posicaoHorizontal);

            linha = "Cliente";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 250, posicaoHorizontal);

            linha = "Tempo";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 500, posicaoHorizontal);

            linha = "Valor Pago";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.DeepSkyBlue, margemEsquerda + 650, posicaoHorizontal);

            contador++;

            //passar traço
            linha = "__________________________________________________________________________________________";
            posicaoHorizontal = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoHorizontal);

            contador++;

            //dados
            DataSet ds = controle.ListarImprimir();

            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    linha = item["numBox"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 3, posicaoHorizontal);


                    linha = item["placa"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 99, posicaoHorizontal);

                    linha = item["nomeCliente"].ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 250, posicaoHorizontal);

                    linha = tempo.ToString() + " Hora(s)";
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 500, posicaoHorizontal);

                    linha = "R$ "+ valorTotal.ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 650, posicaoHorizontal);

                    contador+=10;
                    i++;

                }

                if (contador < linhaPorPagina)
                {
                    linha = "Quantidade de Entrada: " + i.ToString();
                    posicaoHorizontal = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.DarkBlue, margemEsquerda, posicaoHorizontal);

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdControle = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }

}
