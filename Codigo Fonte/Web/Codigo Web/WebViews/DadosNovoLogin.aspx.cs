using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;

namespace Web.WebViews
{
    public partial class DadosNovoLogin : System.Web.UI.Page
    {
        Hospedescontroller hpdController;


        protected void Page_Load(object sender, EventArgs e)
        {
            dropUF.Items.Add("AC");
            dropUF.Items.Add("AL");
            dropUF.Items.Add("AP");
            dropUF.Items.Add("AM");
            dropUF.Items.Add("BA");
            dropUF.Items.Add("CE");
            dropUF.Items.Add("ES");
            dropUF.Items.Add("GO");
            dropUF.Items.Add("MA");
            dropUF.Items.Add("MA");
            dropUF.Items.Add("MT");
            dropUF.Items.Add("MS");
            dropUF.Items.Add("MG");
            dropUF.Items.Add("PA");
            dropUF.Items.Add("PB");
            dropUF.Items.Add("PR");
            dropUF.Items.Add("PE");
            dropUF.Items.Add("PI");
            dropUF.Items.Add("RJ");
            dropUF.Items.Add("RN");
            dropUF.Items.Add("RS");
            dropUF.Items.Add("RO");
            dropUF.Items.Add("RR");
            dropUF.Items.Add("SC");
            dropUF.Items.Add("SP");
            dropUF.Items.Add("TO");
            dropUF.Items.Add("DF");
            Session["Login"] = Session["Login"];
            Session["Senha"] = Session["Senha"];
            Session["Email"] = Session["Email"];
        }

        protected void txtCadastrar_Click(object sender, EventArgs e)
        {
            hpdController = new Hospedescontroller();
            hpdController.endrController = new EnderecoController();
            hpdController.loginController = new LoginController();
            //HospedesINfo
            hpdController.Nome = txtNmHospede.Text;
            hpdController.GetDocumento = txtCPF.Text;
            hpdController.GetTelefone = TxtTelefone.Text;
            hpdController.Email = Session["Email"].ToString();
            //Endereço
            hpdController.endrController.Estado = dropUF.Text;
            hpdController.endrController.Cidade = txtCidade.Text;
            hpdController.endrController.Bairro = txtBairro.Text;
            hpdController.endrController.Rua = txtRua.Text;
            hpdController.endrController.GetNrEndereco = txtNrEndereco.Text;
            //Login
            hpdController.loginController.Ds_Login = Session["Login"].ToString();
            hpdController.loginController.Ds_Senha = Session["Senha"].ToString();
            //
            hpdController.IncluirComLogin();
            if (hpdController.Mensagem == "")
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblDs_Msg.Text = hpdController.Mensagem;
                lblDs_Msg.Visible = true;
            }


        }
    }
}