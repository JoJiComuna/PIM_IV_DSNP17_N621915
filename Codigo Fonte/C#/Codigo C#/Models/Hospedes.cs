
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hotelaria.Controllers;

namespace Hotelaria.Models
{
    public abstract class Hospedes : Propriedades
    {
        #region Campos e Propriedades
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
        //Campos para Instanciar Endereços e Connection
      
        private Connection con;
        #endregion


        public virtual void Incluir ( ) { }
        public virtual void Consultar ( )
        {
       
        }
        public virtual void Procurar ( )
        {
            con = new Connection ();
            this.Dgv = new DataGridView ();
            try
            {
                //or Nr_Documento = @Documento
                #region sqlString
                //Conn.sqlString = "Select ID_Hospede, Nm_Hospede, Nr_Documento from [dbo].[Hospedes] where Nm_Hospede like @Nome ";
                //Conn.sqlString = "SELECT * FROM [dbo].[Hospedes] where Nr_Documento = @Documento or Nm_Hospede like @Nome ";
                con.sqlString = "SELECT Hospedes.ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone, " +
               "Email, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco FROM [dbo].[Hospedes] " +
               "Left JOIN [dbo].Endereco on Endereco.ID_Hospede = Hospedes.ID_Hospede " +
               "where Nr_Documento = @Documento or Nm_Hospede like @Nome and Ds_Status = 1";
                #endregion
                con.Cmd = new SqlCommand (con.sqlString , con.Conn);
                con.Cmd.Parameters.AddWithValue ("Nome" , string.Format ("%{0}%" , this.Nome));
                con.Cmd.Parameters.AddWithValue ("Documento" , this.Documento);

                con.ExecutarComParametros ();
                this.Dgv.DataSource = con.dataTable;
            }
            catch (SqlException)
            {
                Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
            }


        }
        public virtual void Excluir ( )
        {
            con = new Connection ();

            try
            {
                con.sqlString = "UPDATE [dbo].[Hospedes] set Ds_Status = 0 where ID_Hospede = @ID";
                con.Cmd = new SqlCommand (con.sqlString , con.Conn);
                con.Cmd.Parameters.AddWithValue ("ID" , this.ID);
                con.ExecutarComParametros ();
                MessageBox.Show ("Hospede Excluído com Sucesso!");
            }

            catch (Exception)
            {
                MessageBox.Show ("Não foi possivel realizar a operação tente novamente");
            }

        }
        public virtual void ConsultarCadastro()
        {
        con = new Connection();
            try
            {
                con.sqlString = "SELECT ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone, Email " +
                "FROM [dbo].[Hospedes] where Ds_Status = 1 and ID_Hospede = @ID; ";
                con.Cmd = new SqlCommand (con.sqlString , con.Conn);
                con.Cmd.Parameters.AddWithValue ("ID" , this.ID);
                con.Conn.Open ();
                using (con.dataReader = con.Cmd.ExecuteReader ())
                {
                    while (con.dataReader.Read ())
                    {
                        this.ID = int.Parse (con.dataReader [0].ToString ());
                        this.Nome = con.dataReader [1].ToString ();
                        this.Documento = Convert.ToInt64 (con.dataReader [2].ToString ());
                        this.Telefone = Convert.ToInt64 (con.dataReader [3].ToString ());
                        this.Email = con.dataReader [4].ToString ();
                    }
                }
                con.Conn.Close ();
                con.dataReader.Close ();
            }
            catch (Exception)
            {
                Mensagem = "";
            }
        }

        public virtual void Atualizar() { }
        public virtual void Ativar() { }

    }

}

