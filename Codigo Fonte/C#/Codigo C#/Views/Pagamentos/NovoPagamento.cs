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
    public partial class NovoPagamento : Form
    {
        public NovoPagamento()
        {
            InitializeComponent();
        }

        public bool NewID;
        public int NrQuarto;
        public int NrHospedagem;
        PagamentosController PagController;

        private void NovoPagamento_Load(object sender, EventArgs e)
        {
         
            //DtPagamento.MinDate = DateTime.Now;
            PagController = new PagamentosController();
            PagController.HpnController = new HospedagensController();
            PagController.QrtController = new QuartosController();
            DtPagamento.Value = DateTime.Now;
            DtPagamento.MinDate = DateTime.Now;
            PagController.DsStatus = "Pendente";
            PagController.GetVlAdcional = "0";

            CheckNew();
            if (NewID == true)
            {
              
                PagController.HpnController.CarregarDadosHospedagens(BoxHospedagem);
 
            }
            else
            {
                PagController.HpnController.GetNrHospedagem = NrHospedagem.ToString();
                PagController.HpnController.CarregarDadosHospedagem(BoxHospedagem);
                PagController.HpnController.ConsultarCadastro();
        
            }

            CarregarHospedagem();
        }

        private void BoxHospedagem_SelectedValueChanged(object sender, EventArgs e)
        {

            PagController.HpnController.GetNrHospedagem = BoxHospedagem.Text.Substring(3, 6);
            PagController.HpnController.ConsultarCadastro();
            CarregarHospedagem();

        }


        private void BoxHospedagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BoxHospedagem.Text == "" || cbxTipoPagamento.Text == "")
            {
                MessageBox.Show("Selecione os campos obrigatórios");
            }
            else
            {
                //mensagem com dados da hospedagem para confirmação de reserva
                if (MessageBox.Show($"Cofirmar Pagamento? " +
                    $"\nHospedagem: {BoxHospedagem.Text}" +
                    $"\nData de Pagamento: {DtPagamento.Text}" +
                    $"\nTipo de Pagamento: {cbxTipoPagamento.Text}" +
                    $"\nAdultos :{lblQtdAdultos.Text} Crianças: {lblQtdInfantil.Text} Diárias: {lblQtdDiarias.Text} " +
                    $"\nValor da Hospedagem {lblTotal.Text}" +
                    $"\n", "Dados do Pagamento",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PagController.dtPagamento = Convert.ToDateTime(DtPagamento.Text);
                    PagController.tipoPagamento = cbxTipoPagamento.Text;
                    PagController.GetNumber = BoxHospedagem.Text.Substring(3, 6);

                    PagController.GetPagamento = lblTotal.Text.Replace("R$", null);

                    PagController.Atualizar();
                    if (PagController.Mensagem == "")
                    {
                        MessageBox.Show("Pagamento Finalizado / Atualizado ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(PagController.Mensagem);
                    };
                }
                else
                {
                    MessageBox.Show("Pagamento não realizado!\nReveja as informações para continuar");
                }
            }
        }

        private void btnPago_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPago.Checked == true)
            {
                PagController.DsStatus = "Pago";
            }
            else
            {
                PagController.DsStatus = "Pendente";
            }
        }

        public void CheckNew()
        {
            if (NrHospedagem == 0)
            {
                NewID = true;
            }
            else
            {
                NewID = false;
            }
        }
        public void CarregarHospedagem()
        {
            lblQtdAdultos.Text = PagController.HpnController.QtdAdultos.ToString();
            lblQtdInfantil.Text = PagController.HpnController.QtdCriancas.ToString();
            PagController.QrtController.NrQuarto = PagController.HpnController.NrQuarto;
            PagController.QrtController.ObterInfoQuarto();
            PagController.QrtController.Checkin = PagController.HpnController.Checkin;
            PagController.QrtController.Checkout = PagController.HpnController.Checkout;
        
            lblQtdDiarias.Text = PagController.QrtController.QtdDiaria.ToString();
            PagController.totalPrDiaria = PagController.QrtController.PrTotalaPagar;
            PagController.QrtController.QtdAdultos = PagController.HpnController.QtdAdultos;
            PagController.QrtController.QtdCriancas = PagController.HpnController.QtdCriancas;



            PagController.QrtController.CalcularTotalaPagar(lblTotal);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Sair? " +
             $"\n", "Dados de Pagamento",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    
    }
}
