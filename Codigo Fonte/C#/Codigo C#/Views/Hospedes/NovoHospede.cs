using Hotelaria.Controllers;
using System;

using System.Windows.Forms;
using static Hotelaria.Controllers.Hospedescontroller;

namespace Hotelaria.Views.Hospedes
{
    public partial class NovoHospede : Form
    {
        public NovoHospede()
        {

            InitializeComponent();
        }

        Hospedescontroller H;
        public string GetID;

        private void BtnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Sair? " +
               $"\n", "Cadastro de Hóspede",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            H = new Hospedescontroller();
            H.endrController = new EnderecoController();
            H.GetID = GetID;
            H.Nome = "" + TxtNomeHospede.Text;
            H.GetDocumento = "0" + TxtDocumento.Text;
            H.GetTelefone = "0" + TxtTelefone.Text;
            H.Email = "" + TxtEmail.Text;
            H.endrController.Estado = "" + txtEstado.Text;
            H.endrController.Cidade = "" + txtCidade.Text;
            H.endrController.Bairro = "" + txtBairro.Text;
            H.endrController.Rua = "" + txtRua.Text;
            H.endrController.GetNrEndereco = "" + txtNrEndereco.Text;
            if (MessageBox.Show($"Cofirmar ? " +
                 $"\nHospede: {H.Nome}" +
                 $"\nDocumento: {H.GetDocumento}" +
                 $"\nTelefone: {H.GetTelefone}" +
                 $"\nEmail:  {H.Email}" +
                 $"\n\nEndereço" +
                 $"\nUF- {H.endrController.Estado}" +
                 $" Cidade- {H.endrController.Cidade}" +
                 $"\nBairro: {H.endrController.Bairro}" +
                 $"\nRua: {H.endrController.Rua}" +
                 $" Nº {H.endrController.GetNrEndereco}" +
                 $"\n", "Dados do Hospede",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              
                if (BtnSalvar.ButtonText == "Salvar")
                {
                    H.Incluir();
                    if (H.Mensagem == "")
                    {
                        MessageBox.Show("Cadastro Concluído");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(H.Mensagem);
                      
                    };
                }
                //
                //
                else
                {
                    H.Atualizar();
                    if (H.Mensagem == "")
                    {
                        MessageBox.Show("Cadastro Atualizado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(H.Mensagem);
                        
                    };
                }
              
            
               
            }
       

        }



        private void NovoHospede_Load(object sender, EventArgs e)
        {


        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Cancelar Cadastro / Atualização ? " +
                 $"\n", "Cadastro de Hóspede",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
