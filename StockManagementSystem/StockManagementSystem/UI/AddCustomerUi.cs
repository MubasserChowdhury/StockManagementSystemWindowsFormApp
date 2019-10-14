using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;


using System.Windows.Forms;

namespace StockManagementSystem.UI
{
    public partial class AddCustomerUi : Form
    {

        CustomerManager _customerManager = new CustomerManager();
        Customer _customer = new Customer();

        public int customerId;
        private CustomerUi customerUi;
        public AddCustomerUi(CustomerUi customerUi2)
        {
            InitializeComponent();
           customerUi = customerUi2;
            GenerateProductCode();
        }

        private void AddCustomerUi_Load(object sender, EventArgs e)
        {
            CleareAllErrorLebel();
            



        }
        private void CleareAllErrorLebel()
        {
            codeErrorLabel.Text = "";
            nameErrorLabel.Text = "";
            addressErrorLabel.Text = "";
            emailErrorLabel.Text = "";
            contactErrorLabel.Text = "";
            loyaltyPointErrorLabel.Text = "";
            loyaltyPointTextBox.Text = "";
        }

        private void saveOrUpdateButton_Click(object sender, EventArgs e)
        {
            _customer.Id = customerId;
            _customer.Code = codeTextBox.Text;
            _customer.Name = nameTextBox.Text;
            _customer.Address = addressTextBox.Text;
            _customer.Email = emaiTextBox.Text;
            _customer.Contact = contactTextBox.Text;
           // _customer.LoyaltyPoint = Convert.ToDouble(loyaltyPointTextBox.Text);
          

            if (String.IsNullOrEmpty(_customer.Name))
            {
                nameErrorLabel.ForeColor = Color.Red;
                nameErrorLabel.Text = @"Name is required";
                nameTextBox.Focus();
                return;
            }


            if (String.IsNullOrEmpty(_customer.Email))
            {
                emailErrorLabel.ForeColor = Color.Red;
                emailErrorLabel.Text = @"Email is required !";
                emaiTextBox.Focus();
                return;
            }
            if (!String.IsNullOrEmpty(_customer.Contact) && _customer.Contact.Length != 11)
            {
                contactErrorLabel.ForeColor = Color.Red;
                contactErrorLabel.Text = @"Contact is 11 character length required !";
                contactTextBox.Focus();
                return;
            }
            if (String.IsNullOrEmpty(_customer.Contact))
            {
                contactErrorLabel.ForeColor = Color.Red;
                contactErrorLabel.Text = @"Contact is required !";
                contactTextBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(loyaltyPointTextBox.Text))
            {
                loyaltyPointErrorLabel.ForeColor = Color.Red;
                loyaltyPointErrorLabel.Text = @"Loyalty point is required !";
                loyaltyPointTextBox.Focus();
                return;
            }

            if (String.IsNullOrEmpty(_customer.Address))
            {
                addressErrorLabel.ForeColor = Color.Red;
                addressErrorLabel.Text = @"Address is required !";
                addressTextBox.Focus();
                return;
            }

            _customer.LoyaltyPoint = Convert.ToDouble(loyaltyPointTextBox.Text);

            if (saveOrUpdateButton.Text == @"Save")
            {
                if (_customerManager.AddCustomer(_customer))
                {
                    customerUi.ShowAllCustomer();
                    MessageBox.Show(@"Saved Successfully");
                    // customerDataGridView.DataSource = _customerManager.GetAllCustomer();
                 
                   
                    GenerateProductCode();
                }
                else
                {
                    MessageBox.Show(@"Save Failed");
                }
            }
            else
            {
                if (_customerManager.UpdateCustomer(_customer))
                {
                    customerUi.ShowAllCustomer();
                    MessageBox.Show(@"Updated Successfully");
                    //customerDataGridView.DataSource = _customerManager.GetAllCustomer();
               
                    saveOrUpdateButton.Text = "Save";
                  
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Update Failed");
                }

            }
            ClearAllTextBox();
            CleareAllErrorLebel();

        }

        private void ClearAllTextBox()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emaiTextBox.Clear();
            contactTextBox.Clear();
            loyaltyPointTextBox.Clear();

        }
        private void GenerateProductCode()
        {
            string lastProductCode = _customerManager.GetLastProductCode();

            if (lastProductCode == "")
            {
                lastProductCode = "0001";
            }
            else
            {
                int number = int.Parse(lastProductCode);
                lastProductCode = (++number).ToString("D" + lastProductCode.Length);

            }

            codeTextBox.Text = lastProductCode;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
   
    
}
