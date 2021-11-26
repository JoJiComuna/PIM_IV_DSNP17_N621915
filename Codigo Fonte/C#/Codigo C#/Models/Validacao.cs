using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hotelaria.Controllers;
using System.Windows.Forms;


namespace Hotelaria.Models
{
    public class Validacao : Propriedades
    {
        private Hospedescontroller H = new Hospedescontroller();
        //
        //Validar Hóspedes
        #region Validação de Hospedes
        public int ValidarCamposHospede(Hospedescontroller Hospede)
        {
            if (string.IsNullOrEmpty(Hospede.Nome))
                return 1;
            if (string.IsNullOrEmpty(Hospede.GetDocumento) || Hospede.GetDocumento == "0")
                return 1;
            if (string.IsNullOrEmpty(Hospede.GetTelefone) || Hospede.GetTelefone == "0")
                return 1;
            if (string.IsNullOrEmpty(Hospede.Email))
                return 1;
            return 0;
        }

        public int ValidarCamposLoginHospede(LoginController Hospede)
        {
            if (string.IsNullOrEmpty(Hospede.Ds_Email))
                return 1;
            if (string.IsNullOrEmpty(Hospede.Ds_Login))
                return 1;
            if (string.IsNullOrEmpty(Hospede.Ds_Senha))
                return 1;
         
            return 0;
        }

        public void ConverterCamposHospede(Hospedescontroller Hospede)
        {
            try
            {
                Hospede.Documento = Convert.ToInt64(Hospede.GetDocumento);
                Hospede.Telefone = Convert.ToInt64(Hospede.GetTelefone);
                Hospede.ID = Convert.ToInt32(Hospede.GetID);
                Mensagem = "valido";
            }
            catch (Exception)
            {
                Mensagem = "Dados inválidos";
            }
        }
        #endregion
        //
        //Validar Endereços
        #region Validação de Endereços
        public int ValidarCamposEndereco(EnderecoController Hospede)
        {

            if (string.IsNullOrEmpty(Hospede.Estado))
                return 1;
            if (string.IsNullOrEmpty(Hospede.Cidade))
                return 1;
            if (string.IsNullOrEmpty(Hospede.Bairro))
                return 1;
            if (string.IsNullOrEmpty(Hospede.Rua))
                return 1;
            if (string.IsNullOrEmpty(Hospede.GetNrEndereco))
                return 1;
            return 0;
        }

        public void ConverterCamposEndereco(EnderecoController Hospede)
        {
            try
            {
                Hospede.NrEndereco = Convert.ToInt32(Hospede.GetNrEndereco);
                Mensagem = "valido";
            }
            catch (Exception)
            {
                Mensagem = "Dados inválidos";
            }
        }
        #endregion
        //
        //Validar Hospedagens
        #region Validação de Hospedagens

        public int ValidarCamposHospedagem(HospedagensController Hospedagem)
        {
            if (Hospedagem.ID == 0)
                return 1;
            if (string.IsNullOrEmpty(Hospedagem.Checkin.Date.ToString()))
                return 1;
            if (string.IsNullOrEmpty(Hospedagem.Checkout.Date.ToString()))
                return 1;
            if (1+( Hospedagem.Checkout.Date - Hospedagem.Checkout.Date).TotalDays == 0)
            {
                Mensagem = "Data de Check out não pode ser menor que a de Check- in";
                return 1;
            }
              
               
            
            Mensagem = "valido";
            return 0;
        }


        #endregion
        //
        // Validar Quartos
        #region Validação de Quartos

        public int ValidarCamposQuartos(QuartosController Quartos)
        {

            if (string.IsNullOrEmpty(Quartos.NmQuarto))
                return 1;
            if (Quartos.IDTipoQuarto == 0)
                return 1;
            if (string.IsNullOrEmpty(Quartos.DsStatus))
                return 1;
            Mensagem = "valido";
            return 0;
        }

        #endregion
        //
        //ValidarTipoQuartos
        #region Validação de Tipos de Quartos

        public int ValidarCamposTipoQuartos(QuartosController Quartos)
        {

            if (string.IsNullOrEmpty(Quartos.NmTipoQuarto))
                return 1;
            if (string.IsNullOrEmpty(Quartos.GetPrAdultos) || Quartos.GetPrAdultos == "0")
                return 1;
            if (string.IsNullOrEmpty(Quartos.GetPrQuarto) || Quartos.GetPrQuarto == "0")
                return 1;
            if (string.IsNullOrEmpty(Quartos.DsStatus))
                return 1;
            Mensagem = "valido";
            return 0;
        }

        public void ConverterCamposTipoQuarto(QuartosController Quartos)
        {
            try
            {
                Quartos.PrExtraAdultos = Convert.ToDecimal(Quartos.GetPrAdultos);
                Quartos.PrExtraCriancas = Convert.ToDecimal(Quartos.GetPrCriancas);
                Quartos.PrQuarto = Convert.ToDecimal(Quartos.GetPrQuarto);
                Quartos.MaxAdultos = Convert.ToInt32(Quartos.GetMaxAdultos);
                Quartos.MaxCriancas = Convert.ToInt32(Quartos.GetMaxCriancas);
                Mensagem = "valido";
            }
            catch (Exception)
            {
                Mensagem = "Entradas inválidas";
            }
        }
        #endregion
        //
        //Validar Usuarios
        #region Validar Campos Usuarios
        public int ValidarCamposUsuario(UsuarioController User, LoginController Log)
        {
            if (string.IsNullOrEmpty(User.Nome))
                return 1;
            if (string.IsNullOrEmpty(User.GetDocumento) || User.GetDocumento == "0")
                return 1;
            if (string.IsNullOrEmpty(User.Email))
                return 1;
            if (string.IsNullOrEmpty(Log.Ds_Login))
                return 1;
            if (string.IsNullOrEmpty(Log.Ds_Senha))
                return 1;
            if (string.IsNullOrEmpty(Log.TipoUsuario))
                return 1;
            return 0;
        }
        //
        //Converter Campos Usuario
        public void ConverterCamposUsuario(UsuarioController User)
        {
            try
            {
                User.Documento = Convert.ToInt64(User.GetDocumento);
                User.Telefone = Convert.ToInt64(User.GetTelefone);
                Mensagem = "valido";
            }
            catch (Exception)
            {
                Mensagem = "Dados inválidos";
            }
        }
        #endregion
        //
        //Validar Pagamentos
        public void ConverterCamposPagamentos(PagamentosController Pagamentos)
        {

            try
            {
                Pagamentos.NrPagamento = Convert.ToInt32(Pagamentos.GetNumber);
                Pagamentos.totalaPagar = Convert.ToDecimal(Pagamentos.GetPagamento);
                Pagamentos.vlAdcional = Convert.ToDecimal(Pagamentos.GetVlAdcional);
                Mensagem = "valido";
            }
            catch (Exception)
            {
                Mensagem = "Dados inválidos";
            }
        }

        //
        //ValidarConversão de Numeros
        public void ValidarInt(string Numero)
        {
            try
            {
                Convert.ToInt32(Numero);
                Mensagem = "valido";
            }
            catch (Exception)
            {

                Mensagem = "";
            }
        }
        //
        //ValidarConversão de Numeros Longos
        public void ValidarLong(string Numero)
        {
            try
            {
                Convert.ToInt64(Numero);
                Mensagem = "valido";
            }
            catch (Exception)
            {

                Mensagem = "";
            }

        }
        //

        //ValidarConversão de Numeros Longos
        public void ValidarDecimal(string Numero)
        {
            try
            {
                Convert.ToDecimal(Numero);
                Mensagem = "valido";
            }
            catch (Exception)
            {

                Mensagem = "";
            }

        }
        //
    }
}

