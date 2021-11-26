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
    public partial class Quartos : Form
    {
        public Quartos()
        {
            InitializeComponent();
        }
        StylesController Style;
        NovoQuarto NovoQuarto;
        QuartosController QController;
        ADM.ADMMenu ADMMenu;



        private void BtnNovoQuarto_Click(object sender, EventArgs e)
        {
            NovoQuarto = new NovoQuarto();
            Style.BackgroundFocus(NovoQuarto);

        }

        private void xuiButton9_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            Style.OpenForms(ADMMenu, main.PanelADM);
            this.Close();
        }

      
        private void DgvQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NovoQuarto = new NovoQuarto();

            if (DgvQuartos.Columns[e.ColumnIndex].Name == "Editar")
            {
                NovoQuarto.NrQuarto = Convert.ToInt32(DgvQuartos.CurrentRow.Cells[0].Value);
                NovoQuarto.txtNmQuarto.Text = DgvQuartos.CurrentRow.Cells[2].Value.ToString();
                NovoQuarto.txtDsQuarto.Text = DgvQuartos.CurrentRow.Cells[3].Value.ToString();
                NovoQuarto.BtnSave.ButtonText = "Atualizar";
                Style.BackgroundFocus(NovoQuarto);
            }
            if (DgvQuartos.Columns[e.ColumnIndex].Name == "Deletar")
            {
                QController.NrQuarto = Convert.ToInt32(DgvQuartos.CurrentRow.Cells[0].Value);
                QController.DsStatus = "0";

                if (MessageBox.Show($"Desativar Quarto? " +
                  $"\n\nQuarto Nº {QController.NrQuarto}" +
                              $"\n", "Dados do Quarto",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QController.ExcluirQuarto();
                    if (QController.Mensagem == "")
                    {
                        MessageBox.Show("Tipo Quarto Desativado com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show(QController.Mensagem);
                    }
                }
                else
                {
                    MessageBox.Show("Desativação cancelada!");
                }

            }
        }

        private void Quartos_Load(object sender, EventArgs e)
        {
            QController = new QuartosController();
            Style = new StylesController();

            QController.ConsultarQuartos();
            DgvQuartos.DataSource = QController.Dgv.DataSource;

            ADMMenu = new ADMMenu();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QController.ConsultarQuartos();
            DgvQuartos.DataSource = QController.Dgv.DataSource;
        }

        private void DgvQuartos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Style.FormatarStatus(e, 4);
        }
    }
}
