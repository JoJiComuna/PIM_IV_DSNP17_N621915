using Hotelaria.Controllers;
using System;
using System.Windows.Forms;
using Hotelaria.Views.Hospedes;

namespace Hotelaria.Views.Hospedagens
{
    public partial class NovaHospedagem : Form
    {
        public NovaHospedagem()
        {
            InitializeComponent();
        }
        string Msg = "";
        HospedagensController Hpc;
        Hospedescontroller Hc;
        QuartosController Q;
        StylesController Style;
        private void NovaHospedagem_Load(object sender, EventArgs e)
        {
          
            //Carrega a informação de todas as ComboBox
            #region Inicializadores
            Style = new StylesController();
            Q = new QuartosController();
            Q.SetTipoQuarto(cbxTipoQuarto);
            //passar o tipo do quarto para seleção dos quartos com o tipo selecionado
            Q.NmQuarto = cbxTipoQuarto.Text;
            //Obter quartos com o tipo de quarto selecionado
            Q.VerificarTipoQuarto(cbxTipoQuarto, cbxNomeQuarto);
     

            DgvHospedes.ColumnHeadersVisible = false;
            DtCheckIn.Value = DateTime.Now;
            DtCheckOut.Value = DateTime.Now;
            DtCheckIn.MinDate = DateTime.Now;
            DtCheckOut.MinDate = DateTime.Now;
            #endregion
        }

        private void BoxTipoQuarto_SelectedValueChanged(object sender, EventArgs e)
        {
            Q.VerificarTipoQuarto(cbxTipoQuarto, cbxNomeQuarto);
            //Obtem informações novas referentes ao novo tipo de quarto selecionado
            #region Carregar Informaçoes do quarto
            lblQtdAdultos.Text = "0"; Q.QtdAdultos = 0;
            lblQtdCriancas.Text = "0"; Q.QtdCriancas = 0;
            Q.ObterMaxAcompanhantes(cbxMaxAdultos, cbxMaxCriancas);
            Q.ObterPrQuartos(lblPrAdultos, lblPrCriancas, lblPrQuarto);
            //lblResposta.Text = Q.Mensagem;
            Q.CalcularTotalaPagar(lblTotal);
            lblDsInfo.Text = Q.DsInfo;
            VerificarData();

            #endregion
        }

        private void BoxExtraAdulto_SelectedValueChanged(object sender, EventArgs e)
        {
            //Passa o valor da combobox adulto selecionado para lbl obter a quantiade atual de adultos
            #region Obter quantidade de adultos extras
            Hpc = new HospedagensController();
            lblQtdAdultos.Text = cbxMaxAdultos.Text;
            Q.QtdAdultos = Convert.ToInt32(lblQtdAdultos.Text);
            Q.CalcularTotalaPagar(lblTotal);
            #endregion
        }

        private void BoxExtraCrianca_SelectedValueChanged(object sender, EventArgs e)
        {
            //Passa o valor da combobox adulto selecionado para lbl obter a quantiade atual de crianças
            #region Ober quantidade de crianças extras
            Hpc = new HospedagensController();
            lblQtdCriancas.Text = cbxMaxCriancas.Text;
            Q.QtdCriancas = Convert.ToInt32(lblQtdCriancas.Text);
            Q.CalcularTotalaPagar(lblTotal);
            #endregion
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            //To Do verificar se data está disponivel 
            //Confirmar informações de hospedagem e realizar a reserva
            Hpc = new HospedagensController();
            if (Msg == "")
            {
                if (DgvHospedes.Rows.Count == 0)
                {
                    MessageBox.Show("Selecione um Hospede para continuar");
                }
                else
                {
                    Hpc.ID = int.Parse(DgvHospedes.CurrentRow.Cells[0].Value.ToString());
                    Hpc.NmHospede = DgvHospedes.CurrentRow.Cells[1].Value.ToString();
                    Hpc.Checkin = Convert.ToDateTime(DtCheckIn.Text);
                    Hpc.Checkout = Convert.ToDateTime(DtCheckOut.Text);
                    Hpc.QtdAdultos = Q.QtdAdultos;
                    Hpc.QtdCriancas = Q.QtdCriancas;
                    Hpc.NrQuarto = int.Parse(cbxNomeQuarto.SelectedValue.ToString());
                    Hpc.PrTotalaPagar = Q.PrTotalaPagar;
                    Q.CalcularTotalaPagar(lblTotal);
                    if (MessageBox.Show($"Cofirmar Hospedagem?\n" +
                     $"\nHospede: {Hpc.NmHospede}" +
                     $"\nCheck- In: {Hpc.Checkin.ToShortDateString()}" +
                     $"\nCheck- Out: {Hpc.Checkout.ToShortDateString()}" +
                     $"\nAdultos: {Hpc.QtdAdultos}" +
                     $"\nCrianças: {Hpc.QtdCriancas}" +
                     $"\nQuarto Nº: {Hpc.NrQuarto}" +
                     $"\nValor {lblTotal.Text}" +
                     $"\n", "Dados da Hospedagem",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Hpc.Incluir();
                    }
                    if (Hpc.Mensagem == "")
                    {
                        MessageBox.Show("Concluído");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(Hpc.Mensagem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um Quarto Disponível para Continuar");
            }
        }

        private void DtCheckOut_ValueChanged(object sender, EventArgs e)
        {
            //atualizar valores das tarifas a pagar com base em quantos dias o hospede vai reservar
            Q.Checkout = DtCheckOut.Value.Date;
            Q.CalcularTotalaPagar(lblTotal);
            lblQtdDiarias.Text = Q.QtdDiaria.ToString();
            VerificarData();
        }

        private void DtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            //atualizar valores das tarifas a pagar com base em quantos dias o hospede vai reservar
            Q.Checkin = DtCheckIn.Value.Date;
            Q.CalcularTotalaPagar(lblTotal);
            lblQtdDiarias.Text = Q.QtdDiaria.ToString();
            VerificarData();
        }

        private void btncSearch_Click(object sender, EventArgs e)
        {
            //Procurar e exibir Hospede caso exista
            #region Procurar hospede no sistema para reservar

            if (TxtHospede.Text == null || TxtHospede.Text == "")
            {
                lblVerificar.Visible = true;
                DgvHospedes.DataSource = null;
            }
            else
            {

                Hc = new Hospedescontroller();
                Hc.GetHospede = TxtHospede.Text;

                Hc.Procurar();
                DgvHospedes.DataSource = Hc.Dgv.DataSource;
                lblVerificar.Visible = false;
                DgvHospedes.ColumnHeadersVisible = true;
                lblDica.Visible = true;

            }
            #endregion
        }

        private void DgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar o hospede selecionado ao clicar em linha do datagrid
            lblDica.Text = ($"Hospede selecionado: {DgvHospedes.CurrentRow.Cells[1].Value.ToString()}");
            TxtHospede.Text = DgvHospedes.CurrentRow.Cells[0].Value.ToString();


        }

      

        private void btnSelectHospede_Click(object sender, EventArgs e)
        {
            TabHospedagem.SelectedTab = Hospedes;
        }

        private void Hospedes_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TabHospedagem.SelectedTab = Hospedagem;
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {
            NovoHospede novoHospede = new NovoHospede();

            Style.BackgroundFocus(novoHospede);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtHospede_Leave(object sender, EventArgs e)
        {
            if (TxtHospede.Text == "")
            {
                TxtHospede.Text = "Pesquisar por nome, documento...";
            }
        }

        private void TxtHospede_Click(object sender, EventArgs e)
        {
            if (TxtHospede.Text == "Pesquisar por nome, documento...")
            {
                TxtHospede.Text = "";
            }
        }

        private void cbxNomeQuarto_SelectedValueChanged(object sender, EventArgs e)
        {
        
         

        }


        public void VerificarData() {

            Hpc = new HospedagensController();

            Hpc.VerificarDataDisponivel(DtCheckIn.Value, DtCheckOut.Value, cbxNomeQuarto.SelectedValue.ToString());
            if (Hpc.Mensagem != "")
            {
                Msg = Hpc.Mensagem;
                lblIndisponivel.Visible = true;
                lblDisponivel.Visible = false;
                lblCheck.Text = Msg;
            }
            else
            {
                Msg = "";
                lblDisponivel.Visible = true;
                lblIndisponivel.Visible = false;
                lblCheck.Text = "Disponível";
            };

        }

        private void lblDisponivel_Click(object sender, EventArgs e)
        {

        }
    }
        
    
}
