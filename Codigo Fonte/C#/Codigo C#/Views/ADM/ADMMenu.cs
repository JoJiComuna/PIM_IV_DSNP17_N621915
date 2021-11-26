using System;
using System.Windows.Forms;
using Hotelaria.Controllers;
using Hotelaria.Views.Hospedes;

namespace Hotelaria.Views.ADM

{
    public partial class ADMMenu : Form
    {
        public ADMMenu()
        {
            InitializeComponent();
        }

        Usuarios users;
        StylesController Style;
        TipoQuarto TipoQuarto;
        Quartos Quartos;
        ChavedeSeguranca Key;
        HospedesInativos hospedesInativos;
        ControledePatrimonio patrimonios;

        private void ADMMenu_Load(object sender, EventArgs e)
        {
            hospedesInativos = new HospedesInativos();
            users = new Usuarios();
            Style = new StylesController();
            TipoQuarto = new TipoQuarto();
            Quartos = new Quartos();
            Key = new ChavedeSeguranca();



            patrimonios = new ControledePatrimonio();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label6.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(users, main.PanelADM);

        }

        private void btnTipoQuarto_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(TipoQuarto, main.PanelADM);

        }

        private void bntQuartos_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(Quartos, main.PanelADM);
        }

        private void btnChavedeSeguranca_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(Key, main.PanelADM);
        }

        private void btnHospedesInativos_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(hospedesInativos, main.PanelADM);
        }

        private void btnPatrimonios_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(patrimonios, main.PanelADM);
        }


    }
}
