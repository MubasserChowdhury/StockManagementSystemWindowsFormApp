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
    public partial class SupplierUi : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier = new Supplier();

        public SupplierUi()
        {
            InitializeComponent();
        }

      

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier(this);
            if(showDataGridView.Columns[e.ColumnIndex].Name=="Edit")
            {
                addSupplier.saveButton.Text = "Update";

                addSupplier.id = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells[1].Value);
                addSupplier.codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                addSupplier.nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                addSupplier.addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                addSupplier.emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                addSupplier.contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                addSupplier.contactPersonTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

                addSupplier.Show();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Enter search value");
                return;
            }
            else if (nameRadioButton.Checked == true)
            {
                _supplier.Name = searchTextBox.Text;
                showDataGridView.DataSource = _supplierManager.SearchSupplier(searchTextBox.Text);
            }
            else if (emailRadioButton.Checked == true)
            {
                _supplier.Email = searchTextBox.Text;
                showDataGridView.DataSource = _supplierManager.SearchSupplierByEmail(searchTextBox.Text);

            }
            else if (contactRadioButton.Checked == true)
            {
                _supplier.Contact = searchTextBox.Text;
                showDataGridView.DataSource = _supplierManager.SearchSupplierByContact(searchTextBox.Text);

            }
            else
            {
                MessageBox.Show("Dtat Not Found");
            }
            


           
        }

        private void SupplierUi_Load(object sender, EventArgs e)
        {
            // GenerateProductCode();
            //RadioButton nameRadioButton = new RadioButton();
            //nameRadioButton.Appearance = Appearance.Button;
            //nameRadioButton.AutoCheck = true;
            //Controls.Add(nameRadioButton);

            ShowAllSupplier();
        }
        public void ShowAllSupplier()
        {
            showDataGridView.DataSource = _supplierManager.ShowSupplierInfo();
        }

      

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void addSupplierButton_Click_1(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier(this);
            addSupplier.ShowDialog();
          
           

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //AddSupplier addSupplier = new AddSupplier(this);
            //addSupplier.codeTextBox.Text="";
            //addSupplier.nameTextBox.Text = "";
            // addressTextBox.Text = "";
            // emailTextBox.Text = "";
            // contactTextBox.Text = "";
            //contactPersonTextBox.Text = "";
            //codeErrorLabel.Text = "";
            //nameErrorLabel.Text = "";
            //ContactErrorLabel.Text = "";
            //emailErrorLabel.Text = "";
            //ShowAllSupplier();
            //GenerateProductCode();
            //saveButton.Text = "Save";
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllSupplier();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
