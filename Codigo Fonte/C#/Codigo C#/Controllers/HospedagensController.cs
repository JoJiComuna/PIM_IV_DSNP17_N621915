
using System;
using Hotelaria.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Hotelaria.Controllers
{
    public class HospedagensController : Quartos
    {
        private Validacao validar;

        public QuartosController Q;

        public override void Incluir()
        {
            VerificarHospedagem();
            if (this.Validar.Mensagem == "valido")
            {

                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.SqlString = new System.Text.StringBuilder();
                    this.Conn.SqlString.Append("INSERT INTO [dbo].[Hospedagens] (ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto, ");
                    this.Conn.SqlString.Append("Qtd_Adultos, Qtd_Criancas, Ds_Status) ");
                    this.Conn.SqlString.Append("VALUES (@Hospede, @CheckIN, @CheckOut ,@NrQuarto,  @QtdAdultos, @QtdInfantil, @DsStatus) ");
                    this.Conn.SqlString.Append("INSERT INTO [dbo].Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) ");
                    this.Conn.SqlString.Append("Values (SCOPE_IDENTITY(),@TotalaPagar ,'Pendente') ");

                    this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);

                    #region Parametros Hospedagem

                    this.Conn.Cmd.Parameters.AddWithValue("Hospede", this.ID);
                    this.Conn.Cmd.Parameters.AddWithValue("CheckIN", this.Checkin);
                    this.Conn.Cmd.Parameters.AddWithValue("CheckOut", this.Checkout);
                    this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", this.NrQuarto);
                    this.Conn.Cmd.Parameters.AddWithValue("QtdAdultos", this.QtdAdultos);
                    this.Conn.Cmd.Parameters.AddWithValue("QtdInfantil", this.QtdCriancas);
                    this.Conn.Cmd.Parameters.AddWithValue("DsStatus", this.DsStatus);
                    this.Conn.Cmd.Parameters.AddWithValue("TotalaPagar", this.PrTotalaPagar);
                    #endregion

                    this.Conn.ExecutarComParametros1();


                }
                catch (Exception e)
                {
                    Mensagem = "Não foi possível realizar o cadastro "+ e.Message;
                  
                }
            }



        }

        public override void Consultar()
        {
            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                Mensagem = "";
                this.Conn.sqlString = "SELECt Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Quartos.Nr_Quarto," +
               "TipoQuarto.Nm_TipoQuarto, Qtd_Adultos, Qtd_Criancas, Hospedagens.Ds_Status FROM Quartos " +
               "INNER JOIN TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto INNER JOIN Hospedagens " +
               "on Hospedagens.Nr_Quarto = quartos.Nr_Quarto INNER JOIN Hospedes on Hospedagens.ID_Hospede = Hospedes.ID_Hospede ";
                this.Conn.Executar();
                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                Mensagem = ("erro ao carregar hóspedes");
            }
        }
        public void ConsultarSite()
        {
            this.Conn = new Connection();
     
            
            try
            {
                Mensagem = "";
                this.Conn.SqlString = new System.Text.StringBuilder();
                this.Conn.SqlString.Append("SELECT Hospedagens.Nr_Hospedagem as 'Nº Hospedagem', Dt_CheckIn as 'Check-In', ");
                this.Conn.SqlString.Append("Dt_CheckOut as 'Check-Out', Nr_Quarto as 'Nº Quarto', ");
                this.Conn.SqlString.Append("Qtd_Adultos as 'Adultos Extras', Qtd_Criancas as 'Crianças Extras' , ");
                this.Conn.SqlString.Append("Hospedagens.Ds_Status as 'Situação', Pagamentos.Vl_TotalaPagar as 'Valor', ");
                this.Conn.SqlString.Append("Pagamentos.Ds_Status as 'Status' ");
                this.Conn.SqlString.Append("FROM Hospedagens ");
                this.Conn.SqlString.Append("INNER JOIN Pagamentos ");
                this.Conn.SqlString.Append("ON Pagamentos.Nr_Hospedagem = Hospedagens.Nr_Hospedagem ");
                this.Conn.SqlString.Append("WHERE ID_Hospede = @ID; ");
                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);
                this.Conn.ExecutarComParametros();
               
            }
            catch (Exception e)
            {
                Mensagem = ("Erro ao carregar Hospedagens" + e.Message);
            }
        }
        //sobrescrever Procurar aplicar verificação
        public override void Procurar()
        {
            validar = new Validacao();
            NmHospede = GetHospedagem;
            //verificar se o numero pode ser convertido
            validar.ValidarInt(this.GetHospedagem);
            if (validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.NrHospedagem = int.Parse(this.GetHospedagem);
            }
            else
            {//nao (recebe 0)
                this.NrHospedagem = 0;
            }

            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                #region sqlString
                this.Conn.sqlString = "SELECT Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Quartos.Nr_Quarto," +
               "TipoQuarto.Nm_TipoQuarto, Qtd_Adultos, Qtd_Criancas, Hospedagens.Ds_Status FROM Quartos " +
               "INNER JOIN TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto INNER JOIN Hospedagens " +
               "on Hospedagens.Nr_Quarto = quartos.Nr_Quarto INNER JOIN Hospedes on Hospedagens.ID_Hospede = Hospedes.ID_Hospede " +
               "WHERE Nm_Hospede like @Nome OR Nr_Hospedagem = @nrHospedagem ";
                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("Nome", string.Format("%{0}%", this.NmHospede));
                this.Conn.Cmd.Parameters.AddWithValue("nrHospedagem", this.NrHospedagem);


                this.Conn.ExecutarComParametros();

                this.Dgv.DataSource = this.Conn.dataTable;
            }
            catch (Exception)
            {
                Mensagem = "Não foi possível realizar uma busca. Tente pesquisar de outra forma.";
            }
        }

        public override void Atualizar()
        {
            //Verificar e validar
            VerificarHospedagem();
            //
            this.Validar = new Validacao();
            this.Validar.ValidarDecimal(GetNumber);
            //Caso de certo
            if (this.Validar.Mensagem == "valido")
            {
                this.PrTotalaPagar = Convert.ToDecimal(GetNumber);
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE Hospedagens SET Dt_CheckIn = @CheckIN, Dt_CheckOut = @CheckOut," +
                "Qtd_Adultos = @QtdAdultos, Qtd_Criancas = @QtdCriancas, Ds_Status = @DsStatus " +
                "WHERE Nr_Hospedagem = @NrHospedagem " +
                "UPDATE Pagamentos SET Vl_TotalaPagar = @TotalaPagar WHERE Nr_Hospedagem = @NrHospedagem";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("NrHospedagem", this.NrHospedagem);
                    this.Conn.Cmd.Parameters.AddWithValue("CheckIN", this.Checkin);
                    this.Conn.Cmd.Parameters.AddWithValue("CheckOut", this.Checkout);
                    this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", this.NrQuarto);
                    this.Conn.Cmd.Parameters.AddWithValue("QtdAdultos", this.QtdAdultos);
                    this.Conn.Cmd.Parameters.AddWithValue("QtdCriancas", this.QtdCriancas);
                    this.Conn.Cmd.Parameters.AddWithValue("DsStatus", this.DsStatus);
                    this.Conn.Cmd.Parameters.AddWithValue("TotalaPagar", this.PrTotalaPagar);
                    this.Conn.ExecutarComParametros1();
                }
                catch (Exception )
                {
                    Mensagem = "Erro ao Atualizar Cadastro";
                }
            }
            //Caso não  a verificação retorna um erro e continua
        }

        public  void ConsultarCadastro()
        {

            validar = new Validacao();
            if (GetNrHospedagem != null)
            {
                validar.ValidarInt(this.GetNrHospedagem);
                if (validar.Mensagem == "valido")
                {

                    this.NrHospedagem = Convert.ToInt32(this.GetNrHospedagem);
                    this.Conn = new Connection();
                    try
                    {
                        this.Conn.sqlString = "SELECT * FROM Hospedagens Where Nr_Hospedagem = @NrHospedagem; ";
                        this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                        this.Conn.Cmd.Parameters.AddWithValue("NrHospedagem", this.NrHospedagem);
                        this.Conn.Conn.Open();
                        using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                        {
                            while (this.Conn.dataReader.Read())
                            {
                                this.ID = Convert.ToInt32(this.Conn.dataReader[1].ToString());
                                this.Checkin = Convert.ToDateTime(this.Conn.dataReader[2].ToString());
                                this.Checkout = Convert.ToDateTime(this.Conn.dataReader[3].ToString());
                                this.NrQuarto = Convert.ToInt32(this.Conn.dataReader[4].ToString());
                                this.QtdAdultos = Convert.ToInt32(this.Conn.dataReader[5].ToString());
                                this.QtdCriancas = Convert.ToInt32(this.Conn.dataReader[6].ToString());
                                this.DsStatus = this.Conn.dataReader[7].ToString();
                            }
                        }
                        this.Conn.Conn.Close();
                        this.Conn.dataReader.Close();
                    }
                    catch (Exception)
                    {
                        Mensagem = "Não foi possivel Consultar o cadastro";
                    }
                }
                else
                {
                    Mensagem = "Não foi possivel Consultar o cadastro";
                }
            }
        }

        public override void Excluir()
        {
            validar = new Validacao();
            //verificar se o numero pode ser convertido
            validar.ValidarInt(this.GetNrHospedagem);
            if (validar.Mensagem == "valido")//sim (converter nr de hospedagem)
            {
                this.NrHospedagem = int.Parse(this.GetNrHospedagem);

            }
            else
            {//nao (recebe 0)
                this.NrHospedagem = 0;
            }
          
                this.Conn = new Connection();
                try
                {
                    Mensagem = "";
                    this.Conn.sqlString = "UPDATE [dbo].[Hospedagens] SET Ds_Status = 'Cancelado' WHERE Nr_Hospedagem = @nrHospedagem " +
                    "UPDATE Pagamentos SET Ds_Status = 'Cancelado' Where Nr_Hospedagem = @nrHospedagem";
                    this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                    this.Conn.Cmd.Parameters.AddWithValue("nrHospedagem", this.NrHospedagem);
                    this.Conn.ExecutarComParametros();
               
                }
                catch (Exception)
                {
                   Mensagem =("Não foi possivel realizar a atualização tente novamente");
                }
       
        }

        public void VerificarHospedagem()
        {
            this.Validar = new Validacao();
            this.Validar.ValidarCamposHospedagem(this);
            switch (this.Validar.ValidarCamposHospedagem(this))
            {
                case 0:
                    break;
                case 1:
                    Mensagem = "Preencha os Campos Obrigátórios(*) para continuar";
                    MessageBox.Show(Mensagem +"\n"+ Validar.Mensagem);
                    break;
            }
            if (Checkin.Date.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                this.DsStatus = "Reserva";
            }
            else
            {
                this.DsStatus = "Check-in";
            }
        }

        public void CarregarDadosHospedagem(ComboBox Hospedagem)
        {

            validar = new Validacao();
            if (GetNrHospedagem != null)
            {
                validar.ValidarInt(this.GetNrHospedagem);
                if (validar.Mensagem == "valido")
                {
                    this.NrHospedagem = Convert.ToInt32(this.GetNrHospedagem);
                    this.Conn = new Connection();
                    Hospedagem.Items.Clear();
                    try
                    {
                        this.Conn.sqlString = "SELECT  Nm_Hospede , Nr_Hospedagem FROM Hospedes " +
                        "INNER JOIN Hospedagens ON Hospedagens.ID_Hospede = Hospedes.ID_Hospede " +
                        "WHERE Nr_Hospedagem = @NrHospedagem; ";
                        this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                        this.Conn.Cmd.Parameters.AddWithValue("NrHospedagem", this.NrHospedagem);
                        this.Conn.Conn.Open();
                        using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                        {
                            while (this.Conn.dataReader.Read())
                            {
                                NmHospede = this.Conn.dataReader[0].ToString();
                                NrHospedagem = Convert.ToInt32(this.Conn.dataReader[1].ToString());
                            }
                        }
                        this.Conn.Conn.Close();
                        this.Conn.dataReader.Close();
                        Hospedagem.Items.Add($"Nº {NrHospedagem} - Hóspede {NmHospede} ");
                        Hospedagem.SelectedIndex = 0;
                        Hospedagem.Enabled = false;
                    }
                    catch
                    {
                        Mensagem = "";
                    }
                }
                else
                {
                    Mensagem = "Não foi possivel Consultar o cadastro";
                }
            }

            //public override void Create ( DataGridView dgv , string Hospede , string Checkin , string Checkout , string qtdAdultos , string qtdInfantil )
            //{
            //    Conn = new Connection ();

            //    try
            //    {
            //    //case Nova Hospedagem
            //    if (novo == true){
            //        Conn.sqlString = "INSERT INTO [dbo].[Hospedagens] (ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Crianca, Ds_Status) VALUES " +
            //        "(@Hospede, @CheckIN, @CheckOut ,@NrQuarto,  @QtdAdultos, @QtdInfantil, @DsStatus)" +
            //        "INSERT INTO [dbo].Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),@TotalaPagar ,'Pendente');";
            //     }
            //     //case Update
            //     else{

            //            Conn.sqlString = "UPDATE [dbo].[Hospedagens] SET Dt_CheckIn = @CheckIN, Dt_CheckOut = @CheckOut," +
            //            " Qtd_Adultos = @QtdAdultos, Qtd_Criancas = @QtdInfantil,Ds_Status = @DsStatus";



            //     }
            //        Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //        Conn.Conn.Open ();
            //        #region Insert/Update Parameters
            //        Conn.Cmd.Parameters.AddWithValue ("Hospede" , Hospede);
            //        Conn.Cmd.Parameters.AddWithValue ("CheckIN" , Checkin);
            //        Conn.Cmd.Parameters.AddWithValue ("CheckOut" , Checkout);
            //        Conn.Cmd.Parameters.AddWithValue ("NrQuarto" , _nrQuarto);
            //        Conn.Cmd.Parameters.AddWithValue ("QtdAdultos" , qtdAdultos);
            //        Conn.Cmd.Parameters.AddWithValue ("QtdInfantil" , qtdInfantil);
            //        Conn.Cmd.Parameters.AddWithValue ("DsStatus" , _DsStatus);
            //        Conn.Cmd.Parameters.AddWithValue ("TotalaPagar" , _totalaPagar);
            //        #endregion


            //        if (_nrQuarto == 0 || Hospede.Length <= 0)
            //        {

            //            MessageBox.Show ("Preencha os campos obrigatórios para continuar");
            //        }

            //        else
            //        {

            //            Conn.Cmd.ExecuteNonQuery ();
            //        }

            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show ("Não foi possivel realizar o cadastro tente novamente");

            //    }


            //    Conn.Conn.Close ();
            //}
            //public override void Read ( DataGridView dgv )
            //{
            //    Conn = new Connection ();
            //    try
            //    {
            //        #region sqlString
            //        Conn.sqlString = " SELECt Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Quartos.Nr_Quarto," +
            //        " TipoQuarto.Nm_TipoQuarto, Qtd_Adultos, Qtd_Criancas, Hospedagens.Ds_Status FROM Quartos " +
            //        "INNER JOIN TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto INNER JOIN Hospedagens " +
            //        "on Hospedagens.Nr_Quarto = quartos.Nr_Quarto INNER JOIN Hospedes on Hospedagens.ID_Hospede = Hospedes.ID_Hospede ";
            //        #endregion
            //        Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //        Conn.Conn.Open ();
            //        Conn.Cmd.ExecuteNonQuery ();
            //        Conn.Conn.Close ();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show ("Erro ao carregar hospedagens");
            //    }
            //    ShowDgv ();
            //    dgv.DataSource = dataTable;
            //    base.Read (dgv);
            //}
            //public override void Update ( string nrHospedagem , string Checkin , string Checkout , string NrQuarto , string qtdAdultos , string qtdInfantil )
            //{

            //}
            //public override void Delete ( string nrHospedagem , string nome )
            //{
            //    Conn = new Connection ();
            //    if (MessageBox.Show ($" Voce realmente deseja excluir a hospedagem {nome}?" , "Confirm" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            Conn.sqlString = "UPDATE [dbo].[Hospedagens] SET Ds_Status = 'Cancelado' WHERE Nr_Hospedagem = @nrHospedagem";
            //            Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //            Conn.Cmd.Parameters.AddWithValue ("nrHospedagem" , nrHospedagem);
            //            Conn.Conn.Open ();
            //            Conn.Cmd.ExecuteNonQuery ();
            //            MessageBox.Show ("Hospedagem cancelada com sucesso!");
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show ("Não foi possivel realizar a atualização tente novamente");
            //        }
            //        Conn.Conn.Close ();
            //        Read (dgv);
            //    }
            //    else
            //    {
            //        MessageBox.Show ("Operação cancelada");
            //    }
            //}
            //public override void Search ( string nome , string documento )
            //{
            //    Conn = new Connection ();
            //    try
            //    {

            //        Conn.sqlString = "SELECT ID_Hospede, Nm_Hospede, Nr_Documento FROM [dbo].[Hospedes] WHERE Nr_Documento = @Documento or Nm_Hospede like @Nome";
            //        Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //        Conn.Cmd.Parameters.AddWithValue ("Documento" , documento);
            //        Conn.Cmd.Parameters.AddWithValue ("Nome" , string.Format ("%{0}%" , nome));
            //        Conn.Conn.Open ();
            //        Conn.Cmd.ExecuteNonQuery ();
            //    }
            //    catch (Exception)
            //    {


            //    }
            //    Conn.Conn.Close ();
            //    ShowDgv ();


            //}
            //public void TipoQuarto ( ComboBox TipoQuarto )
            //{
            //    Conn = new Connection ();


            //    try
            //    {
            //        Conn.sqlString = "SELECT  Nm_TipoQuarto FROM Quartos INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto " +
            //        "GROUP BY Quartos.ID_TipoQuarto, Nm_TipoQuarto";
            //        Conn.Conn.Open ();
            //        Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //        ShowDgv ();
            //        Conn.Cmd.ExecuteNonQuery ();

            //        TipoQuarto.DisplayMember = "Nm_TipoQuarto";
            //        TipoQuarto.DataSource = dataTable;

            //    }
            //    catch (Exception)
            //    {

            //    }

            //    Conn.Conn.Close ();
            //}
            //public void GetQuartosInfo ( ComboBox NomeQuarto , ComboBox Adultos , ComboBox Infantil , string nmQuarto , Label prAdulto , Label prInfantil )
            //{
            //    Conn = new Connection ();
            //    _qtdAdultos = 0;
            //    _qtdInfantil = 0;

            //    Adultos.Items.Clear ();
            //    Infantil.Items.Clear ();

            //    try
            //    {
            //        Conn.sqlString = "SELECT *FROM [dbo].[Quartos] INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Nm_TipoQuarto = @NmTipoQuarto";
            //        Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //        Conn.Cmd.Parameters.AddWithValue ("NmTipoQuarto" , nmQuarto);
            //        Conn.Conn.Open ();

            //        ShowDgv ();

            //        Conn.Cmd.ExecuteNonQuery ();

            //        NomeQuarto.DisplayMember = "Nm_Quarto";
            //        NomeQuarto.ValueMember = "Nr_Quarto";
            //        NomeQuarto.DataSource = dataTable;

            //        _nrQuarto = Convert.ToInt32 (NomeQuarto.SelectedValue.ToString ());

            //        //pegar valor de coluna e atribuir
            //        using (SqlDataReader rdr = Conn.Cmd.ExecuteReader ())
            //        {

            //            while (rdr.Read ())
            //            {

            //                _qtdAdultos = Convert.ToInt32 (rdr [6]);
            //                _qtdInfantil = Convert.ToInt32 (rdr [7]);
            //                _prAdultos = Convert.ToDecimal (rdr [9]);
            //                _prInfantil = Convert.ToDecimal (rdr [10]);
            //                _prQuarto = Convert.ToDecimal (rdr [8]);

            //            }

            //            for (int i = 0; i < _qtdAdultos; i++)
            //            {

            //                Adultos.Items.Add (i + 1);
            //            }

            //            for (int i = 0; i < _qtdInfantil; i++)
            //            {
            //                Infantil.Items.Add (i + 1);
            //            }

            //            prAdulto.Text = String.Format ("{0:C}" , _prAdultos);
            //            prInfantil.Text = String.Format ("{0:C}" , _prInfantil);



            //        }


            //    }

            //    catch (Exception)
            //    {

            //    }

            //    Conn.Conn.Close ();
            //}
            //public void GetQuartosValues ( Label qtdAdultos , Label qtdInfantil , Label totalaPagar , MetroDateTime Checkin , MetroDateTime Checkout , Label qtdDiaria , Label prDiaria )
            //{

            //    //Iniciar Campos em 0 toda vez que chamar o metodo para nao acumular valores
            //    #region Campos
            //    _totalAdulto = 0; _totalInfantil = 0;
            //    _totalDiarias = 0; _totalaPagar = 0;
            //    _DsStatus = "";
            //    #endregion

            //    DateTime date1 = Checkin.Value.Date;
            //    DateTime date2 = Checkout.Value.Date;
            //    TimeSpan diff = date2 - date1;


            //    if (diff.Days == 0)
            //    {
            //        _qtdDiarias = 1 + diff.Days;
            //    }
            //    else
            //    {
            //        _qtdDiarias = diff.Days;

            //    }

            //    qtdDiaria.Text = _qtdDiarias.ToString ();



            //    //Obter Status de Hospedagem (Check-in, Reserva)
            //    #region Status Hospedagem
            //    if (Checkin.Value.Date.ToShortDateString () != DateTime.Now.ToShortDateString ())
            //    {
            //        _DsStatus = "Reserva";
            //    }
            //    if (Checkin.Value.Date.ToShortDateString () == DateTime.Now.ToShortDateString ())
            //    {
            //        _DsStatus = "Check-in";
            //    }
            //    #endregion

            //    //Obter quantidas e calcular valores a pagar
            //    #region Calculos
            //    //qtd adutlos * preço por adulto
            //    _totalAdulto = Convert.ToInt32 (qtdAdultos.Text) * _prAdultos;

            //    //qtd crianças * preço por criança
            //    _totalInfantil = Convert.ToInt32 (qtdInfantil.Text) * _prInfantil;

            //    //qtd de diarias * preço por diaria
            //    _totalDiarias = Convert.ToInt32 (qtdDiaria.Text) * _prQuarto;

            //    // valor total a pagar (soma de preços crianças adultos e tarifa do quarto)
            //    _totalaPagar = (_totalAdulto + _totalInfantil + _totalDiarias);

            //    //formatar valores para view
            //    prDiaria.Text = String.Format ("{0:C}" , _prQuarto);
            //    totalaPagar.Text = String.Format ("{0:C}" , _totalaPagar);

            //    #endregion
            //}
            //public void EditHospedagem ( string nrQuarto , Label nmTipoQuarto , Label prQuarto , Label prAdulto , Label prInfantil , ComboBox Adultos , ComboBox Infantil )
            //{
            //    Conn = new Connection ();

            //    try
            //    {
            //        #region sqlString
            //        Conn.sqlString = " SELECT Nm_TipoQuarto ,Pr_ExtraAdulto, Pr_ExtraCrianca, Pr_Quarto, Max_Adultos, Max_Crianca " +
            //        "FROM Quartos INNER JOIN TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Nr_Quarto = @nrQuarto";
            //        #endregion

            //        Conn.Cmd = new SqlCommand (Conn.sqlString , Conn.Conn);
            //        Conn.Cmd.Parameters.AddWithValue ("nrQuarto" , nrQuarto);
            //        Conn.Conn.Open ();

            //        ShowDgv ();

            //        Conn.Cmd.ExecuteNonQuery ();


            //        //pegar valor de coluna e atribuir
            //        using (SqlDataReader rdr = Conn.Cmd.ExecuteReader ())
            //        {

            //            while (rdr.Read ())
            //            {
            //                nmTipoQuarto.Text = $"{nrQuarto}" + " - " + rdr [0].ToString ();
            //                _prAdultos = Convert.ToDecimal (rdr [1]);
            //                _prInfantil = Convert.ToDecimal (rdr [2]);
            //                _prQuarto = Convert.ToDecimal (rdr [3]);
            //                _qtdAdultos = Convert.ToInt32 (rdr [4]);
            //                _qtdInfantil = Convert.ToInt32 (rdr [5]);

            //            }

            //            for (int i = 0; i < _qtdAdultos; i++)
            //            {

            //                Adultos.Items.Add (i + 1);
            //            }

            //            for (int i = 0; i < _qtdInfantil; i++)
            //            {
            //                Infantil.Items.Add (i + 1);
            //            }

            //        }
            //    }

            //    catch (Exception)
            //    {

            //    }
            //    finally
            //    {
            //        prAdulto.Text = String.Format ("{0:C}" , _prAdultos);
            //        prInfantil.Text = String.Format ("{0:C}" , _prInfantil);
            //        prQuarto.Text = String.Format ("{0:C}" , _prQuarto);
            //        Conn.Conn.Close ();
            //    }

            //}
            //public override void ShowDgv ( )
            //{

            //    dataTable = new DataTable ();
            //    dataAdapter = new SqlDataAdapter (Conn.Cmd);
            //    dataAdapter.Fill (dataTable);
            //}


        }

        public void CarregarDadosHospedagens(ComboBox Hospedagem)
        {
            this.Conn = new Connection();
            Hospedagem.Items.Clear();
            try
            {
                this.Conn.sqlString = "SELECT  Nm_Hospede , Hospedagens.Nr_Hospedagem FROM Hospedes " +
                "INNER JOIN Hospedagens ON Hospedagens.ID_Hospede = Hospedes.ID_Hospede " +
                "INNER JOIN Pagamentos ON Pagamentos.Nr_Hospedagem = Hospedagens.Nr_Hospedagem " +
                "WHERE Pagamentos.Ds_Status !='Pago' ";
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);
                this.Conn.Conn.Open();
                this.Conn.dataSet = new DataSet();
                this.Conn.dataAdapter = new SqlDataAdapter(this.Conn.Cmd);
                this.Conn.dataAdapter.Fill(this.Conn.dataSet);
                this.Conn.Cmd.ExecuteNonQuery();

                for (int i = 0; i < this.Conn.dataSet.Tables[0].Rows.Count; i++)
                {
                    NmHospede = this.Conn.dataSet.Tables[0].Rows[i][0].ToString();
                    NrHospedagem = Convert.ToInt32(this.Conn.dataSet.Tables[0].Rows[i][1].ToString());
                    Hospedagem.Items.Add($"Nº {NrHospedagem} - Hóspede {NmHospede} ");
                }


                this.Conn.Conn.Close();


                Hospedagem.Enabled = true;
            }
            catch
            {
                Mensagem = "";
            }
        }

        public void VerificarDataDisponivel(DateTime checkin, DateTime checkout, string nrQuarto) 
        {
         

            this.Conn = new Connection();
            this.Dgv = new DataGridView();
            try
            {
                Mensagem = "";
                #region sqlString
                this.Conn.SqlString = new System.Text.StringBuilder();
                this.Conn.SqlString.Append("SELECT Nr_Quarto ");
                this.Conn.SqlString.Append("FROM Hospedagens ");
                this.Conn.SqlString.Append("Where Nr_Quarto =@NrQuarto and Dt_CheckIn  between  @Checkin  and @Checkout and Ds_Status = 'Check-In'  ");
                this.Conn.SqlString.Append("or Dt_CheckOut  between  @Checkin  and @Checkout and Ds_Status != 'Check-Out' ");


                #endregion
                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("Checkin", checkin.ToShortDateString());
                this.Conn.Cmd.Parameters.AddWithValue("Checkout", checkout.ToShortDateString());
                this.Conn.Cmd.Parameters.AddWithValue("NrQuarto", nrQuarto);
                this.Conn.Conn.Open();
                using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                {
                    while (this.Conn.dataReader.Read())
                    {
                        if (nrQuarto == this.Conn.dataReader[0].ToString())
                        {
                            Mensagem = "Data Indisponível";
                        }
                    }
                    if (1 + (checkout.Date - checkin.Date).TotalDays <=0 )
                    {
                        Mensagem = "Data de Checkin não pode ser menor que a de Check-Out";
                    }
                    if (checkin.Date < DateTime.Now || checkout.Date < DateTime.Now)
                    {
                        Mensagem = "Data Inválida";
                    }
                }    
            }
            catch (Exception )
            {
                 Mensagem = " Data Indisponível"; 
            }

        }

        public void ContarRegistros()
        {
            try
            {
                this.Conn = new Connection();
                //String de Conexão
                #region SqlString
                //Nomear Selects
                this.Msql.Append("SELECT Cancelados, Checkins, Reservas ");
                this.Msql.Append("FROM (SELECT COUNT(*) as Cancelados FROM Hospedagens ");
                this.Msql.Append("WHERE Hospedagens.Ds_Status = 'Cancelado' ) a ");
                this.Msql.Append("CROSS JOIN (SELECT COUNT(*) as Checkins FROM Hospedagens ");
                this.Msql.Append("WHERE Hospedagens.Ds_Status = 'Check-In') b ");
                this.Msql.Append("CROSS JOIN (SELECT COUNT(*)as Reservas FROM Hospedagens ");
                this.Msql.Append("WHERE Hospedagens.Ds_Status = 'Reserva') c ");
        
                #endregion
                //
                this.Conn.sqlString = Msql.ToString();
                this.Conn.Cmd = new SqlCommand(this.Conn.sqlString, this.Conn.Conn);


                this.Conn.Conn.Open();
                using (this.Conn.dataReader = this.Conn.Cmd.ExecuteReader())
                {
                    while (this.Conn.dataReader.Read())
                    {
                       
                        CanceladosCount = Convert.ToInt32(this.Conn.dataReader[0]);
                        CheckinCount = Convert.ToInt32(this.Conn.dataReader[1]);
                        ReservasCount = Convert.ToInt32(this.Conn.dataReader[2]);

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
                this.Conn.Cmd.Dispose();
                this.Conn.dataAdapter.Dispose();
            }
        }

        public void FinalizarHospedagem() 
        {
            this.Conn = new Connection();

            try
            {
                this.Conn.SqlString = new System.Text.StringBuilder();
                Mensagem = "";
                this.Conn.SqlString.Append("UPDATE Hospedagens SET Ds_Status = 'Check-Out' ");
                this.Conn.SqlString.Append("WHERE Nr_Hospedagem = @ID ");

                this.Conn.Cmd = new SqlCommand(this.Conn.SqlString.ToString(), this.Conn.Conn);
                this.Conn.Cmd.Parameters.AddWithValue("ID", this.ID);

                this.Conn.Conn.Open();
                this.Conn.dataTable = new DataTable();
                this.Conn.dataAdapter = new SqlDataAdapter(this.Conn.Cmd);
                this.Conn.dataAdapter.Fill(this.Conn.dataTable);
                this.Conn.Cmd.ExecuteNonQuery();
             
            }

            catch (Exception e)
            {
                Mensagem = "Erro ao finalizar Hospedagem" + e.Message;
            }
            this.Conn.Conn.Close();
        }
    }

}
