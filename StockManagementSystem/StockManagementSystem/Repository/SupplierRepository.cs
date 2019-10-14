using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using StockManagementSystem.Model;
using StockManagementSystem.Manager;

namespace StockManagementSystem.Repository
{
   public class SupplierRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        //Save Supplier Info
        public bool AddSupplier(Supplier supplier)
        {
            bool isAdded = false;

            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))          
            {
                string commandString = @"INSERT INTO Suppliers Values ('" + supplier.Code + "','" + supplier.Name + "'," +
                      " + '" + supplier.Address + "','" + supplier.Email + "', '" + supplier.Contact + "','" + supplier.ContactPerson + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                sqlConnection.Close();

            }
        
            return isAdded;

        }
        //Update Method
        public bool UpdateSupplier(Supplier supplier)
        {
            bool exists = false;

            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                //Command 
                string commandString = @"UPDATE Suppliers SET Code = '" + supplier.Code + "',Name= '" + supplier.Name + "',Address = '" + supplier.Address + "',Email='" + supplier.Email + "'," +
                    "Contact= '" + supplier.Contact + "',ContactPerson='" + supplier.ContactPerson + "'  WHERE ID = " + supplier.Id + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Update
                int id = sqlCommand.ExecuteNonQuery();
                if (id > 0)
                {
                    exists = true;
                }

                //Close
                sqlConnection.Close();

            }
            return exists;
        }
        //Name Search 
        public List<Supplier> SearchSupplier(string Name)
        {
            List<Supplier> suppliers = new List<Supplier>();
            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                //Command 
                string commandString = @"SELECT * FROM Suppliers  WHERE Name = '" + Name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    supplier.Code = sqlDataReader["Code"].ToString();
                    supplier.Name = sqlDataReader["Name"].ToString();
                    supplier.Address = sqlDataReader["Address"].ToString();
                    supplier.Email = sqlDataReader["Email"].ToString();
                    supplier.Contact = sqlDataReader["Contact"].ToString();
                    supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();
                    suppliers.Add(supplier);
                }
                //Close
                sqlConnection.Close();
            }
            return suppliers;
        }
        //Email Search 
        public List<Supplier> SearchSupplierByEmail(string Email)
        {
            List<Supplier> suppliers = new List<Supplier>();
            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                //Command 
                string commandString = @"SELECT * FROM Suppliers  WHERE Email = '" + Email + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    supplier.Code = sqlDataReader["Code"].ToString();
                    supplier.Name = sqlDataReader["Name"].ToString();
                    supplier.Address = sqlDataReader["Address"].ToString();
                    supplier.Email = sqlDataReader["Email"].ToString();
                    supplier.Contact = sqlDataReader["Contact"].ToString();
                    supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();
                    suppliers.Add(supplier);
                }
                //Close
                sqlConnection.Close();
            }
            return suppliers;
        }
        //Contact Search 
        public List<Supplier> SearchSupplierByContact(string Contact)
        {
            List<Supplier> suppliers = new List<Supplier>();
            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                //Command 
                string commandString = @"SELECT * FROM Suppliers  WHERE Contact = '" + Contact + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Supplier supplier = new Supplier();
                    supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    supplier.Code = sqlDataReader["Code"].ToString();
                    supplier.Name = sqlDataReader["Name"].ToString();
                    supplier.Address = sqlDataReader["Address"].ToString();
                    supplier.Email = sqlDataReader["Email"].ToString();
                    supplier.Contact = sqlDataReader["Contact"].ToString();
                    supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();
                    suppliers.Add(supplier);
                }
                //Close
                sqlConnection.Close();
            }
            return suppliers;
        }
        //Show Method
        public List<Supplier> ShowSupplierInfo()
        {
            List<Supplier> suppliers = new List<Supplier>();
            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                string commandString = @"SELECT * FROM Suppliers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    Supplier supplier = new Supplier();
                    supplier.Id = Convert.ToInt32(sqlDataReader["Id"]);
                    supplier.Code = sqlDataReader["Code"].ToString();
                    supplier.Name = sqlDataReader["Name"].ToString();
                    supplier.Address = sqlDataReader["Address"].ToString();
                    supplier.Email = sqlDataReader["Email"].ToString();
                    supplier.Contact = sqlDataReader["Contact"].ToString();
                    supplier.ContactPerson = sqlDataReader["ContactPerson"].ToString();
                    suppliers.Add(supplier);

                }
                //Close
                sqlConnection.Close();
            }
            return suppliers;
        }
        //Unique Contact
        public bool UniqueContact(Supplier supplier)
        {
            bool exists = false;

            //Connection

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                //Command 
                string commandString = @"SELECT * FROM Suppliers  WHERE Contact = '" + supplier.Contact + "'  AND Id !=" + supplier.Id + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                sqlConnection.Close();
            }
            return exists;
        }
        //Unique Email
        public bool UniqueEmail(Supplier supplier)
        {
            bool exists = false;

            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {

                //Command 
                string commandString = @"SELECT * FROM Suppliers  WHERE Email = '" + supplier.Email + "'  AND Id !=" + supplier.Id + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //showDataGridView.DataSource = dataTable;

                //Close
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                sqlConnection.Close();
            }
           
            return exists;
        }
        //Auto Code Generator
        public string GetLastProductCode()
        {
            string code = "";
            //Connection
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))

                 {
                string queryString = @"SELECT Code FROM Suppliers ORDER BY Id DESC ";
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
