using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.UI;

namespace StockManagementSystem
{
    static class Program
    {
        /// <summary>E:\Visual_studio\Project\StockManagementSystemWindowsFormApp-master\StockManagementSystem\StockManagementSystem\UI\
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new HomeUi());
            // Application.Run(new SupplierUi());
        }
    }
}
