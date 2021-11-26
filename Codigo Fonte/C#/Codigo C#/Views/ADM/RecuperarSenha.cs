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
    public partial class RecuperarSenha : Form
    {
        public RecuperarSenha()
        {
            InitializeComponent();
        }
        LoginController login;

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            login = new LoginController();
            login.VerificarUsuario(txtUserLogin.Text, TxtEmail.Text);
            if (login.Mensagem == "")
            {
                tabPageUser.SelectedTab = NovaSenha;
            }
            else
            {
                MessageBox.Show(login.Mensagem);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblMensagem.Visible == false)
            {
                login.AtualizarSenha(txtNovaSenha2.Text, txtUserLogin.Text, TxtEmail.Text);
                if (login.Mensagem == "")
                {
                    MessageBox.Show("Senha recuperada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(login.Mensagem);
                }
            }
            else
            {
                MessageBox.Show("Novas Senhas não conferem. Verifique para continuar...");
            }

        }
        private void txtNovaSenha1_TextChanged(object sender, EventArgs e)
        {
            if (txtNovaSenha1.Text != txtNovaSenha2.Text)
            {
                lblMensagem.Text = "Senhas não conferem ";
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
                lblMensagem.Text = "Senhas não conferem ";
                lblMensagem.Visible = true;
            }
            else
            {

                lblMensagem.Visible = false;
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }

