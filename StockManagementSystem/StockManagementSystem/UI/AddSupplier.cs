using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Manager;
using StockManagementSystem.Model;
using System.Text.RegularExpressions;

namespace StockManagementSystem.UI
{
    public partial class AddSupplier : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier = new Supplier();
        SupplierUi supplierUi = new SupplierUi();
        public int id;
        string pattern;

        public AddSupplier(SupplierUi supplierUi2)
        {
            supplierUi = supplierUi2;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to exit?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            _supplier.Id = id;
            if (nameTextBox.Text == "UserName")
            {
                nameErrorLabel.Text = @"Name Requred!!";
                nameErrorLabel.ForeColor = Color.Red;
                return;  
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                nameErrorLabel.Text = @"Name Requred!!";
                nameErrorLabel.ForeColor = Color.Red;
                return;
            }
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = @"Email Requred!!";
                emailErrorLabel.ForeColor = Color.Red;
                return;
            }
            if (emailTextBox.Text=="Email")
            {
                emailErrorLabel.Text = @"Email Requred!!";
                emailErrorLabel.ForeColor = Color.Red;
                return;
            }
             if (_supplierManager.UniqueEmail(_supplier))
            {
                emailErrorLabel.Text = @"Email already exits.";
                emailErrorLabel.ForeColor = Color.Red;
                return;
            }
            if (contactTextBox.Text=="Contact")
            {
                ContactErrorLabel.Text = @"Contact Requred!!";
                ContactErrorLabel.ForeColor = Color.Red;
                return;
            }
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                ContactErrorLabel.Text = @"Contact Requred!!";
                ContactErrorLabel.ForeColor = Color.Red;
                return;
            }
             if (contactTextBox.Text.Length != 11)
            {
                ContactErrorLabel.Text = @"Length Must Be 11.";
                ContactErrorLabel.ForeColor = Color.Red;
                return;
            }
             if (_supplierManager.UniqueContact(_supplier))
            {
                ContactErrorLabel.Text = @"Contact already exits.";
                ContactErrorLabel.ForeColor = Color.Red;
                return;
            }
            if (contactPersonTextBox.Text == "ContactPerson")
            {
                contactErr.Text = @"Contact Person Required!!";
                contactErr.ForeColor = Color.Red;
                return;
            }
            if (contactPersonTextBox.Text.Length != 11)
            {
                contactErr.Text = @"length must be 11.";
                contactErr.ForeColor = Color.Red;
                return;
            }

            _supplier.Code = codeTextBox.Text;
                _supplier.Name = nameTextBox.Text;
                _supplier.Address = addressTextBox.Text;
                _supplier.Email = emailTextBox.Text;
                _supplier.Contact = contactTextBox.Text;
                _supplier.ContactPerson = contactPersonTextBox.Text;




                if (saveButton.Text == "Save")
                {
                    if (_supplierManager.AddSupplier(_supplier))
                    {
                        MessageBox.Show("Saved");
                        //showDataGridView.DataSource = _supplierManager.ShowSupplierInfo();
                        supplierUi.ShowAllSupplier();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                }
                else
                {
                    if (_supplierManager.UpdateSupplier(_supplier))
                    {
                        saveButton.Text = "Save";
                        MessageBox.Show("Updated");
                        codeTextBox.Enabled = true;
                        codeTextBox.Text = "";
                        nameTextBox.Text = "";
                        addressTextBox.Text = "";
                        emailTextBox.Text = "";
                        contactTextBox.Text = "";
                        contactPersonTextBox.Text = "";
                        // showDataGridView.DataSource = _supplierManager.ShowSupplierInfo();
                        supplierUi.ShowAllSupplier();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Not updated");
                    }
                }
                GenerateProductCode();

            }
        

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            GenerateProductCode();
            contactErr.Text = "";
            nameErrorLabel.Text = "";
            ContactErrorLabel.Text = "";
            emailErrorLabel.Text = "";
        }
        private void GenerateProductCode()
        {
            string lastProductCode = _supplierManager.GetLastProductCode();

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

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            nameErrorLabel.Text = "";
        }

        private void contactTextBox_Leave(object sender, EventArgs e)
        {
            ContactErrorLabel.Text = "";
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            emailErrorLabel.Text = "";
        }
        private void contactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {

                e.Handled = true;

                ContactErrorLabel.Text = @"Only numeric value !";
                ContactErrorLabel.ForeColor = Color.Red;
                return;
            }
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            nameTextBox.ForeColor = Color.Black;
        }

        private void contactPersonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {

                e.Handled = true;

                contactErr.Text = @"Only numeric value !";
                contactErr.ForeColor = Color.Red;
                return;
            }
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = "";
            addressTextBox.ForeColor = Color.Black;
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = "";
            emailTextBox.ForeColor = Color.Black;
        }

        private void contactTextBox_Click(object sender, EventArgs e)
        {
            contactTextBox.Text = "";
            contactTextBox.ForeColor = Color.Black;
        }

        private void contactPersonTextBox_Click(object sender, EventArgs e)
        {
            contactPersonTextBox.Text = "";
            contactPersonTextBox.ForeColor = Color.Black;
        }

        private void emailTextBox_Leave_1(object sender, EventArgs e)
        {
             pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if(Regex.IsMatch(emailTextBox.Text, pattern))
            {
                emailErrorLabel.Text = "";
            }
            else
            {
                emailErrorLabel.Text = @"Enter Valid Email!!";
                emailErrorLabel.ForeColor = Color.Red;
                return;
            }
        }
    }
    }

