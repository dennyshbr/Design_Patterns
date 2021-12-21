using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            
            connection.ConnectionString = "User Id=dennysr;Password=123456;Server=localhost;Database=meuBanco";

            connection.Open();

            return connection;
        }
    }
}
