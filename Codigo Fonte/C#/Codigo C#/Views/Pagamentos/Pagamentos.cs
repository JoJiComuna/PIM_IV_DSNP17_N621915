using Hotelaria.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria.Views.Pagamentos
{
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();
        }
        PagamentosController pagCobtroller;
        StylesController Style;

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            pagCobtroller = new PagamentosController();

            CarregarRegistros();
            Style = new StylesController();
        }

        private void BtnNovoPagamento_Click(object sender, EventArgs e)
        {
            NovoPagamento P = new NovoPagamento();
            StylesController Style = new StylesController();
            Style.BackgroundFocus(P);
        }

        private void DgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //passar valores da linha selecionada para caixas de texto de novo hospede / campos a serem atualizados
            NovoPagamento nP = new NovoPagamento();
            nP.NrHospedagem = Convert.ToInt32(DgvPagamentos.CurrentRow.Cells[1].Value.ToString());

            if (DgvPagamentos.Columns[e.ColumnIndex].Name == "Editar")
            {
                nP.cbxTipoPagamento.Text = DgvPagamentos.CurrentRow.Cells[3].Value.ToString();
                Style.BackgroundFocus(nP);
            }
            if (DgvPagamentos.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show($"Cancelar Pagamento? " +
                    $"\nHospedagem: {nP.NrHospedagem}" +
                    $"\n", "Dados do Pagamento",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pagCobtroller.GetNumber = DgvPagamentos.CurrentRow.Cells[0].Value.ToString();
                    pagCobtroller.Excluir();
                    if (pagCobtroller.Mensagem == "")
                    {
                        MessageBox.Show("Pagamento Cancelado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show(pagCobtroller.Mensagem);
                    };
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Pesquisar por Nº de Pagamento...";
            }
        }


        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Pesquisar por Nº de Pagamento...")
            {
                TxtSearch.Text = "";
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            pagCobtroller.GetPagamento = TxtSearch.Text;
            pagCobtroller.Procurar();
            DgvPagamentos.DataSource = pagCobtroller.Dgv.DataSource;
        }

        public void CarregarRegistros()
        {
            pagCobtroller.Consultar();
            DgvPagamentos.DataSource = pagCobtroller.Dgv.DataSource;
            pagCobtroller.ContarRegistros();
            LblPagamentosCount.Text = pagCobtroller.PagamentosCount.ToString();
            lblReceber.Text = String.Format("{0:C}", pagCobtroller.Pagos.ToString());
            lblPendentesCount.Text = String.Format("{0:C}", pagCobtroller.Pendente.ToString());
        }

        private void DgvPagamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Style.FormatarDinheiro(e,4);
        }
    }
}

