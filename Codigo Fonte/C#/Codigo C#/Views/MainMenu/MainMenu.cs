using System;
using Hotelaria.Controllers;
using MaterialSkin;
using MaterialSkin.Controls;
using Hotelaria.Views.Hospedes;
using Hotelaria.Views;


using System.Windows.Forms;



namespace Hotelaria.Views.Menu
{
    public partial class MainMenu : MaterialForm
    {
        readonly MaterialSkinManager manager;
        StylesController M = new StylesController ();
        Hospedes.Hospedes H = new Hospedes.Hospedes ();
        Hospedagens.Hospedagens hospedagens = new Hospedagens.Hospedagens ();
        Pagamentos.Pagamentos P = new Pagamentos.Pagamentos ();
        Inicio dashBoard = new Inicio ();
        Calendario calendar = new Calendario ();
        Relatorios relatorios = new Relatorios ();
        ADM.ADMMenu ADMMenu = new ADM.ADMMenu();

        public string Mensagem { get; set; }

        public MainMenu ( )
        {
            InitializeComponent ();
            manager = MaterialSkinManager.Instance;
            manager.EnforceBackcolorOnAllComponents = false;
            manager.AddFormToManage (this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme (Primary.Grey700 , Primary.Indigo900 , Primary.Indigo50 , Accent.Indigo700 , TextShade.WHITE);
        }

        private void MainMenu_Load ( object sender , EventArgs e )
        {
            M.OpenForms (dashBoard , PanelInicio);

            M.OpenForms(relatorios, panelRelatorios);
            M.OpenForms (H , PanelHospedes);
            M.OpenForms (hospedagens , PanelHospedagens);
            M.OpenForms (P , PanelPagamentos);
            M.OpenForms(ADMMenu, PanelADM);
           
        }

        private void tabMainMenu_Selected ( object sender , TabControlEventArgs e )
        {
            MainMenu m = new MainMenu ();

            string txt = e.TabPage.Text;

            switch (txt) {

                case "Início":
                this.Text = "   Início";
                break;

                case "Relatórios":
                this.Text = "   Relatórios";
                break;

                case "Calendário":
                this.Text = "   Calendário";
                break;

                case "Hóspedes":
                this.Text = "   Hóspedes";
                break;

                case "Hospedagens":
                this.Text = "   Hospedagens";
                break;

                case "Pagamentos":
                this.Text = "   Pagamentos";
                break;

                case "Administração":
                this.Text = "   Administração";
                break;

            }



        }




   
    }
}
