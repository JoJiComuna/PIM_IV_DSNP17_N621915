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
    public partial class NovoPatrimonio : Form
    {
        public NovoPatrimonio()
        {
            InitializeComponent();
        }
        public int ID = 0;
        ADMController aDMController;

        private void NovoPatrimonio_Load(object sender, EventArgs e)
        {
            aDMController = new ADMController();
            aDMController.DsStatus = "1";

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (BtnSalvar.ButtonText == "Salvar")
            {
                //Incluir
                #region Incluir
                if (MessageBox.Show($"Cofirmar Cadastro? " +
                      $"\n\nPatrimônio: {txtNmPatrimonio.Text}" +
                      $"\nQuarto Nº: {txtNrQuarto.Text}" +


                      $"\n", "Dados do Patrimônio",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  
                    aDMController.NmPatrimonio = txtNmPatrimonio.Text;
                    aDMController.GetNumber = txtNrQuarto.Text;
                    aDMController.IncluirPatrimonio();

                    if (aDMController.Mensagem == "")
                    {
                        MessageBox.Show("Concluído");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(aDMController.Mensagem);
                    };

                }
                #endregion
            }
            else
            {
                //Atualizar
                #region Atualizar
                if (MessageBox.Show($"Cofirmar Cadastro? " +
                      $"\n\nPatrimônio: {txtNmPatrimonio.Text}" +
                      $"\nQuarto: {txtNrQuarto.Text}" +
                      $"\n", "Dados do Patrimônio",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    aDMController.ID = ID;
                    aDMController.NmPatrimonio = txtNmPatrimonio.Text;
                    aDMController.GetNumber = txtNrQuarto.Text;


                    aDMController.AtualizarPatrimonio();
                    if (aDMController.Mensagem == "")
                    {
                        MessageBox.Show("Concluído");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(aDMController.Mensagem);
                    };
                }
                #endregion
            }
        }

        private void btnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            aDMController.DsStatus = "1";
        }

        private void btnInativo_CheckedChanged(object sender, EventArgs e)
        {
            aDMController.DsStatus = "0";
        }
    }
}
