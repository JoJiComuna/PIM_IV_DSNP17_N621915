using Hotelaria.Controllers;
using System;

using System.Windows.Forms;


namespace Hotelaria.Views.Hospedagens
{
    public partial class Hospedagens : Form
    {
        public Hospedagens()
        {
            InitializeComponent();
        }
        HospedagensController H;
        QuartosController Q;
        NovaHospedagem N;
        private void Hospedagens_Load(object sender, EventArgs e)
        {

            H = new HospedagensController();
            H.Consultar();
            DgvHospedagens.DataSource = H.Dgv.DataSource;
            if (H.Mensagem != "")
            {
                MessageBox.Show(H.Mensagem);
            }
            CarregarRegistros();
        }

        private void BtnNovoHospedagem_Click(object sender, EventArgs e)
        {

            N = new NovaHospedagem();
            StylesController Style = new StylesController();
            Style.BackgroundFocus(N);

        }

        private void DgvHospedagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditHospedagem EditHosp = new EditHospedagem();
            EditHosp.GetHospedagem = DgvHospedagens.CurrentRow.Cells[0].Value.ToString();
            EditHosp.NomeHospede = DgvHospedagens.CurrentRow.Cells[1].Value.ToString();
            EditHosp.lblNrQuarto.Text = "Nº &" + DgvHospedagens.CurrentRow.Cells[4].Value.ToString();
            EditHosp.NrAdultos = DgvHospedagens.CurrentRow.Cells[5].Value.ToString();
            EditHosp.NrCriancas = DgvHospedagens.CurrentRow.Cells[6].Value.ToString();

            if (DgvHospedagens.Columns[e.ColumnIndex].Name == "Editar")
            {
                StylesController Style = new StylesController();
                Style.BackgroundFocus(EditHosp);
            }

            if (DgvHospedagens.Columns[e.ColumnIndex].Name == "Deletar")
            {
                H = new HospedagensController();
                H.GetNrHospedagem = DgvHospedagens.CurrentRow.Cells[0].Value.ToString();
                H.NmHospede = DgvHospedagens.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($" Voce realmente deseja Cancelar\n " +
                    $"a Hospedagem Nº {DgvHospedagens.CurrentRow.Cells[0].Value.ToString()} | " +
                    $"Hospede {H.NmHospede}?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    H.Excluir();
                    if (H.Mensagem == "")
                    {
                        MessageBox.Show("Hospedagem e Pagamento Cancelados");
                    }
                    else
                    {
                        MessageBox.Show(H.Mensagem);
                    }
                }
            }
            if (DgvHospedagens.Columns[e.ColumnIndex].Name == "Finalizar")
            {
                H.ID = Convert.ToInt32(DgvHospedagens.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show($" Voce realmente deseja Finalizar\n " +
                 $"a Hospedagem Nº {DgvHospedagens.CurrentRow.Cells[0].Value.ToString()} | " +
                 $"Hospede {H.NmHospede}?",
                 "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    H.FinalizarHospedagem();
                    if (H.Mensagem == "")
                    {
                        MessageBox.Show("Hospedagem  Finalizada(Check-Out)");
                    }
                    else
                    {
                        MessageBox.Show(H.Mensagem);
                    }
                }
            }

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            H = new HospedagensController();
            H.GetHospedagem = TxtSearch.Text;
            H.Procurar();
            DgvHospedagens.DataSource = H.Dgv.DataSource;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            H.Consultar();
            DgvHospedagens.DataSource = H.Dgv.DataSource;
            if (H.Mensagem != "")
            {
                MessageBox.Show(H.Mensagem);
            }
            LblHospedagensCount.Text = DgvHospedagens.Rows.Count.ToString();
            CarregarRegistros();
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Pesquisar Nº de Hospedagem, Nome...")
            {
                TxtSearch.Text = "";
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {

            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Pesquisar Nº de Hospedagem, Nome...";
            }
        }

        public void CarregarRegistros()
        {
            H.ContarRegistros();
            lblCheckinCount.Text = H.CheckinCount.ToString();
            lblReserva.Text = H.ReservasCount.ToString();
            lblCanceladas.Text = H.CanceladosCount.ToString();
            LblHospedagensCount.Text = DgvHospedagens.Rows.Count.ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
