using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarsashaz
{
    static class Program
    {
        static public FormNyito formNyito = null;
        static public Database db = new Database();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formNyito = new FormNyito();
            Application.Run(formNyito);
        }
    }
}
