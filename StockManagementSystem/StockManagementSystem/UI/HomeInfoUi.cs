using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class HomeInfoUi : Form
    {
        public HomeInfoUi()
        {
            InitializeComponent();
        }

        private void HomeInfoUi_Load(object sender, EventArgs e)
        {
            messageLabel.Text = @"Stock Management System";
        }
    }
}
