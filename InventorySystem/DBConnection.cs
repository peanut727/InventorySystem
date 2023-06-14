using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventorySystem
{
    internal class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\peanut\Documents\DealershipDB.mdf;Integrated Security=True;Connect Timeout=30;";
            return new SqlConnection(connectionString);
        }


    }
}
