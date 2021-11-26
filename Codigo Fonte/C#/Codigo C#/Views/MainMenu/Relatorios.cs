using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotelaria.Controllers;


namespace Hotelaria.Views.Menu
{
    public partial class Relatorios : Form
    {
        public Relatorios ( )
        {
            InitializeComponent ();
        }
        RelatoriosController Relat  ;
        


        private void Relatorios_Load(object sender, EventArgs e)
        {
     
            CarregarRegistros();

        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
        public void CarregarRegistros()
        {
            try
            {
                Relat = new RelatoriosController();
                Relat.ContarRegistros(DtAtual.Value);
                lblHospedesCount.Text = Relat.HospedesCount.ToString();
                lblHospedagensCount.Text = Relat.HospedagensCount.ToString();
                lblCheckinCount.Text = Relat.CheckinCount.ToString();
                lblCheckoutCount.Text = Relat.CheckoutCount.ToString();
                lblCanceladosCount.Text = Relat.CanceladosCount.ToString();
                lblOcupados.Text = Relat.Ocupados.ToString();
                lblReservas.Text = Relat.ReservasCount.ToString();
                lblReceber.Text = String.Format("{0:C}", Relat.aReceber);
                Relat.taxaOcupacao = Relat.Ocupados / Relat.QuartosCount * 100;
                progressbar.Value = Convert.ToInt32(Relat.taxaOcupacao);
                progressbar.Text = progressbar.Value.ToString() + "%";
                lblSaldo.Text = String.Format("{0:C}", Relat.Saldo);
                lblQuartosCount.Text = (Relat.QuartosCount - Relat.Ocupados).ToString();
                lblDiariaMedia.Text = String.Format("{0:C}", Relat.DiariaMedia);
            }
            catch (Exception)
            {
                MessageBox.Show("Alguns dados são insuficientes para gerar Relatórios");
            }
           
        }

        private void Relatorios_Enter(object sender, EventArgs e)
        {
            CarregarRegistros();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
          
            CarregarRegistros();
        }
    }
}
