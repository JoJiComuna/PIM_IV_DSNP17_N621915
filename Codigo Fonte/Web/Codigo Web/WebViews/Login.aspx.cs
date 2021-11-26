using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        LoginController loginController;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
           
            loginController = new LoginController();
            loginController.VerificarLoginHospede(txtLogin.Text,txtSenha.Text);
            if (loginController.Mensagem == "")
            {
                Session["ID"] = loginController.ID;
                Response.Redirect("InfoHospede.aspx");
            }
            else
            {
                lblDs_Msg.Text = loginController.Mensagem;
                lblDs_Msg.Visible = true;
            }
      
        }

        protected void lblNovaSenha_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrocarSenha.aspx");
        }

        protected void NovoLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("NovoLogin.aspx");
        }
    }
}