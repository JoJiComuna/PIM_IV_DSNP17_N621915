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
    public partial class ControledePatrimonio : Form
    {
        public ControledePatrimonio()
        {
            InitializeComponent();
        }
        StylesController style;
        NovoPatrimonio novoPatrimonio;
        ADM.ADMMenu ADMMenu;
        ADMController admController;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            style.OpenForms(ADMMenu, main.PanelADM);
            this.Close();

        }

        private void BtnNovaChavedeSeguranca_Click(object sender, EventArgs e)
        {
            style.BackgroundFocus(novoPatrimonio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ControledePatrimonio_Load(object sender, EventArgs e)
        {
          
            style = new StylesController();
            ADMMenu = new ADMMenu();
            novoPatrimonio = new NovoPatrimonio();
            admController = new ADMController();
            admController.ConsultarPatrimonio();
            DgvPatrimonio.DataSource = admController.Dgv.DataSource;
        }

        private void DgvPatrimonio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DgvPatrimonio.Columns[e.ColumnIndex].Name == "Editar")
            {
                novoPatrimonio.ID = Convert.ToInt32(DgvPatrimonio.CurrentRow.Cells[0].Value.ToString());           
                novoPatrimonio.txtNrQuarto.Text = DgvPatrimonio.CurrentRow.Cells[1].Value.ToString();
                novoPatrimonio.txtNmPatrimonio.Text = DgvPatrimonio.CurrentRow.Cells[2].Value.ToString();
                novoPatrimonio.BtnSalvar.ButtonText = "Atualizar";
                style.BackgroundFocus(novoPatrimonio);
            }
            if (DgvPatrimonio.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show($"Desativar Chave? " +
                $"\n\nPatrimônio {DgvPatrimonio.CurrentRow.Cells[2].Value}" +
                $"\n", "Dados do Patrimônio",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    admController.GetNumber = DgvPatrimonio.CurrentRow.Cells[0].Value.ToString();
                    admController.ExcluirPatrimonio();
                    if (admController.Mensagem == "")
                    {
                        MessageBox.Show("Patrimônio desativado com Sucesso");
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

        private void label3_Click(object sender, EventArgs e)
        {
            admController.ConsultarPatrimonio();
            DgvPatrimonio.DataSource = admController.Dgv.DataSource;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            admController.GetNumber = TxtSearch.Text;
            admController.ProcurarPatrimonio();
         
            DgvPatrimonio.DataSource = admController.Dgv.DataSource;
        }

        private void DgvPatrimonio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            style.FormatarStatus(e, 3);
        }
    }
}
