using System;
using System.Windows.Forms;
using Hotelaria.Controllers;
namespace Hotelaria.Views.ADM
{
    public partial class NovoQuarto : Form
    {
        public NovoQuarto()
        {
            InitializeComponent();
        }
        QuartosController QController;
        public int NrQuarto = 0;
   


        private void NovoQuarto_Load(object sender, EventArgs e)
        {
            QController = new QuartosController();
            QController.SetTipoQuarto(cbxTipoQuarto);
            QController.DsStatus = "1";
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            QController.NmTipoQuarto = cbxTipoQuarto.Text;
            QController.GetTipoQuarto();
          
            if (BtnSave.ButtonText == "Salvar")
            {
                //Incluir
                #region Incluir
                if (MessageBox.Show($"Cofirmar Cadastro? " +
                      $"\n\nNome do Quarto: {txtNmQuarto.Text}" +
                      $"\nID Tipo Quarto: {QController.IDTipoQuarto}\nTipo Quarto - {QController.NmTipoQuarto}" +
                      $"\nStatus: {QController.DsStatus}" +
                      $"\n", "Dados do Quarto",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QController.NmQuarto = txtNmQuarto.Text;
                    QController.DsInfo = txtDsQuarto.Text;

                    QController.IncluirQuarto();
                    if (QController.Mensagem == "")
                    {
                        MessageBox.Show("Cadastro concluído com exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(QController.Mensagem);
                    };

                }
                #endregion
                //
            }
            else
            {
                //Atualizar
                #region Atualizar
                if (MessageBox.Show($"Cofirmar Atualização? " +
                      $"\n\nNome do Quarto: {txtNmQuarto.Text}" +
                      $"\nID Tipo Quarto: {QController.IDTipoQuarto}\nTipo Quarto - {QController.NmTipoQuarto}" +
                      $"\nStatus: {QController.DsStatus}" +
                      $"\n", "Dados do Quarto",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QController.NmQuarto = txtNmQuarto.Text;
                    QController.NrQuarto = NrQuarto;
                    QController.DsInfo = txtDsQuarto.Text;
                    QController.AtualizarQuarto();
                    if (QController.Mensagem == "")
                    {
                        MessageBox.Show("Cadastro Atualizado com exito");
                    

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(QController.Mensagem);
                    };
                }
                #endregion
                //
            }
       
        }

        private void btnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAtivo.Checked == true)
            {
                QController.DsStatus = "1";
            }
        }

        private void btnInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnInativo.Checked == true)
            {
                QController.DsStatus = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
