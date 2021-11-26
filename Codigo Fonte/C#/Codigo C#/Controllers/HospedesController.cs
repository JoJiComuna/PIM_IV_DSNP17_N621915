
using System;
using Hotelaria.Models;

using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Hotelaria.Controllers
{
    //[ApiController]
    //[Route("Hospedes/[controller]")]
    public class Hospedescontroller : Pessoa
    {
        private Validacao validar;
        public EnderecoController endrController;
        public LoginController loginController;

        public override void Procurar()
        {
            this.Validar = new Validacao();
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            this.Nome = this.GetHospede;
            //verificar se o numero pode ser convertido
            this.Validar.ValidarLong(this.GetHospede);
            if (this.Validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.Documento = Convert.ToInt64(this.GetHospede);
            }
            else
            {//nao (recebe 0)
                this.Documento = 0;
            }
            try
            {
                Mensagem = "";
                #region sqlString
                this.Conn.sqlString = "SELECT Hospedes.ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone, " +
               "Email, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco FROM [dbo].[Hospedes] " +
               "Left JOIN [dbo].Endereco on Endereco.ID_Hospede = Hospedes.ID_Hospede " +
               "where Nr_Documento = @Documento or Nm_Hospede like @Nome and Ds_Status = 1";
                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("Nome", string.Format("%{0}%", this.Nome));
                this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);
                this.Conn.ExecutarComParametros();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (SqlException)
            {
                Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
            }
        }

        public override void Incluir()
        {
            this.Validar = new Validacao();
            VerificarHospede();
            endrController.VerificarEndereco();
            //caso passe pela validação confirmar com usuario antes de cadastrar
            //validar msg confirmar
            if (this.Validar.Mensagem == "valido")
            {
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "INSERT INTO [dbo].[Hospedes] (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status) " +
                    "VALUES (@Nome, @Documento, @Telefone,@Email, 1)" +
                    "INSERT INTO [dbo].Endereco (ID_Hospede, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco) " +
                    "Values (SCOPE_IDENTITY(), @Estado , @Cidade, @Bairro, @Rua, @NrEndereco )";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //Hospede
                    this.Conn.Cmd.Parameters.AddWithValue("Nome", this.Nome);
                    this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);
                    this.Conn.Cmd.Parameters.AddWithValue("Telefone", this.Telefone);
                    this.Conn.Cmd.Parameters.AddWithValue("Email", this.Email);
                    //Endereço
                    this.Conn.Cmd.Parameters.AddWithValue("Estado", endrController.Estado);
                    this.Conn.Cmd.Parameters.AddWithValue("Cidade", endrController.Cidade);
                    this.Conn.Cmd.Parameters.AddWithValue("Bairro", endrController.Bairro);
                    this.Conn.Cmd.Parameters.AddWithValue("Rua", endrController.Rua);
                    this.Conn.Cmd.Parameters.AddWithValue("NrEndereco", endrController.NrEndereco);
                    this.Conn.ExecutarComParametros1();
                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Realizar Cadastro";
                }



            }

        }
        public void IncluirComLogin()
        {

            this.Validar = new Validacao();
            VerificarHospede();
            endrController.VerificarEndereco();

            //caso passe pela validação confirmar com usuario antes de cadastrar
            //validar msg confirmar
            if (this.Validar.Mensagem == "valido")
            {
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.SqlString = new System.Text.StringBuilder();
                    this.Conn.SqlString.Append("INSERT INTO [dbo].[Hospedes] (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status) ");
                    this.Conn.SqlString.Append("VALUES (@Nome, @Documento, @Telefone,@Email, 1) ");
                    this.Conn.SqlString.Append("INSERT INTO [dbo].Endereco (ID_Hospede, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco) ");
                    this.Conn.SqlString.Append("VALUES (SCOPE_IDENTITY(), @Estado , @Cidade, @Bairro, @Rua, @NrEndereco ) ");
                    this.Conn.SqlString.Append("INSERT INTO LoginHospede (ID_Hospede, Ds_Login, Senha, Ds_Status) ");
                    this.Conn.SqlString.Append("VALUES (SCOPE_IDENTITY(), @Login, @Senha, 1) ");

                    this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                    //Hospede
                    this.Conn.Cmd.Parameters.AddWithValue("Nome", this.Nome);
                    this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);
                    this.Conn.Cmd.Parameters.AddWithValue("Telefone", this.Telefone);
                    this.Conn.Cmd.Parameters.AddWithValue("Email", this.Email);
                    //Endereço
                    this.Conn.Cmd.Parameters.AddWithValue("Estado", endrController.Estado);
                    this.Conn.Cmd.Parameters.AddWithValue("Cidade", endrController.Cidade);
                    this.Conn.Cmd.Parameters.AddWithValue("Bairro", endrController.Bairro);
                    this.Conn.Cmd.Parameters.AddWithValue("Rua", endrController.Rua);
                    this.Conn.Cmd.Parameters.AddWithValue("NrEndereco", endrController.NrEndereco);
                    //Login
                    this.Conn.Cmd.Parameters.AddWithValue("Login", loginController.Ds_Login);
                    this.Conn.Cmd.Parameters.AddWithValue("Senha", loginController.Ds_Senha);
                    this.Conn.ExecutarComParametros1();
                }
                catch (Exception e)
                {
                    Mensagem = "Erro ao Realizar Cadastro " + e.Message;

                }


            }

        }

        public override void Consultar()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[Hospedes] where Ds_Status = 1; ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao carregar hóspedes");
            }
        }

        public override void Atualizar()
        {
            //Verificar e validar
            VerificarHospede();
            endrController.VerificarEndereco();
            //
            //Caso de certo
            if (this.Validar.Mensagem == "valido")
            {
                this.Conn = new Connection();
                try
                {

                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE Hospedes SET Nm_Hospede = @Nome, Nr_Documento = @Documento, Nr_Telefone = @Telefone, Email = @Email " +
                    "WHERE ID_Hospede = @ID " +
                    "UPDATE Endereco SET Ds_Estado = @Estado, Nm_Cidade = @Cidade, Nm_Bairro = @Bairro, Nm_Rua = @Rua, Nr_Endereco =@NrEndereco " +
                    "Where Endereco.ID_Hospede = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Hospede
                    this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                    this.Conn.Cmd.Parameters.AddWithValue("Nome", this.Nome);
                    this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);
                    this.Conn.Cmd.Parameters.AddWithValue("Telefone", this.Telefone);
                    this.Conn.Cmd.Parameters.AddWithValue("Email", this.Email);
                    //Endereço
                    this.Conn.Cmd.Parameters.AddWithValue("Estado", endrController.Estado);
                    this.Conn.Cmd.Parameters.AddWithValue("Cidade", endrController.Cidade);
                    this.Conn.Cmd.Parameters.AddWithValue("Bairro", endrController.Bairro);
                    this.Conn.Cmd.Parameters.AddWithValue("Rua", endrController.Rua);
                    this.Conn.Cmd.Parameters.AddWithValue("NrEndereco", endrController.NrEndereco);
                    //
                    this.Conn.ExecutarComParametros1();
                }
                catch (Exception)
                {
                    Mensagem = "Erro ao Atualizar Cadastro";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }
        public void VerificarEmail(string Email)   
        {
            
                this.Conn = new Connection();

                try
                {
                    Mensagem = ("");
                    this.Conn.SqlString = new System.Text.StringBuilder();
                    this.Conn.SqlString.Append("SELECT Email,ID_Hospede from [dbo].[Hospedes] ");
                    this.Conn.SqlString.Append("Where Email =@Email");
                    this.Conn.Cmd = new SqlCommand(Conn.SqlString.ToString(), Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("Email", Email);
                
                    this.Conn.Conn.Open();
                    this.Conn.dataTable = new DataTable();
                    this.Conn.dataAdapter = new SqlDataAdapter(Conn.Cmd);
                    this.Conn.dataAdapter.Fill(this.Conn.dataTable);
                    this.Conn.Cmd.ExecuteNonQuery();
                if (this.Conn.dataTable.Rows.Count != 1)
                {
                    Mensagem = ("Cadastro não encontrado");
                }
                else
                {
                    using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                    {
                        while (this.Conn.dataReader.Read())
                        {
                            ID = Convert.ToInt32(this.Conn.dataReader[1]);

                        }
                        this.Conn.dataReader.Close();
                    }
                }

                }

                catch (Exception)
                {
                Mensagem = ("Cadastro não encontrado");
            }
                finally
                {

                    this.Conn.Conn.Close();
                
            }
        }
        public  void AtualizarSenha()
        {
          
     
   
                this.Conn = new Connection();
                try
                {

                 Mensagem = "";
                this.Conn.SqlString = new System.Text.StringBuilder();
                this.Conn.SqlString.Append("UPDATE LoginHospede SET Senha = @Senha ");
                this.Conn.SqlString.Append("WHERE ID_Hospede = @ID; ");

                    this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                    //
                    //Hospede
                    this.Conn.Cmd.Parameters.AddWithValue("Senha", loginController.Ds_Senha.ToString());
                    this.Conn.Cmd.Parameters.AddWithValue("ID", ID);
      
                    //
                    this.Conn.ExecutarComParametros1();
                }
                catch (Exception e)
                {
                    Mensagem = "Erro ao Atualizar Senha "+ e.Message ;
                }
        
            //Caso não  a verificação retorna um erro e continua
        }

        public void ConsultarInativos()
        {

            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[Hospedes] where Ds_Status = 0; ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao carregar hóspedes");
            }

        }

        public override void Excluir()
        {
            validar = new Validacao();
            this.Conn = new Connection();
            //verificar se o numero pode ser convertido
            validar.ValidarInt(this.GetID);


            if (validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.ID = int.Parse(this.GetID);
                VerificarPendenciaHospedagem();
                VerificarPendenciaPagamentos();
                if (this.Mensagem == "")
                {
                    try
                    {
                        Mensagem = "";
                        this.Conn.sqlString = "UPDATE [dbo].[Hospedes] SET Ds_Status = 0 where ID_Hospede = @ID";
                        this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                        this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                        this.Conn.ExecutarComParametros1();

                    }
                    catch (Exception)
                    {
                        Mensagem = ("Não foi possivel realizar a operação tente novamente");

                    }
                }

            }
            else
            {//nao (recebe 0)
                this.ID = 0;
                Mensagem = "Algo deu errado tente novamente!";
            }
            this.Conn.Conn.Close();
        }

        public void VerificarHospede()
        {
            //verificar se o numero pode ser convertido
            this.Validar = new Validacao();
            this.Validar.ValidarCamposHospede(this);
            switch (this.Validar.ValidarCamposHospede(this))
            {
                case 0:
                    this.Validar.ConverterCamposHospede(this);
                    if (this.Validar.Mensagem != "valido")
                    {
                        Mensagem = (this.Validar.Mensagem);
                    }
                    break;

                case 1:
                    Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";

                    break;
            }
        }


        public void ConsultarCadastro()
        {
            validar = new Validacao();
            this.Conn = new Connection();
            validar.ValidarInt(this.GetID);
            if (validar.Mensagem == "valido")
            {
                this.ID = Convert.ToInt32(this.GetID);
                try
                {
                    this.Conn.sqlString = "SELECT ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone, Email " +
                    "FROM [dbo].[Hospedes] where Ds_Status = 1 and ID_Hospede = @ID; ";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                    this.Conn.Conn.Open();
                    using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                    {
                        while (this.Conn.dataReader.Read())
                        {
                            this.ID = int.Parse(this.Conn.dataReader[0].ToString());
                            this.Nome = this.Conn.dataReader[1].ToString();
                            this.Documento = Convert.ToInt64(this.Conn.dataReader[2].ToString());
                            this.Telefone = Convert.ToInt64(this.Conn.dataReader[3].ToString());
                            this.Email = this.Conn.dataReader[4].ToString();
                        }
                    }
                    this.Conn.Conn.Close();
                    this.Conn.dataReader.Close();
                }
                catch (Exception)
                {
                    Mensagem = "";
                }
            }
            else
            {
                Mensagem = "Não foi possivel Consultar o cadastro";
            }

        }
        public void ConsultarCadastroLogin()
        {
            this.endrController = new EnderecoController();
            this.loginController = new LoginController();
            validar = new Validacao();
            this.Conn = new Connection();
            validar.ValidarInt(this.GetID);
            if (validar.Mensagem == "valido")
            {
                this.ID = Convert.ToInt32(this.GetID);
                try
                {
                    Mensagem = "";
                    this.Conn.SqlString = new System.Text.StringBuilder();
                    this.Conn.SqlString.Append("SELECT Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Estado, Nm_Cidade, Nm_Bairro, ");
                    this.Conn.SqlString.Append("Nm_Rua, Nr_Endereco, Ds_Login, Senha  FROM Hospedes ");
                    this.Conn.SqlString.Append("INNER JOIN Endereco ");
                    this.Conn.SqlString.Append("ON Endereco.ID_Hospede = Hospedes.ID_Hospede ");
                    this.Conn.SqlString.Append("INNER JOIN LoginHospede ");
                    this.Conn.SqlString.Append("ON LoginHospede.ID_Hospede = Hospedes.ID_Hospede ");
                    this.Conn.SqlString.Append("WHERE Hospedes.ID_Hospede = @ID; ");

                    this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                    this.Conn.Conn.Open();
                    using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                    {
                        while (this.Conn.dataReader.Read())
                        {
                            this.NmHospede = this.Conn.dataReader[0].ToString();
                            this.Documento = Convert.ToInt64(this.Conn.dataReader[1].ToString());
                            this.Telefone = Convert.ToInt64(this.Conn.dataReader[2].ToString());
                            this.Email = this.Conn.dataReader[3].ToString();
                            //endereço
                            this.endrController.Estado = this.Conn.dataReader[4].ToString();
                            this.endrController.Cidade = this.Conn.dataReader[5].ToString();
                            this.endrController.Bairro = this.Conn.dataReader[6].ToString();
                            this.endrController.Rua = this.Conn.dataReader[7].ToString();
                            this.endrController.NrEndereco = Convert.ToInt32(this.Conn.dataReader[8].ToString());
                            //login
                            this.loginController.Ds_Login = this.Conn.dataReader[9].ToString();
                            this.loginController.Ds_Senha = this.Conn.dataReader[10].ToString();
                        }
                    }
                    this.Conn.Conn.Close();
                    this.Conn.dataReader.Close();
                }
                catch (Exception)
                {
                    Mensagem = "";
                }
            }
            else
            {
                Mensagem = "Não foi possivel Consultar o cadastro";
            }

        }

        public void Ativar()
        {

            validar = new Validacao();
            this.Conn = new Connection();
            //verificar se o numero pode ser convertido
            validar.ValidarInt(this.GetID);
            if (validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.ID = int.Parse(this.GetID);
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE [dbo].[Hospedes] SET Ds_Status = 1 where ID_Hospede = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception)
                {
                    Mensagem = ("Não foi possivel realizar a operação tente novamente");

                }
            }
            else
            {//nao (recebe 0)
                this.ID = 0;
                Mensagem = "Algo deu errado tente novamente!";
            }
            this.Conn.Conn.Close();

        }

        public void VerificarPendenciaHospedagem()
        {
            this.Conn = new Connection();

            try
            {
                this.Conn.SqlString = new System.Text.StringBuilder();
                Mensagem = "";
                this.Conn.SqlString.Append("SELECT * FROM Hospedagens  ");
                this.Conn.SqlString.Append(" WHERE ID_Hospede = @ID and Ds_Status = 'Check-In' or Ds_Status = 'Reserva'; ");
                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);

                this.Conn.Conn.Open();
                this.Conn.dataTable = new DataTable();
                this.Conn.dataAdapter = new SqlDataAdapter(this.Conn.Cmd);
                this.Conn.dataAdapter.Fill(this.Conn.dataTable);
                this.Conn.Cmd.ExecuteNonQuery();
                if (this.Conn.dataTable.Rows.Count != 1)
                {
                    Mensagem = ("");
                }
                else
                {

                    Mensagem = ("O hóspede não pode ser desativado pois está com uma ou mais pendências");

                }
            }

            catch (Exception)
            {
                Mensagem = "Erro ao Verificar Pendencia";
            }
            this.Conn.Conn.Close();

        }
        public void VerificarPendenciaPagamentos()
        {
            this.Conn = new Connection();

            try
            {
                this.Conn.SqlString = new System.Text.StringBuilder();
                Mensagem = "";
                this.Conn.SqlString.Append("SELECT Pagamentos.Ds_Status FROM Pagamentos  ");
                this.Conn.SqlString.Append("INNER JOIN Hospedagens  ");
                this.Conn.SqlString.Append("ON Hospedagens.Nr_Hospedagem = Pagamentos.Nr_Hospedagem ");
                this.Conn.SqlString.Append("WHERE Hospedagens.ID_Hospede = @ID;");
                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);

                this.Conn.Conn.Open();
                this.Conn.dataTable = new DataTable();
                this.Conn.dataAdapter = new SqlDataAdapter(this.Conn.Cmd);
                this.Conn.dataAdapter.Fill(this.Conn.dataTable);
                this.Conn.Cmd.ExecuteNonQuery();
                if (this.Conn.dataTable.Rows.Count != 1)
                {
                    Mensagem = ("");
                }
                else
                {

                    Mensagem = ("O hóspede não pode ser desativado pois está com uma ou mais pendências");

                }
            }

            catch (Exception)
            {
                Mensagem = "Erro ao Verificar Pendencia";
            }
            this.Conn.Conn.Close();

        }


    }
}


