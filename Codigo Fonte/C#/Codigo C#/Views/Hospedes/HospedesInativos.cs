using Hotelaria.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelaria.Views.Hospedes
{
    public partial class HospedesInativos : Form
    {
        public HospedesInativos()
        {
            InitializeComponent();
        }

        ADM.ADMMenu ADMMenu;
        StylesController style;
        Hospedescontroller HpdController;
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            style.OpenForms(ADMMenu, main.PanelADM);
            this.Close();
        }

        private void HospedesInativos_Load(object sender, EventArgs e)
        {
            ADMMenu = new ADM.ADMMenu();
            style = new StylesController();
            HpdController = new Hospedescontroller();
            HpdController.ConsultarInativos();
            DgvHospedes.DataSource = HpdController.Dgv.DataSource;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HpdController.ConsultarInativos();
            DgvHospedes.DataSource = HpdController.Dgv.DataSource;
        }

        private void DgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvHospedes.Columns[e.ColumnIndex].Name == "Editar")
            {
                HpdController.GetID = DgvHospedes.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show($"Continuar e  Ativar? " +
                $"\nHospede: {DgvHospedes.CurrentRow.Cells[1].Value.ToString()}" +
                    $"\n", "Ativar Hospede",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HpdController.Ativar();
                }
                if (HpdController.Mensagem == "")
                {
                    MessageBox.Show("Hóspede ativado com sucesso!");
                }
                else
                {
                    MessageBox.Show(HpdController.Mensagem);
                }
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Pesquisar por nome, documento...";
            }
        }

        private void TxtSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Pesquisar por nome, documento...")
            {
                TxtSearch.Text = "";
            }
        }
    }
}