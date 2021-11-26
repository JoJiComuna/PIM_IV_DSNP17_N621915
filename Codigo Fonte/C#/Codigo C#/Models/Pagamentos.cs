using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria.Models
{
    public abstract class Pagamentos : Quartos
    {

    
        public decimal aReceber { get; set; }
        public decimal Pendente { get; set; }
        public decimal Pagos { get; set; }
        public int PagamentosCount { get; set; }
        public decimal totalaPagar { get; set; }
        public decimal totalPrDiaria { get; set; }
        public DateTime dtPagamento { get; set; }
        public string tipoPagamento { get; set; }
        public int NrPagamento { get; set; }

        public string GetPagamento { get; set; }
        public string GetVlAdcional { get; set; }

        public decimal vlAdcional { get; set; }







    }
    }