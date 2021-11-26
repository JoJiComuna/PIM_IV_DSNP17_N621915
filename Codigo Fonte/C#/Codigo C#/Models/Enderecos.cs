using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotelaria.Models
{

    public class Enderecos : Propriedades
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string GetNrEndereco { get; set; }
        public string GetIDHospede{ get; set; }
        public int NrEndereco { get; set; }
        public int IDHospede { get; set; }

        public Enderecos ( ) { }

        public Enderecos ( string Estado , string Cidade , string Bairro , string Rua , int NrEndereco )
        {
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.Bairro = Bairro;
            this.Rua = Rua;
            this.NrEndereco = NrEndereco;
        }
        protected Connection con;

        public virtual void Consultar ( )
        {
            try
            {
                con = new Connection ();
                con.sqlString = "SELECT * FROM Endereco WHERE ID_Hospede = @ID; ";
                con.Cmd = new SqlCommand (con.sqlString , con.Conn);
                con.Cmd.Parameters.AddWithValue ("ID" , this.IDHospede);
                con.Conn.Open ();
                using (con.dataReader = con.Cmd.ExecuteReader ())
                {
                    while (con.dataReader.Read ())
                    {
                        this.Estado = con.dataReader [2].ToString ();
                        this.Cidade = con.dataReader [3].ToString ();
                        this.Bairro = con.dataReader [4].ToString ();
                        this.Rua = con.dataReader [5].ToString ();
                        this.Mensagem = this.Rua;
                        this.NrEndereco = int.Parse (con.dataReader [6].ToString ());
                    }
                }
                con.Conn.Close ();
                con.dataReader.Close ();
            }
            catch (Exception)
            {
                Mensagem ="";
            }
        }
    }
}



