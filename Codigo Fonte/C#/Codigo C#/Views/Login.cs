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



namespace Hotelaria.Views
{
    public partial class Login : Form
    {
        public Login ( )
        {
            InitializeComponent ();
        }
        LoginController LogController;
        Views.Menu.MainMenu main;
        StylesController styles;

        private void Login_Load(object sender, EventArgs e)
        {
            main = new Menu.MainMenu();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            LogController = new LoginController();
            LogController.Verificar(txtUsuario.Text,    txtSenha.Text);
            if (LogController.Mensagem == "valido")
            {
               
                main.Show();
               

            }
            else
            {
                MessageBox.Show(LogController.Mensagem);
            }
            

        }

        private void lblMostrarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = (char)0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            styles = new StylesController();
            ADM.RecuperarSenha novaSenha = new ADM.RecuperarSenha();
            styles.BackgroundFocus(novaSenha);
        }
    }
}
