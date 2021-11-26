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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        StylesController style;
        UsuarioController User;
        NovoLoginUsuario NovoUsuario;
        ADM.ADMMenu ADMMenu;

        private void Usuarios_Load(object sender, EventArgs e)
        {

            style = new StylesController();
            ADMMenu = new ADMMenu();
            User = new UsuarioController();
            User.Consultar();
            DgvUsuarios.DataSource = User.Dgv.DataSource;
            LblUserCount.Text = DgvUsuarios.RowCount.ToString();

        }

        private void BtnNovoUsuario_Click(object sender, EventArgs e)
        {
            NovoUsuario = new NovoLoginUsuario();
            style.BackgroundFocus(NovoUsuario);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Views.Menu.MainMenu main = (Menu.MainMenu)ActiveForm;
            main.PanelADM.Controls.Clear();
            style.OpenForms(ADMMenu, main.PanelADM);
            this.Close();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NovoUsuario = new NovoLoginUsuario();
            User.GetID = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {

                NovoUsuario.ID = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                NovoUsuario.TxtNomeUsuario.Text = DgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                NovoUsuario.TxtEmail.Text = DgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                NovoUsuario.TxtDocumento.Text = DgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                NovoUsuario.btnSalvar1.ButtonText = "Atualizar";
                NovoUsuario.btnSalvar2.ButtonText = "Atualizar";

                
                //
                //
                User.ConsultarDadosLogin();
                NovoUsuario.txtUserLogin.Text = User.logController.Ds_Login;
                NovoUsuario.txtSenha.Text = User.logController.Ds_Senha;
                NovoUsuario.cbxTipo.Text = User.logController.TipoUsuario;
                //


                style.BackgroundFocus(NovoUsuario);
            }
            if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show($"Desativar Usuario? " +
                $"\n\nUsuario {DgvUsuarios.CurrentRow.Cells[1].Value}" +
                $"\n", "Dados do Usuario",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    User.Excluir();
                    if (User.Mensagem == "")
                    {
                        MessageBox.Show("Usuario desativado com Sucesso");
                    }
                    else
                    {
                        MessageBox.Show(User.Mensagem);
                    };
                }
                else
                {
                    MessageBox.Show("Desativamento Cancelado");
                }
            }
            if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Mostrar")
            {
                User.ID = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                User.ConsultarDadosLogin();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            User.GetHospede = TxtSearch.Text;
            User.Procurar();
            DgvUsuarios.DataSource = User.Dgv.DataSource;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            User.Consultar();
            DgvUsuarios.DataSource = User.Dgv.DataSource;
            LblUserCount.Text = DgvUsuarios.RowCount.ToString();
        }

        private void xuiButton14_Click(object sender, EventArgs e)
        {

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

        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            style.FormatarCPF(e, 3);
            style.FormatarStatus(e, 4);
        }
    }
}
