 using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    public class SalesRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public bool AddSale(List<Sale> sales)
        {

            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            { //open connection
                sqlConnection.Open();
                foreach (var sale in sales)
                {
                    string queryString = @"INSERT INTO Sales VALUES(" + sale.CustomerId + "," + sale.ProductId + ",'" + sale.Code + "','" + sale.InvoiceNo + "','" + sale.Date + "'," + sale.Quantity + "," + sale.MRP + "," + sale.TotalMRP + ");";
                    SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);


                    int isExecuted = sqlCommand.ExecuteNonQuery();


                    if (isExecuted > 0)
                    {
                        isAdded = true;
                    }
                }
                //close connection
                sqlConnection.Close();

            }

            return isAdded;
        }

        public string GetLastSaleCode()
        {
            string code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Sales ORDER BY Id DESC ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    code = sqlDataReader["Code"].ToString();
                    break;
                }

                //close connection
                sqlConnection.Close();

            }

            return code;
        }

        public Sale GetLastSaleProductInfoById(int id)
        {
            Sale sale = new Sale();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM Sales WHERE Sales=" + id + " ORDER BY Id ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();


                while (sqlDataReader.Read())
                {

                    sale.Id = Convert.ToInt32(sqlDataReader["id"]);
                    sale.Date = sqlDataReader["Date"].ToString();
                    sale.InvoiceNo = sqlDataReader["InvoiceNo"].ToString();
                    sale.CustomerId = Convert.ToInt32(sqlDataReader["CustomerId"]);
                    sale.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                
                    sale.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);

                    sale.TotalMRP = Convert.ToDouble(sqlDataReader["TotalMRP"]);
                    sale.MRP = Convert.ToDouble(sqlDataReader["MRP"]);

                }

                //close connection
                sqlConnection.Close();
            }

            return sale;
        }

    }
}
