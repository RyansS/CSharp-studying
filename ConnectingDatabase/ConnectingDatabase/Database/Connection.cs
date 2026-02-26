using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingDatabase.Database
{
    internal class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial" +
            " Catalog=TestingDatabase;Integrated Security=" +
            "True;Connect Timeout=30;Encrypt=False;Trus" +
            "t Server Certificate=False;Application Intent" +
            "=ReadWrite;Multi Subnet Failover=False";

        public SqlConnection openConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
