using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotelaria.Controllers;
namespace Hotelaria.Views.ADM
{
    public partial class NovoLoginUsuario : Form
    {
        public NovoLoginUsuario()
        {
            InitializeComponent();
        }
        public int ID = 0;
        UsuarioController userController;



        private void NovoLoginUsuario_Load(object sender, EventArgs e)
        {

            userController = new UsuarioController();
            userController.logController = new LoginController();
            if (btnSalvar1.ButtonText == "Salvar")
            {
                txtSenha.Enabled = true;
                linklblNovaSenha.Visible = false;
            }


        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {


            userController.ID = ID;
            userController.Nome = TxtNomeUsuario.Text;
            userController.GetDocumento = TxtDocumento.Text;
            userController.Email = TxtEmail.Text;
            //
            userController.logController.Ds_Login = txtUserLogin.Text;
            userController.logController.TipoUsuario = cbxTipo.Text;
            if (txtSenhaAtual.Text == txtSenha.Text && txtNovaSenha1.Text == txtNovaSenha2.Text && txtNovaSenha2.Text.Length>0)
            {
                userController.logController.Ds_Senha = txtNovaSenha2.Text;
            }
            else
            {
                userController.logController.Ds_Senha = txtSenha.Text;
            }
            //
            if (cbxTipo.Text == "ADM")
            {
                ADMController admController = new ADMController();
                admController.GetNumber = txtNrChaveSeguranca.Text;
                admController.VerificarChave();
                if (admController.Mensagem == "")
                {
                    switch (btnSalvar1.ButtonText)
                    {
                        case "Atualizar":
                            userController.Atualizar();
                            break;
                        case "Salvar":
                            userController.Incluir();
                            break;
                    }
                   
                }
                else
                {
                    MessageBox.Show(admController.Mensagem + "\nCaso não tenha uma chave altere o tipo de usuário para continuar");
                    cbxTipo.Text = "Comum";
                }
            }
            else
            {
                switch (btnSalvar1.ButtonText)
                {
                    case "Atualizar":
                        userController.Atualizar();
                        break;
                    case "Salvar":
                        userController.Incluir();
                        break;
                }
            }
     
            if (userController.Mensagem == "")
            {
                MessageBox.Show("Concluído");
                this.Close();
            }
            else
            {      
                    MessageBox.Show(userController.Mensagem);
            };

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            tabPageUser.SelectedTab = FormUser;

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxTipo_TextChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "ADM")
            {
                lblChavedeSeguranca.Visible = true;
                txtNrChaveSeguranca.Visible = true;
            }
            else
            {
                lblChavedeSeguranca.Visible = false;
                txtNrChaveSeguranca.Visible = false;
            }
        }



        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            tabPageUser.SelectedTab = FormLogin;
        }

        private void linklblNovaSenha_Click(object sender, EventArgs e)
        {
            tabPageUser.SelectedTab = NovaSenha;
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tabPageUser.SelectedTab = FormLogin;
        }

     

        private void txtSenhaAtual_TextChanged(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text != txtSenha.Text)
            {
                lblMensagem.Text = "Senha atual inválida ";
                lblMensagem.Visible = true;
            }
            else
            {

                lblMensagem.Visible = false;

            }

        }

        private void txtNovaSenha1_TextChanged(object sender, EventArgs e)
        {
            if (txtNovaSenha1.Text != txtNovaSenha2.Text)
            {
                lblMensagem.Text = "Novas senhas não conferem ";
                lblMensagem.Visible = true;
            }
            else
            {

                lblMensagem.Visible = false;
            }
        }

        private void txtNovaSenha2_TextChanged(object sender, EventArgs e)
        {
            if (txtNovaSenha1.Text != txtNovaSenha2.Text)
            {
                lblMensagem.Text = "Novas senhas não conferem ";
                lblMensagem.Visible = true;
            }
            else
            {

                lblMensagem.Visible = false;
                if (txtSenhaAtual.Text == txtSenha.Text || txtNovaSenha1.Text == txtNovaSenha2.Text)
                {
                    userController.logController.Ds_Senha = txtNovaSenha2.Text;
                }
            }
        }
    }
}
