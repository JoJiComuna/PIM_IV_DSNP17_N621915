using System;
using System.Drawing;
using System.Windows.Forms;


namespace Hotelaria.Controllers
{
    public class StylesController
    {

        public void OpenForms(object FormSon, object Panel)
        {
            Form FS = FormSon as Form;
            Panel panel = Panel as Panel;
            FS.TopLevel = false;
            FS.Dock = DockStyle.Fill;
            panel.Controls.Add(FS);
            panel.Tag = FS;
            FS.Show();
        }
        public void BackgroundFocus(Form myForm)
        {
            Form formBackground = new Form();
            try
            {
                using (myForm)
                {

                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.Location = Views.Menu.MainMenu.ActiveForm.Location;
                    formBackground.Size = Views.Menu.MainMenu.ActiveForm.Size;
                    formBackground.TopMost = false;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    myForm.Owner = formBackground;
                    myForm.ShowDialog();
                    formBackground.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                formBackground.Dispose();
                formBackground.Close();
            }
            finally
            {
                formBackground.Dispose();
            }


        }

        public void FormatarCPF(DataGridViewCellFormattingEventArgs e, int numcolum)
        {
            string cpf;
            Double d;
            if (e.ColumnIndex == numcolum && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);

                e.Value = d.ToString(@"000\.000\.000-00");
                cpf = e.Value.ToString();

                e.Value = cpf.Replace(cpf.Substring(4, 3), "###").Replace(cpf.Substring(12, 2), "##");

            }
        }
        public void FormatarCelular(DataGridViewCellFormattingEventArgs e, int numcolum)
        {
            string cell;
            Double d;
            if (e.ColumnIndex == numcolum && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);
                //(@"000\.000\.000-00");
                e.Value = d.ToString(@"(00) 0 0000 - 0000");
                cell = e.Value.ToString();


            }
        }
        public void FormatarStatus(DataGridViewCellFormattingEventArgs e, int numcolum)
        {
            string st;
            int i;
            if (e.ColumnIndex == numcolum && e.Value != null)
            {
               int.TryParse(e.Value.ToString(), out i);

                e.Value = i.ToString();
                st = e.Value.ToString();

                e.Value = st.Replace("1", "Ativo").Replace("0", "Desativado");

            }
        }

        public void FormatarDinheiro(DataGridViewCellFormattingEventArgs e, int numcolum)
        {
       
            Double d;
            if (e.ColumnIndex == numcolum && e.Value != null)
            {
                Double.TryParse(e.Value.ToString(), out d);
         
                e.Value = String.Format("{0:C}", d);


            }
        }

    }
    //private void CleanFormat()
    //{
    //    //limpar formatações das txtboxs
    //    cpf = TxtDocumento.Text.Replace(".", null).Replace("-", null);
    //    cell = TxtTelefone.Text.Replace("(", null).Replace(")", null).Replace("-", null).Replace(" ", null);
    //}

}

