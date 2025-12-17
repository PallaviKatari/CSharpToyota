using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// ADO.NET - ActiveX Data Objects for .NET
    /// ADO.NET is a set of classes that expose data access services for .NET Framework programmers
    /// Set of classes - System.Data namespace - to interact with data sources - databases,XML files,web services
    /// SqlClient - SQL Server database
    /// SqlDataReader - read data in a forward-only, read-only manner
    /// SqlConnection - establish a connection to the database
    /// SqlCommand - execute SQL queries and commands
    /// SqlDataAdapter - bridge between a DataSet and SQL Server for retrieving and saving data
    /// DataSet - in-memory representation of data
    /// </summary>
    class AdoDemo
    {
        static void Main()
        {
            // Define your connection string (update with your server, database, credentials)
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Toyota;Integrated Security=True;";
            // For SQL Server Authentication, use:
            // string connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User Id=your_username;Password=your_password;";

            // Define your SQL query
            string query = "SELECT TOP (1000) [EmpID],[EmpName],[Designation],[ManagerId] FROM [Toyota].[dbo].[EmpManager]";

            // Create connection and command objects
            //using statements ensure proper disposal of resources - deallocation of memory of the database objects
            //using is same as try-finally block with Dispose method in finally block
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // Execute the query
                    // ExcecuteReader - for SELECT queries
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Read data
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0); // EmployeeID
                            string name = reader.GetString(1);
                            string designation = reader.GetString(1);
                            int mid = reader.GetInt32(0);

                            Console.WriteLine($"ID: {id}, Name: {name}, Designation: {designation}, ManagerId: {mid}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

//Notes:
//Replace YOUR_SERVER_NAME and YOUR_DATABASE_NAME with your actual SQL Server details.
//If using SQL Server Authentication, update the connection string accordingly.
//Make sure your database has an Employees table with the specified columns, or update the query/columns as needed.
