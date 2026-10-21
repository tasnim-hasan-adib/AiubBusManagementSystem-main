using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 

namespace AiubBusManagementSystem.Utils
{
    internal class DbConnection
    {
        private static readonly string connectionString =
           @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AiubBusDB;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
