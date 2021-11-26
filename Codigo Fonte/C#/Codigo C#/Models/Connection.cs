using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace Hotelaria.Models
{
    public class Connection
    {

        static string constring = "Data Source= localhost\\SQLEXPRESS;Initial Catalog=Hotelaria;Integrated Security=True";
        public StringBuilder SqlString;
        public SqlConnection Conn;
        public SqlCommand Cmd;
        public string sqlString = "";
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;
        public DataTable dataTable;
        public DataSet dataSet;
        

        public Connection ( )
        {
            IniciarCampos ();
        }

        private void IniciarCampos ( )
        {
            Conn = new SqlConnection (constring);
            dataTable = new DataTable ();
            dataSet = new DataSet();
           
            dataAdapter = new SqlDataAdapter (Cmd);
        }

        public void Executar()
        {
            Conn.Open ();
            Cmd = new SqlCommand (sqlString ,Conn);
            ShowDgv();
            Cmd.ExecuteNonQuery ();
            Conn.Close ();
            Cmd.Dispose ();
        }


        public void ExecutarComParametros ( )
        {

            Conn.Open ();
            ShowDgv ();
            Cmd.ExecuteNonQuery ();
            Cmd.Dispose ();
            Conn.Close ();
       
        }
        public void ExecutarComParametros1 ( )
        {

            Conn.Open ();
            //ShowDgv ();
            Cmd.ExecuteNonQuery ();
            Cmd.Dispose ();
            Conn.Close ();

        }



        public void ShowDgv ( )
        {
            IniciarCampos();
            dataAdapter.Fill (dataTable);
        }
        public void ShowDgv1 ( )
        {
            IniciarCampos ();
            //dataAdapter.Fill (dataReader);
        }




    }
}
