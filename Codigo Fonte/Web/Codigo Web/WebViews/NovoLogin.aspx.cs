using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;

namespace Web.WebViews
{
    public partial class NovoLogin : System.Web.UI.Page
    {
        LoginController loginController;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string Password = txtSenha.Text;
            txtSenha.Attributes.Add("value", Password);
            txtSenha.Attributes["value"] = txtSenha.Text;

            string Password1 = txtSenha.Text;
            txtSenha1.Attributes.Add("value", Password1);
            txtSenha1.Attributes["value"] = txtSenha1.Text;
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            if (lblDs_Msg.Visible == false)
            {
                loginController = new LoginController();
                loginController.Ds_Email = txtEmail.Text;
                loginController.Ds_Login = txtUser.Text;
                loginController.Ds_Senha = txtSenha.Text;
                loginController.VerificarLoginHospede();
                if (loginController.Mensagem == "")
                {
                    Session["Email"] = txtEmail.Text;
                    Session["Login"] = txtUser.Text;
                    Session["Senha"] = txtSenha.Text;
                    Response.Redirect("DadosNovoLogin.aspx");
                }
                else
                {
                    lblDs_Msg.Text = loginController.Mensagem;
                    lblDs_Msg.Visible = true;
                }
            }
            else 
            {
                lblDs_Msg.Text = "Preencha os campos (*) corretamente para continuar ";
            }
           


        }

        protected void txtSenha1_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenha1.Text)
            {
                lblDs_Msg.Text = "As Senhas não conferem";
                lblDs_Msg.Visible = true;
            }
            else
            {
                lblDs_Msg.Text = "";
                lblDs_Msg.Visible = false;
            }
        }

        protected void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtSenha1.Text)
            {
                lblDs_Msg.Text = "As Senhas não conferem";
                lblDs_Msg.Visible = true;
            }
            else
            {
                lblDs_Msg.Text = "";
                lblDs_Msg.Visible = false;
            }
        }
    }
}