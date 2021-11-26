using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace Web.WebViews
{
    public partial class Reservar : System.Web.UI.Page
    {
       
        int IDHospede;
        QuartosController qrtController;
        HospedagensController HpmController;
        protected void Page_Load(object sender, EventArgs e)
        {
            qrtController = new QuartosController();
            Session["ID"] = Session["ID"];
            HpmController = new HospedagensController();
            IDHospede = Convert.ToInt32(Session["ID"]);

            if (!IsPostBack)
            {

                qrtController.SetTipoQuarto(dropTipoQuarto);
                qrtController.VerificarTipoQuarto(dropTipoQuarto, dropNmQuarto);
                qrtController.ObterMaxAcompanhantes(dropAdultos, dropCriancas);
                txtDsInfoQuarto.Text = qrtController.DsInfo;


            }

        }


        protected void btnReservar_Click(object sender, EventArgs e)
        {

            if (lblDs_Msg.Visible == false)
            {

                qrtController.NmQuarto = dropTipoQuarto.Text;
                qrtController.ObterInfoQuarto();

                qrtController.QtdAdultos = Convert.ToInt32(dropAdultos.Text);
                qrtController.QtdCriancas = Convert.ToInt32(dropCriancas.Text);
                qrtController.Checkin = Convert.ToDateTime(Checkin.Text);
                qrtController.Checkout = Convert.ToDateTime(Checkout.Text);
                qrtController.CalcularTotalaPagar(lblTotal);


                HpmController.ID = IDHospede;
                HpmController.Checkin = Convert.ToDateTime(Checkin.Text);
                HpmController.Checkout = Convert.ToDateTime(Checkout.Text);
                HpmController.QtdAdultos = qrtController.QtdAdultos;
                HpmController.QtdCriancas = qrtController.QtdCriancas;
                HpmController.NrQuarto = int.Parse(dropNmQuarto.SelectedValue.ToString());
                HpmController.PrTotalaPagar = qrtController.PrTotalaPagar;



                HpmController.Incluir();
                if (HpmController.Mensagem == "")
                {
                    Response.Redirect("MinhasReservas.aspx");
                }
                else
                {
                    lblDs_Msg.Text = HpmController.Mensagem;
                    lblDs_Msg.Visible = true;
                };
            }
            else 
            {
                lblDs_Msg.Text = "Reveja as informações para continuar";
            }
        }

        protected void Checkout_TextChanged(object sender, EventArgs e)
        {
         
            if (IsPostBack)
            {
                AtualizarPagina();
                lblTotalTexto.Visible = true;
            }
         

        }
        public void AtualizarPagina()
        {
            try
            {
                qrtController.NmQuarto = dropTipoQuarto.Text;
                qrtController.ObterInfoQuarto();
                qrtController.QtdAdultos = Convert.ToInt32(dropAdultos.Text);
                qrtController.QtdCriancas = Convert.ToInt32(dropCriancas.Text);
                qrtController.Checkout = Convert.ToDateTime(Checkout.Text);
                qrtController.Checkin = Convert.ToDateTime(Checkin.Text);
                qrtController.CalcularTotalaPagar(lblTotal);
                HpmController.Checkin = qrtController.Checkin;
                HpmController.Checkout = qrtController.Checkout;
                HpmController.VerificarDataDisponivel(HpmController.Checkin, HpmController.Checkout, dropNmQuarto.SelectedValue.ToString());
                if (HpmController.Mensagem == "")
                {
                    imgDisponivel.ImageUrl = "~/Images/confirme.png";
                    imgDisponivel.Visible = true;
                    lblDs_Msg.Visible = false;

                }
                else
                {
                    imgDisponivel.ImageUrl = "~/Images/cancel.png";
                    imgDisponivel.Visible = true;
                    lblDs_Msg.Text = HpmController.Mensagem;
                    lblDs_Msg.Visible = true;

                }
            }
            catch (Exception)
            {
              
            }
           
        }

        protected void Checkin_TextChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                AtualizarPagina();
            }
         
        }

        protected void dropTipoQuarto_TextChanged(object sender, EventArgs e)
        {
          
            qrtController.VerificarTipoQuarto(dropTipoQuarto, dropNmQuarto);
            qrtController.ObterMaxAcompanhantes(dropAdultos, dropCriancas);
            txtDsInfoQuarto.Text = qrtController.DsInfo;
        }
    }
}