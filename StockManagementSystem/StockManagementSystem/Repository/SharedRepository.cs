using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    public class SharedRepository
    {
        string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public List<PurchaseReportViewModel> GetPurchaseReport()
        {
            List<PurchaseReportViewModel> purchaseReportViewModels = new List<PurchaseReportViewModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Code AS Code,p.Name AS Name ,c.Name AS Category,SUM(pur.Quantity) AS AvailableQty,SUM(pur.TotalPrice) AS CP ,SUM(MRP*pur.Quantity) AS MRP,SUM(MRP*pur.Quantity-pur.TotalPrice) AS Profit 
 FROM Purchases AS pur LEFT JOIN Products AS p ON p.Id=pur.ProductId 
 LEFT JOIN Categories AS c ON p.CategoryId=c.Id GROUP BY p.Code,p.Name,c.Name ORDER BY p.Code";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    PurchaseReportViewModel model = new PurchaseReportViewModel();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Name = sqlDataReader["Name"].ToString();
                    model.Category= sqlDataReader["Category"].ToString();
                    model.AvailableQty = Convert.ToInt32(sqlDataReader["AvailableQty"]);
                    model.CP = Convert.ToDouble(sqlDataReader["CP"]);
                    model.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                    model.Profit = Convert.ToDouble(sqlDataReader["Profit"]);
                    purchaseReportViewModels.Add(model);
                }
            }

            return purchaseReportViewModels;

        }
        public List<PurchaseReportViewModel> SearchPurchaseReportByDate(string startDate, string endDate)
        {
            List<PurchaseReportViewModel> purchaseReportViewModels = new List<PurchaseReportViewModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT p.Code AS Code,p.Name AS Name ,c.Name AS Category,SUM(pur.Quantity) AS AvailableQty,SUM(pur.TotalPrice) AS CP ,SUM(MRP*pur.Quantity) AS MRP,SUM(MRP*pur.Quantity-pur.TotalPrice) AS Profit 
 FROM Purchases AS pur LEFT JOIN Products AS p ON p.Id=pur.ProductId 
 LEFT JOIN Categories AS c ON p.CategoryId=c.Id WHERE pur.Date BETWEEN '"+startDate+"' AND '"+endDate+"'  GROUP BY p.Code,p.Name,c.Name ORDER BY p.Code";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    PurchaseReportViewModel model = new PurchaseReportViewModel();
                    model.Code = sqlDataReader["Code"].ToString();
                    model.Name = sqlDataReader["Name"].ToString();
                    model.Category = sqlDataReader["Category"].ToString();
                    model.AvailableQty = Convert.ToInt32(sqlDataReader["AvailableQty"]);
                    model.CP = Convert.ToDouble(sqlDataReader["CP"]);
                    model.MRP = Convert.ToDouble(sqlDataReader["MRP"]);
                    model.Profit = Convert.ToDouble(sqlDataReader["Profit"]);
                    purchaseReportViewModels.Add(model);
                }
            }

            return purchaseReportViewModels;

        }
    }
}
