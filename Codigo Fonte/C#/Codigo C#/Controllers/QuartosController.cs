using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelaria.Models;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using Label = System.Windows.Forms.Label;

namespace Hotelaria.Controllers
{
    public class QuartosController : Quartos
    {
        public QuartosController() { }

        private Validacao validar;
        public void SetTipoQuarto(ComboBox cboxTipoQuarto)
        {
            try
            {
                ObterTipoQuarto();
                cboxTipoQuarto.DisplayMember = "Nm_TipoQuarto";
                cboxTipoQuarto.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                this.Conn = null;
                this.Conn.dataTable = null;
                MessageBox.Show("não foi possivel carregar as informações do quarto");
            }
        }
        public void SetTipoQuarto(DropDownList cboxTipoQuarto)
        {
            try
            {
                ObterTipoQuarto();
                cboxTipoQuarto.DataTextField = "Nm_TipoQuarto";           
                cboxTipoQuarto.DataSource = this.Conn.dataTable;
                cboxTipoQuarto.DataBind();
            }
            catch (Exception)
            {
                this.Conn = null;
                this.Conn.dataTable = null;
                Mensagem =("não foi possivel carregar as informações do quarto");
            }
        }

        public void VerificarTipoQuarto(ComboBox cbxTipoQuarto, ComboBox cbxNmQuarto)
        {
            //Enquanto nome do  quarto for diferente do tipo de quarto selecionado chama a o metodo de obter informaçoes do quarto
            while (NmQuarto != cbxTipoQuarto.Text)
            {
                NmQuarto = cbxTipoQuarto.Text;
              

                ObterInfoQuarto();


                cbxNmQuarto.DisplayMember = "Nm_Quarto";
                cbxNmQuarto.ValueMember = "Nr_Quarto";
                cbxNmQuarto.DataSource = this.Conn.dataTable;
                //}

                break;
            }
        }
        public void VerificarTipoQuarto(DropDownList cbxTipoQuarto, DropDownList cbxNmQuarto)
        {
            //Enquanto nome do  quarto for diferente do tipo de quarto selecionado chama a o metodo de obter informaçoes do quarto
            while (NmQuarto != cbxTipoQuarto.Text)
            {
                NmQuarto = cbxTipoQuarto.Text;


                ObterInfoQuarto();


                cbxNmQuarto.DataTextField = "Nm_Quarto";
                cbxNmQuarto.DataValueField = "Nr_Quarto";
                cbxNmQuarto.DataSource = this.Conn.dataTable;
                cbxNmQuarto.DataBind();
                //}

                break;
            }
        }

        public void ObterMaxAcompanhantes(ComboBox Adultos, ComboBox Criancas)
        {
            ObterInfoQuarto();
            Adultos.Items.Clear();
            Criancas.Items.Clear();

            for (int i = 0; i < this.MaxAdultos; i++)
            {
                Adultos.Items.Add(1 + i);
            }
            for (int i = 0; i < this.MaxCriancas; i++)
            {
                Criancas.Items.Add(1 + i);
            }
        }
        public void ObterMaxAcompanhantes(DropDownList Adultos, DropDownList Criancas)
        {
            ObterInfoQuarto();
            Adultos.Items.Clear();
            Criancas.Items.Clear();
            Adultos.Items.Add("0");
            Criancas.Items.Add("0");

            for (int i = 0; i < this.MaxAdultos; i++)
            {
                Adultos.Items.Add((i+1).ToString());
            }
            for (int i = 0; i < this.MaxCriancas; i++)
            {
                Criancas.Items.Add((i+1).ToString());
            }
        }

        public void ObterPrQuartos(Label prAdultos, Label prCriancas, Label prQuarto)
        {
            prAdultos.Text = String.Format("{0:C}", PrExtraAdultos);
            prCriancas.Text = String.Format("{0:C}", PrExtraCriancas);
            prQuarto.Text = String.Format("{0:C}", PrQuarto);
        }

        public void CalcularTotalaPagar(Label total)
        {
        

            //calular quantidade de diarias
            this.QtdDiaria = 1 + (this.Checkout.Date - this.Checkin.Date).TotalDays;

            //Obter quantidades e calcular valores a pagar
            #region Calculos

            //qtd adutlos * preço por adulto
            this.TotalAdultos = 0 + this.QtdAdultos * this.PrExtraAdultos;


            //qtd crianças * preço por criança
            this.TotalCriancas = 0 + this.QtdCriancas * this.PrExtraCriancas;

            //qtd de diarias * preço por diaria
            this.TotalDiarias = 0 + Convert.ToInt32(this.QtdDiaria) * this.PrQuarto;

            // valor total a pagar (soma de preços crianças adultos e tarifa do quarto)
            this.PrTotalaPagar = 0 + (this.TotalAdultos + this.TotalCriancas + this.TotalDiarias);

            total.Text = String.Format("{0:C}", this.PrTotalaPagar);

            #endregion

        }
        public void CalcularTotalaPagar(System.Web.UI.WebControls.Label total)
        {


            //calular quantidade de diarias
            this.QtdDiaria = 1 + (this.Checkout.Date - this.Checkin.Date).TotalDays;

            //Obter quantidades e calcular valores a pagar
            #region Calculos

            //qtd adutlos * preço por adulto
            this.TotalAdultos = 0 + this.QtdAdultos * this.PrExtraAdultos;


            //qtd crianças * preço por criança
            this.TotalCriancas = 0 + this.QtdCriancas * this.PrExtraCriancas;

            //qtd de diarias * preço por diaria
            this.TotalDiarias = 0 + Convert.ToInt32(this.QtdDiaria) * this.PrQuarto;

            // valor total a pagar (soma de preços crianças adultos e tarifa do quarto)
            this.PrTotalaPagar = 0 + (this.TotalAdultos + this.TotalCriancas + this.TotalDiarias);

            total.Text = String.Format("{0:C}", this.PrTotalaPagar);

            #endregion

        }

        public override void IncluirQuarto()
        {
            VerificarQuarto();
            if (validar.Mensagem == "valido")
            {
                base.IncluirQuarto();

            }
        }

        public override void AtualizarQuarto()
        {
            VerificarQuarto();
            if (validar.Mensagem == "valido")
            {
                base.AtualizarQuarto();
            }
        }

        public override void AtualizarTipoQuarto()
        {
            validar = new Validacao();
            VerificarTipoQuarto();
            if (validar.Mensagem == "valido")
            {
                base.AtualizarTipoQuarto();
            }
        }

        public override void IncluirTipoQuarto()
        {
            validar = new Validacao();
            VerificarTipoQuarto();
            if (validar.Mensagem == "valido")
            {
                base.IncluirTipoQuarto();
            }

        }

        public void VerificarQuarto()
        {
            validar = new Validacao();
            validar.ValidarCamposQuartos(this);
            switch (validar.ValidarCamposQuartos(this))
            {
                case 0:
                    break;
                case 1:
                    Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";
                    MessageBox.Show(Mensagem);
                    break;
            }
        }

        public void VerificarTipoQuarto()
        {

            validar = new Validacao();
            validar.ValidarCamposTipoQuartos(this);
            switch (validar.ValidarCamposTipoQuartos(this))
            {
                case 0:
                    validar.ConverterCamposTipoQuarto(this);
                    if (validar.Mensagem != "valido")
                    {
                        MessageBox.Show(validar.Mensagem);
                    }
                    break;

                case 1:
                    Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";
                    MessageBox.Show(Mensagem);
                    break;
            }
        }
    }
}


