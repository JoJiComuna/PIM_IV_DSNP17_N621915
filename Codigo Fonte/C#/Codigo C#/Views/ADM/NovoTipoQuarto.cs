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
    public partial class NovoTipoQuarto : Form
    {
        public NovoTipoQuarto()
        {
            InitializeComponent();
        }
        public int IDTipoQuarto = 0;
        QuartosController QController;


        private void BtnSave_Click(object sender, EventArgs e)
        {
            //QController.NmTipoQuarto = cbxTipoQuarto.Text;
            //QController.GetTipoQuarto();

            if (BtnSave.ButtonText == "Salvar")
            {
                //Incluir
                #region Incluir
                if (MessageBox.Show($"Cofirmar Cadastro? " +
                      $"\n\nNome do Tipo: {txtNomeTipo.Text}" +
                      $"\nValor R$: {txtPrTipoQuarto}" +
                      $"\nValor por Adulto R$: {txtVlAdultos}" +
                      $"\nValor por Criança R$: {txtVlCrianca}" +
                      $"\nMax de Adultos R$: {txtMaxAdultos}" +
                      $"\nMax de Crianças R$: {txtMaxCriancas}" +
                      $"\nMax de Crianças R$: {QController.DsStatus}" +

                      $"\n", "Dados do Quarto",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QController.NmTipoQuarto = txtNomeTipo.Text;
                    QController.GetPrQuarto = txtPrTipoQuarto.Text;
                    QController.GetPrAdultos = txtVlAdultos.Text;
                    QController.GetPrCriancas = txtVlCrianca.Text;
                    QController.GetMaxAdultos = txtMaxAdultos.Text;
                    QController.GetMaxCriancas = txtMaxCriancas.Text;
                    QController.IncluirTipoQuarto();
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
            }
            else
            {
                //Atualizar
                #region Atualizar
                if (MessageBox.Show($"Cofirmar Cadastro? " +
                $"\n\nNome do Tipo: {txtNomeTipo.Text}" +
                $"\nValor R$: {txtPrTipoQuarto.Text}" +
                $"\nValor por Adulto R$: {txtVlAdultos.Text}" +
                $"\nValor por Criança R$: {txtVlCrianca.Text}" +
                $"\nMax de Adultos R$: {txtMaxAdultos.Text}" +
                $"\nMax de Crianças R$: {txtMaxCriancas.Text}" +
                $"\nMax de Crianças R$: {QController.DsStatus}" +

                $"\n", "Dados do Quarto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QController.IDTipoQuarto = IDTipoQuarto;
                    QController.NmTipoQuarto = txtNomeTipo.Text;
                    QController.GetPrQuarto = txtPrTipoQuarto.Text;
                    QController.GetPrAdultos = txtVlAdultos.Text;
                    QController.GetPrCriancas = txtVlCrianca.Text;
                    QController.GetMaxAdultos = txtMaxAdultos.Text;
                    QController.GetMaxCriancas = txtMaxCriancas.Text;
                    QController.AtualizarTipoQuarto();
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
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoTipoQuarto_Load(object sender, EventArgs e)
        {
            QController = new QuartosController();
            QController.DsStatus = "1";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
