using StockManagementSystem.Manager;
using StockManagementSystem.Model;
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
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        Customer _customer = new Customer();
        public CustomerUi()
        {
            InitializeComponent();
        }
        private void CustomerUi_Load(object sender, EventArgs e)
        {

            ShowAllCustomer();
        }
        public void ShowAllCustomer()
        {
            customerDataGridView.DataSource = _customerManager.GetAllCustomer();

        }
        private void customerDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.customerDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCustomerUi addCustomerUi = new AddCustomerUi(this);
            if (customerDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                       
                        if (customerDataGridView.CurrentRow != null) customerDataGridView.CurrentRow.Selected = true;

                        addCustomerUi.customerId = Convert.ToInt32(customerDataGridView.Rows[e.RowIndex].Cells[1].Value);
                        addCustomerUi.codeTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        addCustomerUi.nameTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        addCustomerUi.addressTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                        addCustomerUi.emaiTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                        addCustomerUi.contactTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                        addCustomerUi.loyaltyPointTextBox.Text = customerDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                        addCustomerUi.saveOrUpdateButton.Text = @"Update";
                        //MessageBox.Show(addCustomerUi.codeTextBox.Text);
                        addCustomerUi.Show();
                        

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerUi addCustomerUi = new AddCustomerUi(this);

            addCustomerUi.Show();

        }
    }
}
