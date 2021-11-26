using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;

namespace Web.WebViews
{
    public partial class TrocarSenha : System.Web.UI.Page
    {
        Hospedescontroller hpdController;

        protected void Page_Load(object sender, EventArgs e)
        {
            string Password = txtSenha.Text;
            txtSenha.Attributes.Add("value", Password);
            txtSenha.Attributes["value"] = txtSenha.Text;

            string Password1 = txtSenha.Text;
            txtSenha1.Attributes.Add("value", Password1);
            txtSenha1.Attributes["value"] = txtSenha1.Text;

        }

        protected void btnConfrimar_Click(object sender, EventArgs e)
        {
            hpdController = new Hospedescontroller();
            if (lblDs_Msg.Visible == false && txtSenha.Text.Length >= 4)
            {
                hpdController.VerificarEmail(txtEmail.Text);
                if (hpdController.Mensagem == "")
                {
                    imgDisponivel.ImageUrl = "~/Images/confirme.png";
                    imgDisponivel.Visible = true;

                    hpdController.loginController = new LoginController();
                    hpdController.loginController.Ds_Senha = txtSenha.Text;
                    hpdController.AtualizarSenha();
                    if (hpdController.Mensagem == "")
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        lblDs_Msg.Text = hpdController.Mensagem;
                        lblDs_Msg.Visible = true;
                    };
                }

                else
                {
                    imgDisponivel.ImageUrl = "~/Images/cancel.png";
                    imgDisponivel.Visible = true;

                };
            }
            else
            {
                lblDs_Msg.Text = "a Nova Senha deve ter pelo menos 5 caracteres";
                lblDs_Msg.Visible = true;
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

    }

}