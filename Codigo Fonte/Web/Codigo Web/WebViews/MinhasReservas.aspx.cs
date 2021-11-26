using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hotelaria.Controllers;

namespace Web.WebViews
{
    public partial class MinhasReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HospedagensController hospedagens = new HospedagensController();
            Session["ID"] = Session["ID"];
            hospedagens.ID = int.Parse(Session["ID"].ToString());
        
            hospedagens.ConsultarSite();
            if (hospedagens.Mensagem == "")
            {

                dgvReservas.DataSource = hospedagens.Conn.dataTable;
                dgvReservas.DataBind();
                
                
            

            }
            else 
            {
                lblDs_Msg.Text = hospedagens.Mensagem;
                lblDs_Msg.Visible = true;
            }
          


        }

        protected void dgvReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnNovaReserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservar.aspx");
        
        }

        protected void dgvReservas_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void linkPerfil_Click(object sender, EventArgs e)
        {
            Session["ID"] = Session["ID"];
            Response.Redirect("InfoHospede.aspx");
          
        }

        protected void linkReservas_Click(object sender, EventArgs e)
        {
            Session["ID"] = Session["ID"];
            Response.Redirect("MinhasReservas.aspx");
        }
    }
}