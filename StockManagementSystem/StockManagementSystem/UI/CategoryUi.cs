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

namespace StockManagementSystem.UI
{
    public partial class CategoryUi : Form
    {
        CategoryManager _categoryManager=new CategoryManager();
        public CategoryUi()
        {
            InitializeComponent();
        }
    }
}
