using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Repository
{
    public class CategoryRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

    }
}
