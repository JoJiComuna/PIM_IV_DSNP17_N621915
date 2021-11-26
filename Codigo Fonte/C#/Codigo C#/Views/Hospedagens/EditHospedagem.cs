using Hotelaria.Controllers;
using System;
using System.Windows.Forms;

namespace Hotelaria.Views.Hospedagens
{
    public partial class EditHospedagem : Form
    {
        public EditHospedagem ( )
        {
            InitializeComponent ();
        }
        HospedagensController Hpc;

        public string GetHospedagem { get; set; }
        public string NomeHospede { get; set; }

        public string NrAdultos ="";
        public string NrCriancas ="";

        private void EditHospedagem_Load ( object sender , EventArgs e )
        {
            Hpc = new HospedagensController ();
            Hpc.Q = new QuartosController ();
            Hpc.NmHospede = NomeHospede;
            //Passar Nº de Hospedagem para pesquisar cadastro
            Hpc.GetNrHospedagem = GetHospedagem;
            //pesquisar NrQuarto 
            Hpc.ConsultarCadastro ();
            Hpc.Q.NrQuarto = Hpc.NrQuarto;
            //Pesquisar valores do quarto da hospedagem 
            Hpc.Q.ObterInfoQuarto();
            Hpc.Q.ObterMaxAcompanhantes (cbxExtraAdulto , cbxExtraCrianca);
            Hpc.Q.ObterPrQuartos (lblPrAdultos , lblPrInfantil , lblPrDiaria);
         
            
        
         
            //Passar os valores consultados para o View
            #region Atribuir valores ao View
            lblNmHospede.Text = $"Nº {Hpc.NrHospedagem}   Hóspede: {NomeHospede}";
            lblQtdAdultos.Text = Hpc.QtdAdultos.ToString ();
            lblQtdInfantil.Text = Hpc.QtdCriancas.ToString ();
            DtCheckIn.MinDate = Hpc.Checkin;
            DtCheckIn.Value = Hpc.Checkin;
            DtCheckOut.MinDate = Hpc.Checkin;
            DtCheckOut.Value = Hpc.Checkout;
         
            Hpc.Q.QtdAdultos = Hpc.QtdAdultos;
            Hpc.Q.QtdCriancas = Hpc.QtdCriancas;
            Hpc.Q.CalcularTotalaPagar(lblTotal);
            #endregion
        }

        private void DtCheckIn_ValueChanged ( object sender , EventArgs e )
        {

            Hpc.Q.Checkin = DtCheckIn.Value;
            Hpc.Q.CalcularTotalaPagar (lblTotal);
            lblQtdDiarias.Text = Hpc.Q.QtdDiaria.ToString ();
            Hpc.Checkin = Hpc.Q.Checkin;
        }

        private void DtCheckOut_ValueChanged ( object sender , EventArgs e )
        {
            //Atualizar valores
            Hpc.Q.Checkout = DtCheckOut.Value;
            Hpc.Q.CalcularTotalaPagar (lblTotal);
            lblQtdDiarias.Text = Hpc.Q.QtdDiaria.ToString ();
            Hpc.Checkout = Hpc.Q.Checkout;
        }

        private void BoxExtraAdulto_SelectedValueChanged ( object sender , EventArgs e )
        {
            //Atualizar valores
            lblQtdAdultos.Text = cbxExtraAdulto.Text;
            Hpc.Q.QtdAdultos = Convert.ToInt32 (lblQtdAdultos.Text);
            Hpc.Q.CalcularTotalaPagar (lblTotal);
            Hpc.QtdAdultos = Hpc.Q.QtdAdultos;
        }

        private void BoxExtraCrianca_SelectedValueChanged ( object sender , EventArgs e )
        {
            //Atualizar valores
            lblQtdInfantil.Text = cbxExtraCrianca.Text;
            Hpc.Q.QtdCriancas = Convert.ToInt32 (lblQtdInfantil.Text);
            Hpc.Q.CalcularTotalaPagar (lblTotal);
            Hpc.QtdCriancas =Hpc.Q.QtdCriancas;
        }

        private void btnAtualizar_Click ( object sender , EventArgs e )
        {
            Hpc.GetNumber = GetHospedagem;
     
            Hpc.Checkin = Convert.ToDateTime(DtCheckIn.Text);
            Hpc.Checkout = Convert.ToDateTime(DtCheckOut.Text);
            Hpc.QtdAdultos = Convert.ToInt32(lblQtdAdultos.Text); 
            Hpc.QtdCriancas = Convert.ToInt32(lblQtdInfantil.Text);
            Hpc.GetNumber= lblTotal.Text.Replace("R$",null);
            Hpc.Q.CalcularTotalaPagar(lblTotal);
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
                Hpc.Atualizar();
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
            else
            {
                MessageBox.Show("Reveja as informações para continuar");
            }

        }

        private void btnCancelar_Click ( object sender , EventArgs e )
        {

        }

        private void lblNrQuarto_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton7_Click(object sender, EventArgs e)
        {

        }
    }
}
