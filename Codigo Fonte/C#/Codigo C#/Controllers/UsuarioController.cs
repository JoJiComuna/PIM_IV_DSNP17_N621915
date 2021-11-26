using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelaria.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotelaria.Controllers
{
    public class UsuarioController : Pessoa
    {
     public  LoginController logController;

        public override void Incluir()
        {
            //Verificar e validar
          
            VerificarUsuario();
            //
            //Caso de certo
            if (this.Validar.Mensagem == "valido")
            {
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "INSERT INTO [dbo].[Usuario] (Nm_Usuario, Nr_Documento, Email, Ds_Status) " +
                    "VALUES (@Nome, @Documento, @Email, 1) " +
                    "INSERT INTO [dbo].[LoginUsuario] (ID_Usuario, Tipo_Usuario, User_Login, Senha, Ds_Status) " +
                    "Values (SCOPE_IDENTITY(),@TipoUsuario, @Login, @Senha, 1) ";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Parametros
                    this.Conn.Cmd.Parameters.AddWithValue("Nome", this.Nome);
                    this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);
                    this.Conn.Cmd.Parameters.AddWithValue("Email", this.Email);
                    //
                    this.Conn.Cmd.Parameters.AddWithValue("Login", this.logController.Ds_Login);
                    this.Conn.Cmd.Parameters.AddWithValue("Senha", this.logController.Ds_Senha);
                    this.Conn.Cmd.Parameters.AddWithValue("TipoUsuario", this.logController.TipoUsuario);
                    //
                    this.Conn.ExecutarComParametros1();

                }
                catch (Exception e)
                {
                    Mensagem = "Erro ao Realizar Cadastro";
                    Console.WriteLine(e.Message);
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public override void Procurar()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            this.Validar = new Validacao();


            this.Nome = this.GetHospede;
            //verificar se o numero pode ser convertido
            this.Validar.ValidarLong(this.GetHospede);
            if (this.Validar.Mensagem == "valido")
            {
                this.Documento = Convert.ToInt64(GetHospede);
            }
            else
            {
                this.Documento = 0;
            }
            try
            {
                #region sqlString
                this.Conn.sqlString = "SELECT * FROM Usuario WHERE Nr_Documento = @Documento or Nm_Usuario like @Nome";
                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("Nome", string.Format("%{0}%", this.Nome));
                this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);

                this.Conn.ExecutarComParametros();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
                Console.WriteLine(e.Message);
            }

        }

        public override void  Atualizar()
        {
            //Verificar e validar
            VerificarUsuario();
            //
            //Caso de certo
            if (this.Validar.Mensagem == "valido")
            {
                    this.Conn = new Connection();
                    try
                    {
                    Mensagem = "";
                        this.Conn.sqlString = "UPDATE Usuario SET Nm_Usuario = @Nome, Nr_Documento = @Documento, Email = @Email, " +
                        "Ds_Status = 1 WHERE ID_Usuario = @ID " +
                        "UPDATE LoginUsuario SET User_Login =@Login, Senha = @Senha , Tipo_Usuario = @TipoUsuario " +
                        "WHERE LoginUsuario.ID_Usuario = @ID";
                        this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                        //
                        //Parametros
                        this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                        this.Conn.Cmd.Parameters.AddWithValue("Nome", this.Nome);
                        this.Conn.Cmd.Parameters.AddWithValue("Documento", this.Documento);
                        this.Conn.Cmd.Parameters.AddWithValue("Email", this.Email);
                    //
                    //
                    this.Conn.Cmd.Parameters.AddWithValue("Login", this.logController.Ds_Login);
                    this.Conn.Cmd.Parameters.AddWithValue("Senha", this.logController.Ds_Senha);
                    this.Conn.Cmd.Parameters.AddWithValue("TipoUsuario", this.logController.TipoUsuario);
               
                    this.Conn.ExecutarComParametros1();  
                    }
                    catch (Exception e)
                    {
                        Mensagem = "Erro ao Atualizar Cadastro";
                    Console.WriteLine(e.Message);

                    }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public override void Consultar()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[Usuario] ; ";
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
            this.Conn = new Connection();
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetID);
            if (this.Validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.ID = int.Parse(this.GetID);
                try
                {
                    this.Conn.sqlString = "UPDATE [dbo].[Usuario] SET Ds_Status = 0 where ID_Usuario = @ID";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                    this.Conn.ExecutarComParametros();
                    MessageBox.Show("Usuario Desativado com Sucesso!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel realizar a operação tente novamente");
                }
            }
        }

        public void VerificarUsuario()
        {
            this.Validar = new Validacao();
            //verificar se o numero pode ser convertido
            this.Validar.ValidarCamposUsuario(this, logController);
            switch (this.Validar.ValidarCamposUsuario(this, logController))
            {
                case 0:
                    this.Validar.ConverterCamposUsuario(this);
                    if (this.Validar.Mensagem != "valido")
                    {
                        MessageBox.Show(this.Validar.Mensagem);
                    }
                    break;

                case 1:
                    Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";
                    MessageBox.Show(Mensagem);
                    break;
            }
        }

        public void ConsultarDadosLogin()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            this.Validar = new Validacao();
            logController = new LoginController();

          
            //verificar se o numero pode ser convertido
            this.Validar.ValidarInt(this.GetID);
            if (this.Validar.Mensagem == "valido")
            {
                this.ID = Convert.ToInt32(GetID);
            }
            else
            {
                this.ID = 0;
            }
            try
            {
                #region sqlString
                this.Conn.sqlString = "SELECT * FROM Usuario " +
                    "INNER JOIN LoginUsuario " +
                    "ON LoginUsuario.ID_Usuario = Usuario.ID_Usuario " +
                    "WHERE Usuario.ID_Usuario = @ID";
                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                this.Conn.Conn.Open();
                using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                {
                    while (this.Conn.dataReader.Read())
                    {
                        this.ID = int.Parse(this.Conn.dataReader[0].ToString());
                        logController.Ds_Login = this.Conn.dataReader[7].ToString();
                        logController.Ds_Senha = this.Conn.dataReader[8].ToString();
                        logController.TipoUsuario = this.Conn.dataReader[9].ToString();
                    }
                }

            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.Conn.Conn.Close();
                this.Conn.Cmd.Dispose();
                this.Conn.dataReader.Close();
            }
        }
    }
}
