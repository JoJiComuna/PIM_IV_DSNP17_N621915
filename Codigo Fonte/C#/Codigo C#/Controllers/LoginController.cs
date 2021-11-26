
using System;
using Hotelaria.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Controls;


namespace Hotelaria.Controllers
{
    public class LoginController : Models.Login
    {
        #region Campos 
        private Connection Conn;
        public DataTable dataTable;
        public SqlDataAdapter dataAdapter;
        #endregion

        public override void Verificar ( string login , string senha )
        {
          
            Conn = new Connection ();

            try
            {
                Conn.sqlString = " SELECT User_Login, Senha from [dbo].[LoginUsuario] where User_Login = @Login and Senha =@Senha and Ds_Status = 1";
                Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
                Conn.Cmd.Parameters.AddWithValue ("Login" , login);
                Conn.Cmd.Parameters.AddWithValue ("Senha" , senha);
                Conn.Conn.Open ();
                dataTable = new DataTable ();
                dataAdapter = new SqlDataAdapter (Conn.Cmd);
                dataAdapter.Fill (dataTable);
                Conn.Cmd.ExecuteNonQuery ();
                if (dataTable.Rows.Count !=1)
                {
                    Mensagem = ("Login ou senha Incorreto");
                }
                else
                {
                    Mensagem = ("valido");

                }
            }

            catch (Exception)
            {
                Mensagem = ("Login ou senha Incorreto");
            }
            Conn.Conn.Close ();

        }
        public void VerificarLoginHospede(string login, string senha)
        {

            this.Conn = new Connection();

            try
            {
                Mensagem = ("");
                this.Conn.SqlString = new System.Text.StringBuilder();
                this.Conn.SqlString.Append("SELECT Ds_Login, Senha, ID_Hospede from [dbo].[LoginHospede] ");
                this.Conn.SqlString.Append("Where Ds_Login = @Login and Senha =@Senha and Ds_Status = 1 ");
                this.Conn.Cmd = new SqlCommand(Conn.SqlString.ToString(), Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("Login", login);
                this.Conn.Cmd.Parameters.AddWithValue("Senha", senha);
                this.Conn.Conn.Open();
                this.Conn.dataTable = new DataTable();
                this.Conn.dataAdapter = new SqlDataAdapter(Conn.Cmd);
                this.Conn.dataAdapter.Fill(this.Conn.dataTable);
                this.Conn.Cmd.ExecuteNonQuery();
                if (this.Conn.dataTable.Rows.Count != 1)
                {
                    Mensagem = ("Login ou senha Incorretos");
                }
                else
                {
                    Mensagem = ("");
                    using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                    {
                        while (this.Conn.dataReader.Read())
                        {
                            ID = Convert.ToInt32(this.Conn.dataReader[2]);

                        }
                        this.Conn.dataReader.Close();
                    }
                }
            }

            catch (Exception)
            {
                Mensagem = ("Login ou senha Incorretos");
            }
            finally 
            {
                
                this.Conn.Conn.Close();
            }
        }



        public void VerificarUsuario(string Usuario , string Email)
        {
            this.Conn = new Connection();
            this.Validar = new Validacao();

            try
            {
                #region sqlString
                this.Conn.SqlString = new System.Text.StringBuilder();
                this.Conn.SqlString.Append("SELECT User_Login, Email FROM LoginUsuario ");
                this.Conn.SqlString.Append("INNER JOin Usuario ");
                this.Conn.SqlString.Append("ON LoginUsuario.ID_Usuario = Usuario.ID_Usuario ");
                this.Conn.SqlString.Append("WHERE User_Login = @User or Email = @Email; ");
                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("User", Usuario);
                this.Conn.Cmd.Parameters.AddWithValue("Email", Email);
                this.Conn.Conn.Open();
                this.Conn.dataTable = new DataTable();
                this.Conn.dataAdapter = new SqlDataAdapter(this.Conn.Cmd);
                this.Conn.dataAdapter.Fill(this.Conn.dataTable) ;
                this.Conn.Cmd.ExecuteNonQuery();
                if (this.Conn.dataTable.Rows.Count != 1)
                {
                    Mensagem = ("Usuario/ Email não encontrados");
                }
                else
                {
                    Mensagem = "";

                }
            }

            catch (Exception e)
            {
                Mensagem = ("Usuario/ Email não encontrados");
         
            }
            this.Conn.Conn.Close();



        }

        public void AtualizarSenha(string Senha, string Usuario, string Email)
        {
            this.Conn = new Connection();
            try
            {
                Mensagem = "";
                this.Conn.SqlString = new System.Text.StringBuilder();
                this.Conn.SqlString.Append("UPDATE LoginUsuario SET Senha = @Senha  ");
                this.Conn.SqlString.Append("FROM LoginUsuario AS tb1 ");
                this.Conn.SqlString.Append("INNER JOIN Usuario AS tb2 ");
                this.Conn.SqlString.Append("ON tb1.ID_Usuario = tb2.ID_Usuario ");
                this.Conn.SqlString.Append("WHERE User_Login = @User or Email = @Email; ");
                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                //
                //Parametros
                this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                //
                this.Conn.Cmd.Parameters.AddWithValue("Senha", Senha);
                this.Conn.Cmd.Parameters.AddWithValue("User", Usuario);
                this.Conn.Cmd.Parameters.AddWithValue("Email", Email);
            
                this.Conn.ExecutarComParametros1();
            }
            catch (Exception )
            {
                Mensagem = "Erro ao Atualizar Senha";
            }

        }

        public void VerificarLoginHospede()
        {
            //verificar se o numero pode ser convertido
            this.Validar = new Validacao();
            this.Validar.ValidarCamposLoginHospede(this);
            switch (this.Validar.ValidarCamposLoginHospede(this))
            {
                case 0:

                    Mensagem = "";
                    break;

                case 1:
                    Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";
                    break;
            }
        }


    }
    }
