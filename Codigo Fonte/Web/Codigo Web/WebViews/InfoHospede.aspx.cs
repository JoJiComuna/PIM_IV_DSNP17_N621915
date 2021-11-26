using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;

namespace Web.WebViews
{
    public partial class InfoHospede : System.Web.UI.Page
    {
        Hospedescontroller hpdController;
        public int IDHospede;
        protected void Page_Load(object sender, EventArgs e)
        {
            hpdController = new Hospedescontroller();
            Session["ID"] = Session["ID"];
            IDHospede = Convert.ToInt32(Session["ID"]);
            hpdController.GetID = IDHospede.ToString();
        
      
            hpdController.ConsultarCadastroLogin();
            if (hpdController.Mensagem == "")
            {
              txtNmHospede.Text = hpdController.NmHospede;
                txtCPF.Text = hpdController.Documento.ToString();
                txtTelefone.Text = hpdController.Telefone.ToString();
                txtEmail.Text = hpdController.Email;
                //
                txtCidade.Text = hpdController.endrController.Cidade;
                txtBairro.Text = hpdController.endrController.Bairro;
                txtRua.Text = hpdController.endrController.Rua;
                txtNrEndereco.Text = hpdController.endrController.NrEndereco.ToString();
                dropUF.Items.Add( hpdController.endrController.Estado);
              
               

                
            }
            else
            {
                lblDs_Msg.Text = hpdController.Mensagem;
                lblDs_Msg.Visible = true;
            }


        }

        protected void linkReservas_Click(object sender, EventArgs e)
        {
            Session["ID"] = Session["ID"];
            Response.Redirect("MinhasReservas.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            hpdController = new Hospedescontroller();
            hpdController.endrController = new EnderecoController();
            hpdController.loginController = new LoginController();
            //HospedesINfo
            hpdController.Nome = txtNmHospede.Text;
            hpdController.GetDocumento = txtCPF.Text;
            hpdController.GetTelefone = txtTelefone.Text;
            hpdController.Email = Session["Email"].ToString();
            //Endereço
            hpdController.endrController.Estado = dropUF.Text;
            hpdController.endrController.Cidade = txtCidade.Text;
            hpdController.endrController.Bairro = txtBairro.Text;
            hpdController.endrController.Rua = txtRua.Text;
            hpdController.endrController.GetNrEndereco = txtNrEndereco.Text;
            hpdController.Atualizar();
            if (hpdController.Mensagem == "")
            {
                lblDs_Msg.Text = "Cadastro Atualizado!";
                lblDs_Msg.Visible = true;
            }
            else
            {
                lblDs_Msg.Text = hpdController.Mensagem;
                lblDs_Msg.Visible = true;
            }
        }
    }
}