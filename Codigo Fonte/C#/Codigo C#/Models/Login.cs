using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public abstract class Login : Propriedades
    {
    public string Ds_Login { get; set; }
    public string Ds_Senha { get; set; }
    public string Ds_User { get; set; }
    public string Ds_Email { get; set; }
    public string TipoUsuario { get; set; }

   



        public virtual void Verificar (string login, string senha){}
    public virtual void Logar ( string login , string senha ) {}
   

    }
}
