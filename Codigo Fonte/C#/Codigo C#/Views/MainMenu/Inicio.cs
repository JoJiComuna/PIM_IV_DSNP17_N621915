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
using Hotelaria.Views;

namespace Hotelaria.Views.Menu
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        StylesController Style;
        Views.Pagamentos.NovoPagamento NovoPag;
        Views.Hospedes.NovoHospede NovoHpd;
        Views.Hospedagens.NovaHospedagem NovaHpm;
        RelatoriosController Relat;



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Views.Login login = (Views.Login)ActiveForm;
            lblUserName.Text = login.txtUsuario.Text;
            login.Hide();
            Style = new StylesController();
            NovoPag = new Pagamentos.NovoPagamento();
            NovoHpd = new Hospedes.NovoHospede();
            NovaHpm = new Hospedagens.NovaHospedagem();
            Relat = new RelatoriosController();
            Relat.Notificar();
            lblNotificar.Text = Relat.Mensagem;

        }



        private void xuiButton4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label6.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {
            NovoHpd = new Hospedes.NovoHospede();
            Style.BackgroundFocus(NovoHpd);
        }

        private void btnFinalizarPagamento_Click(object sender, EventArgs e)
        {
            NovoPag = new Pagamentos.NovoPagamento();
            Style.BackgroundFocus(NovoPag);
        }

        private void btnNovaHospedagem_Click(object sender, EventArgs e)
        {
            NovaHpm = new Hospedagens.NovaHospedagem();
            Style.BackgroundFocus(NovaHpm);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show($" Voce realmente deseja Sair?",
                  "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
