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
    public class CustomerRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public bool AddCustomer(Customer customer)
        {
            bool isAdded = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"INSERT INTO Customers VALUES('" + customer.Code + "','" + customer.Name + "','" + customer.Address + "','" + customer.Email + "','" + customer.Contact + "',"+customer.LoyaltyPoint+")";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isAdded = true;
                }
            }

            return isAdded;
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool isUpdated = false;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"UPDATE Customers SET Code='" + customer.Code + "',Name='" + customer.Name + "',Address='" + customer.Address + "',Email='" + customer.Email + "',Contact='" + customer.Contact + "',LoyaltyPoint=" + customer.LoyaltyPoint + " WHERE Id="+customer.Id+" ";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                //close connection
                sqlConnection.Close();

                if (isExecuted > 0)
                {
                    isUpdated = true;
                }
            }

            return isUpdated;
        }
        public bool UniqueCode(Customer customer)
        {
            string isFound = "";

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Customers WHERE Code='" + customer.Code + "' AND Id != " + customer.Id + " ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    isFound = sqlDataReader["Code"].ToString();

                }

                //close connection
                sqlConnection.Close();

                if (String.IsNullOrEmpty(isFound))
                {
                    return false;
                }
            }

            return true;
        }
        public List<Customer> GetAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT * FROM Customers";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                   Customer customer=new Customer();

                   customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                   customer.Code = sqlDataReader["Code"].ToString();
                   customer.Name = sqlDataReader["Name"].ToString();
                   customer.Address = sqlDataReader["Address"].ToString();
                   customer.Email = sqlDataReader["Email"].ToString();
                   customer.Contact = sqlDataReader["Contact"].ToString();
                   customer.LoyaltyPoint =Convert.ToInt32(sqlDataReader["LoyaltyPoint"]);
                   customers.Add(customer);

                }

                //close connection
                sqlConnection.Close();

                return customers;
            }
        }

        public List<Customer> GetAllCustomerForComboBox()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Id,Name FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                Customer customer1 = new Customer()
                {
                    Id = 0,
                    Name = "--Select--"
                };
                customers.Add(customer1);

                while (sqlDataReader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    customer.Name = sqlDataReader["Name"].ToString();
                    customers.Add(customer);
                }
            }

            return customers;

        }

        public double GetCustomerLoyaltyPointById(int id)
        {
            double point = 0;

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT LoyaltyPoint FROM Customers WHERE  Id = " + id + " ";
                SqlCommand sqlCmd = new SqlCommand(queryString, sqlConnection);

                //open connection
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    point =Convert.ToDouble(sqlDataReader["LoyaltyPoint"]);

                }

                //close connection
                sqlConnection.Close();
            }

            return point;
        }
        public string GetLastProductCode()
        {
            string code = "";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string queryString = @"SELECT Code FROM Customers ORDER BY Id DESC ";
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
    }
}
