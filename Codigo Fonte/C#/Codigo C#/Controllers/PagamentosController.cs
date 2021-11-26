
using System;
using Hotelaria.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Hotelaria.Controllers
{
    public class PagamentosController : Pagamentos
    {
        public override void Consultar()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[Pagamentos]; ";
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
            VerificarPagamento();
            //
            //Caso de certo
            if (this.Validar.Mensagem == "valido")
            {
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE Pagamentos SET Dt_Pagamento =@Data, Vl_TotalaPagar =@Total, " +
                    "Tipo_Pagamento = @TipoPagamento, Ds_Status = @Status " +
                    "Where Nr_Pagamento = @NrPagamento";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    //
                    //Parametros
                    this.Conn.Cmd.Parameters.AddWithValue("NrPagamento", NrPagamento);
                    this.Conn.Cmd.Parameters.AddWithValue("Total", totalaPagar);
                    this.Conn.Cmd.Parameters.AddWithValue("TipoPagamento", tipoPagamento);
                    this.Conn.Cmd.Parameters.AddWithValue("Data", dtPagamento);
                    this.Conn.Cmd.Parameters.AddWithValue("Status", this.DsStatus);
                    //
                    this.Conn.ExecutarComParametros1();
                }
                catch (Exception e)
                {
                    Mensagem = "Erro ao Atualizar Cadastro";
                    Console.WriteLine(e.Message);

                }
            }
        }

        public override void Excluir()
        {
            this.Conn = new Connection();
            this.Validar = new Validacao();
            this.Validar.ValidarInt(this.GetNumber);
            if (this.Validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.NrPagamento = int.Parse(this.GetNumber);
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE Pagamentos SET Ds_Status = 'Cancelado' Where Nr_Pagamento = @NrPagamento";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("NrPagamento", this.NrPagamento);
                    this.Conn.ExecutarComParametros();
                  
                }
                catch (Exception)
                {
                    Mensagem =("Não foi possivel realizar a operação tente novamente");
                }
            }
        }

        public override void Procurar()
        {
            this.Validar = new Validacao();
        
            //verificar se o numero pode ser convertido
            this.Validar.ValidarInt(this.GetPagamento);
            if (this.Validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.NrPagamento = int.Parse(this.GetPagamento);
            }
            else
            {//nao (recebe 0)
                this.NrPagamento = 0;
            }

            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                #region sqlString
                this.Conn.sqlString = "SELECT * FROM Pagamentos WHERE Nr_Pagamento = @nrPagamento";
                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
             
                this.Conn.Cmd.Parameters.AddWithValue("nrPagamento", this.NrPagamento);
                this.Conn.ExecutarComParametros();

                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception e)
            {
                Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
                Console.WriteLine(e.Message);
            }
        }

        public void VerificarPagamento()
            {
                this.Validar = new Validacao();
                this.Validar.ConverterCamposPagamentos(this);
            }

        public void ContarRegistros()
        {
            try
            {
                this.Conn = new Connection();
                //Nomear Selects
                this.Msql.Append("SELECT Pagamentos, Pendentes, Pagos ");
                this.Msql.Append("FROM (SELECT COUNT(*) as Pagamentos FROM Pagamentos ");
                this.Msql.Append("WHERE Pagamentos.Ds_Status != 'Cancelado' ) a ");
                this.Msql.Append("CROSS JOIN (SELECT Sum (Vl_TotalaPagar) as Pendentes FROM Pagamentos ");
                this.Msql.Append("WHERE Pagamentos.Ds_Status = 'Pendente') b ");
                this.Msql.Append("CROSS JOIN (SELECT Sum (Vl_TotalaPagar) as Pagos FROM Pagamentos ");
                this.Msql.Append("WHERE Pagamentos.Ds_Status = 'Pago') c ");
                //Selecionar Checkins
           
                this.Conn.sqlString = Msql.ToString();
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Conn.Open();
                using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                {
                    while (this.Conn.dataReader.Read())
                    {
                        PagamentosCount = Convert.ToInt32( this.Conn.dataReader[0].ToString());
                        Pendente = Convert.ToDecimal(this.Conn.dataReader[1].ToString());
                        Pagos = Convert.ToDecimal(this.Conn.dataReader[2].ToString());

                    }
                }
            }
            catch (Exception e)
            {
                Mensagem = "";

            }
            finally
            {
                this.Conn.Conn.Close();
                this.Conn.dataReader.Close();
           
            }
        }

        }
    } 