using Gestor.UI.Principal;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Gestor.UI
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            string processo = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(processo).Length > 1)
            {
                MessageBox.Show("Sistema já está em execução !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin());
            }
        }
    }
}
