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
using StockManagementSystem.Model;

namespace StockManagementSystem.UI
{
    public partial class SalesUiController : UserControl
    {
        CategoryManager _categoryManager = new CategoryManager();
        ProductManager _productManager = new ProductManager();
        SalesManager _salesManager=new SalesManager();
        CustomerManager _customerManager = new CustomerManager();
        public List<Sale> _sales = new List<Sale>();

        public SalesUiController()
        {
            InitializeComponent();

            //ClearAllErrorLabel();
            codeTextBox.Text = GenerateSaleCodeBeforeSubmit();

            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DataSource = _categoryManager.GetAllCategoryForComboBox();

            customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerComboBox.DataSource = _customerManager.GetAllCustomerForComboBox();
        }
       


        private void SalesUiController_Load(object sender, EventArgs e)
        {
            ClearAllErrorLabel();
        }

       

        public void ShowAllSales()
        {
            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = _sales;
        }

        private void salesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (salesDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                MessageBox.Show("edit");

                try
                {
                    if (e.RowIndex >= 0)
                    {
                        if (salesDataGridView.CurrentRow != null) salesDataGridView.CurrentRow.Selected = true;

                        //id
                        saleDateTimePicker.Text = salesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        billNoTextBox.Text = salesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                        customerComboBox.SelectedValue = Convert.ToInt32(salesDataGridView.Rows[e.RowIndex].Cells[4].Value);

                        //product id
                        int id = Convert.ToInt32(salesDataGridView.Rows[e.RowIndex].Cells[5].Value);

                        //get category id by product id
                        int catId = _categoryManager.GetCategoryIdByProductId(id);

                        //set value to category combobox
                        categoryComboBox.SelectedValue = catId;

                        //set value to product combobox
                        productComboBox.SelectedValue = id;


                        codeTextBox.Text = salesDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                        textBox1.Text = salesDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                        mrpTextBox.Text = salesDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                        totalMrpTextBox.Text = salesDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

                        //MessageBox.Show(Sl + "");


                        addSaleButton.Text = @"Update";

                        //Show();
                        ShowAllSales();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            if (salesDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show(@"Are you sure, you want to delete this record?", @"Message Box", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    codeTextBox.Text = salesDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    int index = 0;
                    Sale sale1 = new Sale();

                    foreach (var itemSale in _sales)
                    {

                        if (itemSale.Code == codeTextBox.Text)
                        {
                            sale1 = _sales.ElementAt(index);
                            break;
                        }
                        index++;

                    }
                    _sales.Remove(sale1);
                    salesDataGridView.DataSource = null;
                    salesDataGridView.DataSource = _sales;

                    

                    // get next purchase code
                    GenerateSaleCodeBeforeSubmit();
                }


            }
        
    }

        public string GenerateSaleCodeBeforeSubmit()
        {
            if (_sales.Count > 0)
            {
                Sale ph = new Sale();
                ph = _sales.ElementAt(_sales.Count - 1);
                return GenerateSaleCode(ph.Code);
            }
            else
            {
                return GenerateSaleCode(_salesManager.GetLastSaleCode());
            }
        }

        private string GenerateSaleCode(string lastSaleCode)
        {
            string code = "";

            string year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();
            if (lastSaleCode == "")
            {
                code = year + "-0001";
            }
            else
            {
                string[] afterSplit = lastSaleCode.Split('-');

                string serialNo = afterSplit[afterSplit.Length - 1];
                int number = int.Parse(serialNo);
                code = year + "-" + (++number).ToString("D" + serialNo.Length);
            }
            
            return code;

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryComboBoxErrorLabel.Text = "";
            int categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.DataSource = _productManager.GetAllProductForComboBox(categoryId);
        }

        private void productComboBox_TextUpdate(object sender, EventArgs e)
        {

        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productComboBox.SelectedValue);
            Sale sale = new Sale();




        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loyaltyPointTextBox.Text = _customerManager.GetCustomerLoyaltyPointById(Convert.ToInt32(customerComboBox.SelectedValue)).ToString();
        }

        private void totalMrpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mrpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.InvoiceNo = billNoTextBox.Text;


            if (addSaleButton.Text == @"Add")
            {
                sale.Date = saleDateTimePicker.Text;
                sale.InvoiceNo = billNoTextBox.Text;
                sale.Code = codeTextBox.Text;
                sale.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
                sale.ProductId = Convert.ToInt32(productComboBox.SelectedValue);
                sale.Product = productComboBox.Text;
                sale.Quantity = Convert.ToInt32(textBox1.Text);
                sale.MRP = Convert.ToDouble(mrpTextBox.Text);
                //sale.TotalMRP = Convert.ToDouble(totalMrpTextBox.Text);
                sale.TotalMRP = 11;
                _sales.Add(sale);
                ShowAllSales();
            }
            if (addSaleButton.Text==@"Update")
            {
                int index = 0;
                foreach (var itemSale in _sales)
                {

                    if (itemSale.Code == codeTextBox.Text)
                    {
                        sale = _sales.ElementAt(index);
                        break;
                    }
                    index++;

                }

                sale.Date = saleDateTimePicker.Text;
                sale.InvoiceNo = billNoTextBox.Text;
                sale.Code = codeTextBox.Text;
                sale.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
                sale.ProductId = Convert.ToInt32(productComboBox.SelectedValue);
                sale.Quantity = Convert.ToInt32(textBox1.Text);
                sale.MRP = Convert.ToDouble(mrpTextBox.Text);
                //sale.TotalMRP = Convert.ToDouble(totalMrpTextBox.Text);


                MessageBox.Show(@"Updated successfully");
                addSaleButton.Text = @"Add";
                
            }
            ClearAllTextBox();
            ShowAllSales();
        }

        public void ClearAllErrorLabel()
        {

            invoiceNoErrorLabel.Text = "";
            customerComboBoxErrorLabel.Text = "";
            productComboBoxErrorLabel.Text = "";
            quatityErrorLabel.Text = "";
            categoryComboBoxErrorLabel.Text = "";
            mrpErrorLabel.Text = "";
        }

        public void ClearAllTextBox()
        {
            saleDateTimePicker.CustomFormat = "yyyy-MM-dd";
            billNoTextBox.Clear();
            customerComboBox.SelectedValue = 0;
            categoryComboBox.SelectedValue = 0;
            productComboBox.SelectedValue = 0;
            codeTextBox.Clear();
            availableQuantityTextBox.Clear();
            textBox1.Clear();
            totalMrpTextBox.Clear();
            availableQuantityTextBox.Clear();
            mrpTextBox.Clear();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(@"Are you sure, you want to submit and save all this record?", @"Message Box", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (_salesManager.AddSale(_sales))
                    {

                        salesDataGridView.DataSource = null;
                        MessageBox.Show(@"Saved SuccessFully", @"Message Box", MessageBoxButtons.OK);
                        _sales.Clear();
                        //get next purchase code
                        GenerateSaleCodeBeforeSubmit();
                    }
                    else
                    {
                        MessageBox.Show(@"Not saved", @"Message Box", MessageBoxButtons.OK);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }
    }
}
