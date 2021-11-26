using Hotelaria.Models;
using System;


using System.Data.SqlClient;

namespace Hotelaria.Controllers
{
    class RelatoriosController : Propriedades
    {

        public double DiariaMedia { get; set; }
        public decimal aReceber { get; set; }
        public double taxaOcupacao { get; set; }
        public double Ocupados { get; set; }
        public double QuartosCount { get; set; }
        public double Saldo { get; set; }


        public void ContarRegistros(DateTime data)
        {
            try
            {
                this.Conn = new Connection();
                //String de Conexão
                #region SqlString
                //Nomear Selects
                this.Msql.Append("SELECT Checkin, Checkout, Cancelado , HospedesCount, HospedagensCount, Reservas, aReceber , Ocupados , QuartosCount, Saldo ,DiariaMedia ");
                //Selecionar Checkins
                Msql.Append("FROM (SELECT COUNT(*) as Checkin FROM Hospedagens ");
                Msql.Append("WHERE Hospedagens.Ds_Status ='Check-In') a ");
                //Selecionar Checkouts
                Msql.Append("CROSS JOIN (SELECT COUNT(*) as Checkout FROM Hospedagens ");
                Msql.Append("WHERE Hospedagens.Ds_Status = 'Check-Out') b ");
                //Selecionar Hospedagens Canceladas
                Msql.Append("CROSS JOIN (SELECT COUNT(*) as Cancelado FROM Hospedagens ");
                Msql.Append("WHERE Hospedagens.Ds_Status = 'Cancelado') c ");
                //Contar todas Hospedagens
                Msql.Append("CROSS JOIN (SELECT COUNT(*) as HospedagensCount FROM Hospedagens ");
                Msql.Append("WHERE Hospedagens.Ds_Status != 'Cancelado') d ");
                //Contar Hospedes ativos
                Msql.Append("CROSS JOIN (SELECT COUNT(*) as HospedesCount FROM Hospedes ");
                Msql.Append("WHERE Hospedes.Ds_Status = 1 ) e ");
                //Calcular Diaria Média
                Msql.Append("CROSS JOIN (SELECT COUNT(*)as Reservas FROM Hospedagens ");
                Msql.Append("WHERE Hospedagens.Ds_Status = 'Reserva') f ");
                //Calcular A Receber
                Msql.Append("CROSS JOIN (SELECT Sum (Vl_TotalaPagar) as aReceber FROM Pagamentos ");
                Msql.Append("WHERE Pagamentos.Ds_Status != 'Pago' and Pagamentos.Ds_Status != 'Cancelado' ) g ");
                //Contar quartos Ocupados
                Msql.Append("CROSS JOIN (SELECT COUNT(*) as Ocupados FROM Hospedagens ");
                Msql.Append("WHERE Ds_Status like 'Check-In' ) h ");
                //
                Msql.Append("CROSS JOIN (SELECT COUNT(*) as QuartosCount FROM Quartos ");
                Msql.Append("WHERE Ds_Status = 1) i ");
                //

                Msql.Append("CROSS JOIN (SELECT Sum (Vl_TotalaPagar) as Saldo From Pagamentos ");
                Msql.Append("WHERE Ds_Status = 'Pago') j ");
                //
                Msql.Append("CROSS JOIN (SELECT AVG (Pr_Quarto) as DiariaMedia From TipoQuarto) k");
                //
                #endregion
                //
                this.Conn.sqlString = Msql.ToString();
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);


                this.Conn.Cmd.Parameters.AddWithValue("Data", data.Month);
                this.Conn.Conn.Open();
                using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                {
                    while (this.Conn.dataReader.Read())
                    {
                        CheckinCount = Convert.ToInt32(this.Conn.dataReader[0]);
                        CheckoutCount = Convert.ToInt32(this.Conn.dataReader[1]);
                        CanceladosCount = Convert.ToInt32(this.Conn.dataReader[2]);
                        HospedesCount = Convert.ToInt32(this.Conn.dataReader[3]);
                        HospedagensCount = Convert.ToInt32(this.Conn.dataReader[4]);
                        ReservasCount = Convert.ToInt32(this.Conn.dataReader[5].ToString());

                        aReceber = Convert.ToInt32(this.Conn.dataReader[6]);
                        Ocupados = Convert.ToInt32(this.Conn.dataReader[7]);
                        QuartosCount = Convert.ToInt32(this.Conn.dataReader[8]);
                        if (this.Conn.dataReader[9] == null)
                        {
                            Saldo = 0;
                        }
                        else
                        {

                            Saldo = Convert.ToDouble(this.Conn.dataReader[9]);
                        }

                        DiariaMedia = Convert.ToDouble(this.Conn.dataReader[10]);
                    }
                    taxaOcupacao = Ocupados / QuartosCount * 100;
                }

            }
            catch (Exception e)
            {
                Mensagem = "";
                Console.WriteLine(e.Message);


            }
            finally
            {
                this.Conn.Conn.Close();
                this.Conn.dataReader.Close();
                this.Conn.Cmd.Dispose();
                this.Conn.dataAdapter.Dispose();
            }

        }

        public void Notificar()
        {


            //muitos quartos ocupados
            //CHeckout
            //Voce não possui notificações
            //Não há mais quartos disponiveis hoje
            try
            {
                this.Conn = new Connection();
                //String de Conexão
                #region SqlString
                //Nomear Selects
                this.Msql.Append("SELECT Checkout, QuartosCount, Ocupados ");
                this.Msql.Append("FROM (SELECT COUNT(*) as Checkout FROM Hospedagens ");
                this.Msql.Append("WHERE Hospedagens.Ds_Status = 'Check-Out' and Dt_CheckOut =@Data) a ");
                //
                this.Msql.Append("CROSS JOIN (SELECT COUNT(*) as QuartosCount FROM Quartos ");
                this.Msql.Append("WHERE Ds_Status = 1) b ");
                //
                this.Msql.Append("CROSS JOIN (SELECT COUNT(*) as Ocupados FROM Hospedagens ");
                this.Msql.Append("WHERE Ds_Status = 'Check-In' or Ds_Status ='Reserva') c ");

                #endregion
                //
                this.Conn.sqlString = Msql.ToString();

                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                DateTime dataAtual = new DateTime();
                dataAtual = DateTime.Now.Date;
                this.Conn.Cmd.Parameters.AddWithValue("Data", dataAtual.ToShortDateString());


                //this.Conn.Cmd.Parameters.AddWithValue("Data", data.Month);
                this.Conn.Conn.Open();
                using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                {
                    while (this.Conn.dataReader.Read())
                    {

                        CheckoutCount = Convert.ToInt32(this.Conn.dataReader[0]);
                        QuartosCount = Convert.ToInt32(this.Conn.dataReader[1]);
                        Ocupados = Convert.ToInt32(this.Conn.dataReader[2]);

                    }
                    taxaOcupacao = Ocupados / QuartosCount * 100;
                }
                string Msg1;
             
                string Msg3;
                //Sem Notificações
                if (CheckoutCount <= 0)
                {
                    Msg1 = "•\n";
                    Mensagem = Msg1;
                }
                //Checkouts Hoje
                else
                {
                   Msg1 = "• Há Check-outs proximos da data de vencimento!\n";
                    Mensagem = Msg1;
                }

                //Quartos Cheios
                if (taxaOcupacao >= 100)
                {
                    Msg3= "• Todos os quartos estão ocupados hoje\n";
                    Mensagem = Mensagem +"\n"+Msg3;
                }
                

                //


            }
            catch (Exception e)
            {
                Mensagem = "Erro";
                Console.WriteLine(e.Message);


            }
            finally
            {
                this.Conn.Conn.Close();
                this.Conn.dataReader.Close();
                this.Conn.Cmd.Dispose();
                this.Conn.dataAdapter.Dispose();
            }


        }





    }
}
