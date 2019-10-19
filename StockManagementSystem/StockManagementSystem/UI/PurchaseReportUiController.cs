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
    public partial class PurchaseReportUiController : UserControl
    {
        SharedManager _sharedManager=new SharedManager();
        public PurchaseReportUiController()
        {
            InitializeComponent();
        }

        private void PurchaseReportUiController_Load(object sender, EventArgs e)
        {
            purchaseReportDataGridView.DataSource = _sharedManager.GetPurchaseReport();
        }

        private void purchaseReportDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            purchaseReportDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
