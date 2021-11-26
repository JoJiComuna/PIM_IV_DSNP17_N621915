using System;
using System.Windows.Forms;
using Hotelaria.Models;



using MainMenu = Hotelaria.Views.Menu.MainMenu;
//using Login = Hotelaria.Views.Login;

namespace Hotelaria
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.Login());

        }

    }
   
}
