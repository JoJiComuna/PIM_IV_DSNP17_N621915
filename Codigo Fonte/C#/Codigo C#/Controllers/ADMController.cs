using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelaria.Models;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotelaria.Controllers
{
    class ADMController : Propriedades
    {

        public void IncluirChave()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.NrChavedeSeguranca = Convert.ToInt32(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "INSERT INTO [dbo].[ChaveDeSeguranca] (Nr_ChavedeSeguranca, Ds_Status) " +
                    "VALUES (@NrChave, @Status)";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Parametros
                    this.Conn.Cmd.Parameters.AddWithValue("NrChave", NrChavedeSeguranca);
                    this.Conn.Cmd.Parameters.AddWithValue("Status", this.DsStatus);

                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Cadastrar Chave";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public void ConsultarChave()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[ChaveDeSeguranca]; ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao carregar Chaves de Segurança");
            }
        }

        public void VerificarChave()
        {
            this.Validar = new Validacao();
            this.Conn = new Connection();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.ID = Convert.ToInt32(this.GetNumber);
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = " SELECT Nr_ChavedeSeguranca FROM [dbo].[ChaveDeSeguranca] WHERE Nr_ChavedeSeguranca =@ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                    this.Conn.Conn.Open();
                    //using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                    //{
                    //    while (this.Conn.dataReader.Read())
                    //    {

                    //        this.NrChavedeSeguranca = Convert.ToInt32(this.Conn.dataReader[0].ToString());

                    //    }
                    //}
                    this.Conn.dataReader = this.Conn.Cmd.ExecuteReader();
                    if (!this.Conn.dataReader.HasRows)
                    {
                        Mensagem = "Chave inválida";
                    }
                    this.Conn.Conn.Close();
                    this.Conn.dataReader.Close();
                }
                catch (Exception)
                {
                    Mensagem = "Chave inválida";
                }
            }
        }

        public void AtualizarChave()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.NrChavedeSeguranca = Convert.ToInt32(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE ChaveDeSeguranca SET Nr_ChavedeSeguranca = @NrChave, Ds_Status = @Status " +
                        "Where ID_ChavedeSeguranca = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Parametros
                    this.Conn.Cmd.Parameters.AddWithValue("NrChave", NrChavedeSeguranca);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", ID );
                    this.Conn.Cmd.Parameters.AddWithValue("Status", this.DsStatus);

                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Cadastrar Chave";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public void ExcluirChave()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.ID= Convert.ToInt32(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE ChaveDeSeguranca SET Ds_Status = 0 " +
                    "Where ID_ChavedeSeguranca = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", ID );
                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Desativar Chave";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public void IncluirPatrimonio()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.NrQuarto = Convert.ToInt32(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "INSERT INTO ControledePatrimonio (Nm_Patrimonio, Nr_Quarto, Ds_Status) VALUES (@NmPatrimonio, @NrQuarto, @Status)";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Parametros
              
                    this.Conn.Cmd.Parameters.AddWithValue("NmPatrimonio", NmPatrimonio);
                    this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", NrQuarto);
                    this.Conn.Cmd.Parameters.AddWithValue("Status", this.DsStatus);
                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception e)
                {
                    Mensagem = $"Erro ao Cadastrar Patrimonio (Verifique o Nº do Quarto)";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public void ConsultarPatrimonio()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[ControledePatrimonio]; ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao carregar Chaves de Segurança");
            }
        }

        public void AtualizarPatrimonio()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.NrQuarto = Convert.ToInt32(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE ControledePatrimonio SET Nm_Patrimonio = @NmPatrimonio, Nr_Quarto = @NrQuarto, Ds_Status = @Status " +
                        "Where ID_Patrimonio = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Parametros
               
                    this.Conn.Cmd.Parameters.AddWithValue("ID", ID);
                    this.Conn.Cmd.Parameters.AddWithValue("NmPatrimonio", NmPatrimonio);
                    this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", NrQuarto);
                    this.Conn.Cmd.Parameters.AddWithValue("Status", this.DsStatus);

                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Aualizar Patrimônio";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public void ProcurarPatrimonio()
        {
            this.Validar = new Validacao();

                this.Conn = new Connection();
                this.Dgv = new DataGridView();
                this.Validar.ValidarInt(this.GetNumber);
                if (this.Validar.Mensagem == "valido")
                {
                    this.NrQuarto = Convert.ToInt32(GetNumber);
                }
                else
                {
                    this.NrQuarto = 0;
                }
              
                    try
                    {
                    this.NmPatrimonio = GetNumber;
                        #region sqlString
                        this.Conn.sqlString = "SELECT * FROM ControledePatrimonio WHERE Nm_Patrimonio like @NmPatrimonio or Nr_Quarto = @NrQuarto";
                        #endregion
                        this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                        this.Conn.Cmd.Parameters.AddWithValue("NmPatrimonio", string.Format("%{0}%", NmPatrimonio));
                        this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", NrQuarto);
                        this.Conn.ExecutarComParametros();
                        this.Dgv.DataSource = this.Conn.dataTable;
                    }
                    catch (Exception)
                    {
                        Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
                    }
                
            
        }

        public void ExcluirPatrimonio()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")
            {
                this.ID = Convert.ToInt32(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE ControledePatrimonio SET Ds_Status = 0 " +
                    "Where ID_Patrimonio = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", ID);
                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Desativar Chave";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }


    }
}
