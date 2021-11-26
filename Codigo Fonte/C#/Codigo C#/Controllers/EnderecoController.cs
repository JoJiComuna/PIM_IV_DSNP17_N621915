using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelaria.Models;
using System.Windows.Forms;

namespace Hotelaria.Controllers
{
    public class EnderecoController : Enderecos
    {
        private Validacao validar;
      
        
     
        public void VerificarEndereco ( )
        {

            //verificar se o numero pode ser convertido
            validar = new Validacao();
            validar.ValidarCamposEndereco (this);
            switch (validar.ValidarCamposEndereco (this))
            {
                case 0:
                validar.ConverterCamposEndereco (this);
                if (validar.Mensagem != "valido")
                {
                    MessageBox.Show (validar.Mensagem);
                }
                break;

                case 1:
                Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";
             
                break;

            }
        }

        public override void Consultar ( )
        {
            validar = new Validacao();
            validar.ValidarInt(this.GetIDHospede);
            if(validar.Mensagem=="valido")
            {
                this.IDHospede = Convert.ToInt32(this.GetIDHospede);
                base.Consultar ();
            }
            else
            {
                Mensagem = "Erro ao tentar Obter Endereço";
            }

            
        }
    }
}
