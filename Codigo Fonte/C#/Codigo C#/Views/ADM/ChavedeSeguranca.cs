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
    public partial class ChavedeSeguranca : Form
    {
        public ChavedeSeguranca()
        {
            InitializeComponent();
        }
        ADMController admController;

        ADM.ADMMenu ADMMenu;
        StylesController style;
        NovaChave novaChave;
        private void ChavedeSeguranca_Load(object sender, EventArgs e)
        {

            style = new StylesController();
            ADMMenu = new ADMMenu();
            novaChave = new NovaChave();
            admController = new ADMController();

            admController.ConsultarChave();
            DgvChave.DataSource = admController.Dgv.DataSource;

        }

        private void xuiButton9_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            style.OpenForms(ADMMenu, main.PanelADM);
            this.Close();
        }

        private void BtnNovaChavedeSeguranca_Click(object sender, EventArgs e)
        {

            style.BackgroundFocus(novaChave);
        }

        private void DgvChave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvChave.Columns[e.ColumnIndex].Name == "Editar")
            {
                novaChave.ID = Convert.ToInt32(DgvChave.CurrentRow.Cells[0].Value.ToString());
                novaChave.txtChave.Text = DgvChave.CurrentRow.Cells[1].Value.ToString();

                novaChave.BtnSalvar.ButtonText = "Atualizar";
                style.BackgroundFocus(novaChave);
            }
            if (DgvChave.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show($"Desativar Chave? " +
                $"\n\nChave {DgvChave.CurrentRow.Cells[1].Value}" +
                $"\n", "Dados da Chave",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    admController.GetNumber = DgvChave.CurrentRow.Cells[0].Value.ToString();
                    admController.ExcluirChave();
                    if (admController.Mensagem == "")
                    {
                        MessageBox.Show("Chave desativada com Sucesso");
                    }
                    else
                    {
                        MessageBox.Show(admController.Mensagem);
                    };
                }
                else
                {
                    MessageBox.Show("Desativamento Cancelado");
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            admController.ConsultarChave();
            DgvChave.DataSource = admController.Dgv.DataSource;
        }

        private void DgvChave_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            style.FormatarStatus(e, 2);
        }
    }
}
