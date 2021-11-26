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
    public partial class TipoQuarto : Form
    {
        public TipoQuarto()
        {
            InitializeComponent();
        }
        StylesController style;
        NovoTipoQuarto NovoTipo;
        ADM.ADMMenu ADMMenu;
        QuartosController QController;

        private void TipoQuarto_Load(object sender, EventArgs e)
        {

            style = new StylesController();
            ADMMenu = new ADMMenu();
            QController = new QuartosController();
            QController.ConsultarTipoQuarto();
            dgvTipoQuarto.DataSource = QController.Dgv.DataSource;

        }

        private void BtnNovoTipo_Click(object sender, EventArgs e)
        {
            NovoTipo = new NovoTipoQuarto();
            style.BackgroundFocus(NovoTipo);
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            style.OpenForms(ADMMenu, main.PanelADM);
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QController.ConsultarTipoQuarto();
            dgvTipoQuarto.DataSource = QController.Dgv.DataSource;
        }

        private void dgvTipoQuarto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NovoTipo = new NovoTipoQuarto();

            if (dgvTipoQuarto.Columns[e.ColumnIndex].Name == "Editar")
            {
                NovoTipo.IDTipoQuarto = Convert.ToInt32(dgvTipoQuarto.CurrentRow.Cells[0].Value.ToString());
                NovoTipo.txtNomeTipo.Text = dgvTipoQuarto.CurrentRow.Cells[1].Value.ToString();
                NovoTipo.txtMaxAdultos.Text = dgvTipoQuarto.CurrentRow.Cells[2].Value.ToString();
                NovoTipo.txtMaxCriancas.Text = dgvTipoQuarto.CurrentRow.Cells[3].Value.ToString();
                NovoTipo.txtPrTipoQuarto.Text = dgvTipoQuarto.CurrentRow.Cells[4].Value.ToString();
                NovoTipo.txtVlAdultos.Text = dgvTipoQuarto.CurrentRow.Cells[5].Value.ToString();
                NovoTipo.txtVlCrianca.Text = dgvTipoQuarto.CurrentRow.Cells[6].Value.ToString();
                NovoTipo.BtnSave.ButtonText = "Atualizar";
                style.BackgroundFocus(NovoTipo);
            }
            if (dgvTipoQuarto.Columns[e.ColumnIndex].Name == "Deletar")
            {
                QController.IDTipoQuarto = Convert.ToInt32(dgvTipoQuarto.CurrentRow.Cells[0].Value);
                QController.DsStatus = "0";

                if (MessageBox.Show($"Desativar Tipo Quarto? " +
                  $"\n\nTIpo {dgvTipoQuarto.CurrentRow.Cells[1].Value}" +
                  $"\n", "Dados do Quarto",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    QController.ExcluirTipoQuarto();
                }
                else
                {
                    MessageBox.Show("Desativação cancelada!");
                }

            }
        }

        private void dgvTipoQuarto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            style.FormatarStatus(e, 7);
            style.FormatarDinheiro(e, 4);
            style.FormatarDinheiro(e, 5);
            style.FormatarDinheiro(e, 6);

        }
    }
}
