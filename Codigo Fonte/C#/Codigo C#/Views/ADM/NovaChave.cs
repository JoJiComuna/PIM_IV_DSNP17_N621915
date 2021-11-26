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
    public partial class NovaChave : Form
    {
        public NovaChave()
        {
            InitializeComponent();
        }
        ADMController admController;
        public int ID = 0;


        private void NovaChave_Load(object sender, EventArgs e)
        {

            admController = new ADMController();
            admController.DsStatus = "1";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSalvar.ButtonText == "Salvar")
            {
                //Incluir
                #region Incluir
                if (MessageBox.Show($"Cofirmar Cadastro de Chave de Segurança? " +
                      $"\n\nChave: {txtChave.Text}" +
                      $"\n\nStatus: {admController.DsStatus}" +
                      $"\n", "Dados da Chave",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    admController.GetNumber = txtChave.Text;

                    admController.IncluirChave();
                    if (admController.Mensagem == "")
                    {
                        MessageBox.Show("Cadastro concluído com exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(admController.Mensagem);
                    };
                }
                #endregion
            }
            else
            {
                //Atualizar
                #region Atualizar
                if (MessageBox.Show($"Cofirmar Cadastro de Chave de Segurança? " +
                  $"\n\nChave: {txtChave.Text}" +
                  $"\n\nStatus: {admController.DsStatus}" +
                  $"\n", "Dados da Chave",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    admController.GetNumber = txtChave.Text;
                    admController.ID = ID;
                    admController.AtualizarChave();

                    if (admController.Mensagem == "")
                    {
                        MessageBox.Show("Cadastro Atualizado com exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(admController.Mensagem);
                    };
                }
                #endregion
            }
        }

        private void btnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            admController.DsStatus = "1";
        }

        private void btnInativo_CheckedChanged(object sender, EventArgs e)
        {
            admController.DsStatus = "0";
        }
    }
}

