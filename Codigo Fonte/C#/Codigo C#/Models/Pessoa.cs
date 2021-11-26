using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public abstract class Pessoa : Propriedades
    {

        public string GetHospede { get; set; }
        public int ID { get; set; }
        public string Nome { get; set; }
        public Int64 Telefone { get; set; }
        public Int64 Documento { get; set; }
        public int DsStatus { get; set; }
        public string Email { get; set; }
        public string GetID { get; set; }
        public string GetDocumento { get; set; }
        public string GetTelefone { get; set; }


        
        
    }
}
