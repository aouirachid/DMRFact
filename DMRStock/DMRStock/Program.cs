using DMRStock.category;
using DMRStock.Entree;
using DMRStock.sortiee;
using DMRStock.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMRStock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new newCategory()) ;
            Application.Run(new loginPage());
        }
    }
}
