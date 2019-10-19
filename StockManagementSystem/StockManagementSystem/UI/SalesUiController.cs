using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;

namespace StockManagementSystem.UI
{
    public partial class SalesUiController : UserControl
    {
        SalesManager _salesManager=new SalesManager();
        public SalesUiController()
        {
            InitializeComponent();
        }

        private void SalesUiController_Load(object sender, EventArgs e)
        {

        }
    }
}
