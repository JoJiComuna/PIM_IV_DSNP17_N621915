using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotelaria.Models
{
    public abstract class Quartos : Propriedades
    {
        //Propriedades
        #region Declaração de Propriedades
        public int NrQuarto { get; set; }
        public int NrHospedagem { get; set; }

        public int IDTipoQuarto { get; set; }

        public int ID{ get; set; }

        public string NmQuarto { get; set; }

        public string NmTipoQuarto { get; set; }


        public int QtdAdultos { get; set; }
        public int QtdCriancas { get; set; }


        public int MaxAdultos { get; set; }

        public int MaxCriancas { get; set; }

        public decimal PrQuarto { get; set; }
        public decimal PrTotalaPagar { get; set; }

        public decimal PrExtraAdultos { get; set; }

        public decimal PrExtraCriancas { get; set; }


        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public double QtdDiaria { get; set; }
        public decimal TotalAdultos { get; set; }
        public decimal TotalCriancas { get; set; }
        public decimal TotalDiarias { get; set; }



        public string DsStatus { get; set; }
        public string DsInfo { get; set; }

        #endregion

        public ComboBox CboxTipoQuarto;
        public ComboBox CboxNmQuarto;

        public void ObterTipoQuarto()
        {
            this.Conn = new Connection();
           
            try
            {
                this.Conn.sqlString = "SELECT  Nm_TipoQuarto FROM Quartos INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto " +
                "GROUP BY Quartos.ID_TipoQuarto, Nm_TipoQuarto";
                this.Conn.Executar();
            }
            catch (Exception)
            {
                this.Conn.dataTable = null;
            }
        }

        public virtual void ObterInfoQuarto()
        {
            this.Conn = new Connection();
            try
            {
          
                this.Conn.sqlString = "SELECT Quartos.Nr_Quarto,Quartos.Nm_Quarto, Max_Adultos, Max_Criancas, " +
                "Pr_ExtraAdulto, Pr_ExtraCrianca,Pr_Quarto, Ds_Info FROM [dbo].[Quartos] " +
                "INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto " +
                "WHERE Quartos.Ds_Status !=0 and  Nm_TipoQuarto = @NmTipoQuarto or Nr_Quarto =@NrQuarto ";
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("NmTipoQuarto", NmQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", NrQuarto);
                this.Conn.ExecutarComParametros();

                using (SqlDataReader rdr = this.Conn.Cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        MaxAdultos = Convert.ToInt32(rdr[2]);
                        MaxCriancas = Convert.ToInt32(rdr[3]);
                        PrExtraAdultos = Convert.ToDecimal(rdr[4]);
                        PrExtraCriancas = Convert.ToDecimal(rdr[5]);
                        PrQuarto = Convert.ToDecimal(rdr[6]);
                        DsInfo = rdr[7].ToString();
                    }
                }
            }
            catch
            {
                NmQuarto = "";
            }
        }

        public void GetTipoQuarto()
        {
            this.Conn = new Connection();
            try
            {
                Mensagem = "";
                this.Conn.sqlString = "SELECT ID_TipoQuarto FROM TipoQuarto WHERE Nm_TipoQuarto = @NmTipoQuarto;";
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("NmTipoQuarto", NmTipoQuarto);

                this.Conn.ExecutarComParametros();

                using (SqlDataReader rdr = this.Conn.Cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        IDTipoQuarto = Convert.ToInt32(rdr[0]);
                    }
                }
            }
            catch
            {
                NmQuarto = "";
            }
        }

        public void ConsultarQuartos()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[Quartos]; ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao carregar hóspedes");
            }
        }

        public void ConsultarTipoQuarto()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                this.Conn.sqlString = "SELECT * FROM [dbo].[TipoQuarto]; ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao carregar hóspedes");
            }
        }

        public virtual void IncluirQuarto()
        {
            try
            {
                this.Mensagem = "";
                this.Conn.sqlString = "INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Info,Ds_Status) " +
                 "VALUES (@IDTipoQuarto ,@NmQuarto, @DsQuarto, @Status);";

                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("IDTipoQuarto", IDTipoQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("NmQuarto", NmQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("Status", DsStatus);
                this.Conn.Cmd.Parameters.AddWithValue("DsQuarto", DsInfo);
                this.Conn.ExecutarComParametros1();

            }
            catch (Exception)
            {
                Mensagem = "Erro ao Realizar Cadastro";
            }
        }

        public virtual void AtualizarQuarto()
        {
            try
            {
                this.Mensagem = "";
                this.Conn.sqlString = "UPDATE Quartos SET ID_TipoQuarto = @IDTipoQuarto, Nm_Quarto = @NmQuarto,Ds_Info =@DsQuarto, Ds_Status = @Status " +
                    "WHERE Nr_Quarto = @NrQuarto;";

                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("IDTipoQuarto", IDTipoQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("NmQuarto", NmQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("Status", DsStatus);
                this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", NrQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("DsQuarto", DsInfo);
                this.Conn.ExecutarComParametros1();
            }
            catch (Exception)
            {
                Mensagem = "Erro ao Realizar Cadastro";
            }
        }

        public virtual void ExcluirQuarto()
        {
            this.Conn = new Connection();
            try
            {
                this.Conn.sqlString = "UPDATE [dbo].[Quartos] set Ds_Status = @DsStatus where Nr_Quarto = @NrQuarto";
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", NrQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("DsStatus", DsStatus);
                this.Conn.ExecutarComParametros();
                MessageBox.Show("Quarto Desativado");
            }

            catch (Exception e)
            {
                MessageBox.Show("Não foi possivel realizar a operação tente novamente");
                MessageBox.Show(e.Message);
            }


        }


     

        public virtual void IncluirTipoQuarto()
        {
            try
            {
                this.Mensagem = "";
                this.Conn.sqlString = "INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Status) VALUES";

                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("IDTipoQuarto", IDTipoQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("NmQuarto", NmQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("Status", DsStatus);
                this.Conn.ExecutarComParametros1();
                Mensagem = "Cadastro concluído com exito";
            }
            catch (Exception)
            {
                Mensagem = "Erro ao Realizar Cadastro";
            }
        }

        public virtual void AtualizarTipoQuarto()
        {
            this.Conn = new Connection();
            try
            {
                this.Mensagem = "";
                this.Conn.sqlString = "UPDATE TipoQuarto SET Nm_TipoQuarto = @NmTipoQuarto, Max_Adultos = @MaxAdultos, Max_Criancas = @MaxCriancas, " +
                    "Pr_Quarto = @PrQuarto, Pr_ExtraAdulto = @PrAdulto, Pr_ExtraCrianca = @PrCrianca, Ds_Status = @Status " +
                    "WHERE ID_TipoQUarto = @IDTipoQuarto " +
                    "UPDATE Quartos SET Ds_Status = @status " +
                    "WHERE Ds_Status  = '0' " +
                    "AND ID_TipoQuarto IN (select ID_TipoQuarto from TipoQuarto where Ds_Status = @Status);";

                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("IDTipoQuarto", IDTipoQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("NmTipoQuarto", NmTipoQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("MaxAdultos", MaxAdultos);
                this.Conn.Cmd.Parameters.AddWithValue("MaxCriancas", MaxCriancas);
                this.Conn.Cmd.Parameters.AddWithValue("PrQuarto", PrQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("PrAdulto", PrExtraAdultos);
                this.Conn.Cmd.Parameters.AddWithValue("PrCrianca", PrExtraCriancas);
                this.Conn.Cmd.Parameters.AddWithValue("Status", DsStatus);
                this.Conn.ExecutarComParametros1();
            }
            catch (Exception e)
            {
                Mensagem = "Erro ao tentar atualizar";
                Console.WriteLine(e.Message);
               
            }
        }

        public virtual void ExcluirTipoQuarto()
        {
            this.Conn = new Connection();
            try
            {
                Mensagem = "";
                this.Conn.sqlString = "UPDATE [dbo].[TipoQuarto] SET Ds_Status = @DsStatus where ID_TipoQuarto = @ID; " +
                    "UPDATE Quartos SET Ds_Status = 0" +
                    "WHERE Ds_Status  = '1' " +
                    "AND ID_TipoQuarto IN (select ID_TipoQuarto from TipoQuarto where Ds_Status =0) ;";
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("ID", IDTipoQuarto);
                this.Conn.Cmd.Parameters.AddWithValue("DsStatus", DsStatus);
                this.Conn.ExecutarComParametros();
            }

            catch (Exception)
            {
                MessageBox.Show("Não foi possivel realizar a operação tente novamente");
            }
        }

     
    }
}
