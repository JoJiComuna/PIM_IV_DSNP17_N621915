
using System.Text;
using System.Windows.Forms;
using Hotelaria.Controllers;
/// <summary>
/// /Data Source=MATH-PC\SQLEXPRESS;Initial Catalog=BDHidraHotel;Integrated Security=True
/// </summary>
namespace Hotelaria.Models
{
    public abstract class Propriedades
    {


       public  StringBuilder Msql = new StringBuilder();
        public int HospedesCount { get; set; }
        public int HospedagensCount { get; set; }
        public int CheckinCount { get; set; }
        public int CheckoutCount { get; set; }
        public int CanceladosCount { get; set; }

        public int ReservasCount { get; set; }
        public int ID { get; set; }
        public int NrQuarto { get; set; }
        public int NrChavedeSeguranca { get; set; }
        public string NmPatrimonio { get; set; }
        public string GetPrQuarto { get; set; }
        public string NmHospede { get; set; }
        public string GetPrAdultos { get; set; }
        public string GetPrCriancas { get; set; }
        public string GetMaxAdultos { get; set; }
        public string GetMaxCriancas { get; set; }
        public string GetNumber { get; set; }
        public string GetNrHospedagem { get; set; }
        public string GetHospedagem { get; set; }

        //
        public string DsStatus { get; set; }
        public string Mensagem { get; protected set; }
        public string Resposta { get; protected set; }

        public QuartosController QrtController;
        public HospedagensController HpnController;
        public Enderecos Endereco;
        public DataGridView Dgv;
        public Connection Conn = new Connection();
        public Validacao Validar;

        public virtual void Incluir() { }
        public virtual void Consultar() { }
        public virtual void Procurar() { }
        public virtual void Atualizar() { }
        public virtual void Excluir() { }
    }
}
