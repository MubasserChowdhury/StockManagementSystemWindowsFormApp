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

namespace StockManagementSystem.UI
{
    public partial class CategoryUi : Form
    {
        readonly CategoryManager _categoryManager=new CategoryManager();
        Category _category = new Category();

        public CategoryUi()
        {
            InitializeComponent();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryUi addCategoryUi=new AddCategoryUi(this);
            addCategoryUi.ShowDialog();
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCategoryUi addCategoryUi = new AddCategoryUi(this);
            addCategoryUi.ClearAllText();
            if (categoryDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {

                try
                {
                    if (e.RowIndex >= 0)
                    {
                        if (categoryDataGridView.CurrentRow != null) categoryDataGridView.CurrentRow.Selected = true;

                        //_category.Id = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[1].Value);
                        addCategoryUi.categoryId = Convert.ToInt32(categoryDataGridView.Rows[e.RowIndex].Cells[1].Value);
                        addCategoryUi.codeTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                        addCategoryUi.nameTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                        MessageBox.Show(addCategoryUi.codeTextBox.Text + "");
                        addCategoryUi.saveOrUpdateButton.Text = @"Update";
                        addCategoryUi.ShowDialog();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void CategoryUi_Load(object sender, EventArgs e)
        {
            nameRadioButton.Checked = true;


            ShowAllCategory();
            //addCategoryButton.Visible = true;
        }

        private void categoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //categoryDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        public void ShowAllCategory()
        {
            categoryDataGridView.DataSource = _categoryManager.GetAllCategory();
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show("search box   Can not be Empty!!!");
                return;
            }

           // if (nameRadioButton.Checked == true)
            //{
                _category.Name = searchTextBox.Text;
                categoryDataGridView.DataSource = _categoryManager.Search(_category);
           // }
           // else 
                if (codeRadioButton.Checked == true)
            {
                _category.Code = searchTextBox.Text;
                categoryDataGridView.DataSource = _categoryManager.SearchCode(_category);
            }      

        }




    }
}
