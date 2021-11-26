using Hotelaria.Controllers;
using System;
using System.Windows.Forms;

namespace Hotelaria.Views.Hospedes
{
    public partial class Hospedes : Form
    {
        public Hospedes ( )
        {
            InitializeComponent ();
        }

        Hospedescontroller H;
        EnderecoController E;
        StylesController Stylle;

        #region Métodos
        private void Hospedes_Load ( object sender , EventArgs e )
        {
            Stylle = new StylesController();
            H = new Hospedescontroller();
            H.Consultar();

            DgvHospedes.DataSource = H.Dgv.DataSource;
          
         
            LblHospedesCount.Text = DgvHospedes.Rows.Count.ToString ();
        }

        private void BtnNovoHospede_Click ( object sender , EventArgs e )
        {
            NovoHospede nH = new NovoHospede ();
            StylesController Style = new StylesController();
            Style.BackgroundFocus(nH);
            
        }

        private void DgvHospedes_CellContentClick ( object sender , DataGridViewCellEventArgs e )
        {
            //passar valores da linha selecionada para caixas de texto de novo hospede / campos a serem atualizados
            NovoHospede nH = new NovoHospede ();
   
            H = new Hospedescontroller();
            E = new EnderecoController();
            nH.GetID = DgvHospedes.CurrentRow.Cells [0].Value.ToString ();
            H.GetID = DgvHospedes.CurrentRow.Cells [0].Value.ToString ();
            E.GetIDHospede = DgvHospedes.CurrentRow.Cells [0].Value.ToString ();
            H.ConsultarCadastro ();
            E.Consultar ();

            nH.lblNovoHospede.Text = "Alterar Cadastro";
            nH.BtnSalvar.ButtonText = "Atualizar";
            if (DgvHospedes.Columns [e.ColumnIndex].Name == "Editar")
            {            
                nH.TxtNomeHospede.Text = H.Nome;
                nH.TxtDocumento.Text = H.Documento.ToString();
                nH.TxtTelefone.Text = H.Telefone.ToString();
                nH.TxtEmail.Text = H.Email;
                nH.txtEstado.Text = E.Estado;
                nH.txtCidade.Text = E.Cidade;
                nH.txtBairro.Text = E.Bairro;
                nH.txtRua.Text = E.Rua;
            
                nH.txtNrEndereco.Text = E.NrEndereco.ToString();
                StylesController Style = new StylesController();
                Style.BackgroundFocus(nH);
            }

            if (DgvHospedes.Columns [e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show($"Continuar e  Desativar? " +
                $"\nHospede: {H.Nome}" +
                $"\nDocumento: {H.Documento}" +
                $"\n", "Dados do Hospede",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    H.Excluir();
                    if (H.Mensagem == "")
                    {
                        MessageBox.Show("Hóspede desativado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show(H.Mensagem);
                    };
                }
            }

            if (DgvHospedes.Columns [e.ColumnIndex].Name == "Mostrar")
            {
                FichaHospede FH = new FichaHospede();
                FH.lblNome.Text = H.Nome;
                FH.lblDocumento.Text = H.Documento.ToString();
                FH.lblTelefone.Text = H.Telefone.ToString();
                FH.lblEmail.Text = H.Email;
                FH.lblEstado.Text = E.Estado;
                FH.lblCidade.Text =E.Cidade;
                FH.lblRua.Text = E.Rua;
                FH.lblBairro.Text = E.Bairro;
                FH.lblNrEndenreco.Text = E.NrEndereco.ToString();
                StylesController Style = new StylesController();
                Style.BackgroundFocus(FH);
            }
        }

        private void btnProcurar_Click ( object sender , EventArgs e )
        {
            H = new Hospedescontroller();
            H.GetHospede = TxtSearch.Text;
            H.Procurar(); 
            DgvHospedes.DataSource = H.Dgv.DataSource;
            TxtSearch.Text = "";
            if (H.Mensagem != "") 
            {
                MessageBox.Show(H.Mensagem);
            }
        }

        private void TxtSearch_Click ( object sender , EventArgs e )
        {
            if (TxtSearch.Text == "Pesquisar por nome, documento...")
            {
                TxtSearch.Text = "";
            }
            TxtSearch.Text ="";
        }

        private void TxtSearch_Leave ( object sender , EventArgs e )
        {
            if(TxtSearch.Text == "")
            {
                TxtSearch.Text = "Pesquisar por nome, documento...";
            }
        }
 
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            H.Consultar();
            DgvHospedes.DataSource = H.Dgv.DataSource;
            LblHospedesCount.Text = DgvHospedes.Rows.Count.ToString();
        }
        #endregion

        private void DgvHospedes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Stylle.FormatarCPF(e, 2);
            Stylle.FormatarCelular(e,3);

        }
    }
}
