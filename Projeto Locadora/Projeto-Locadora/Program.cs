using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Locadora
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBoxManager.OK = "OK";
            MessageBoxManager.Yes = "Expandir";
            MessageBoxManager.No = "Fechar";
            MessageBoxManager.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_splash());

        }
    }
}
