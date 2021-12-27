using System.Data;
using System.Data.SqlClient;

namespace Design_Patterns.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            
            connection.ConnectionString = "User Id=name;Password=123456;Server=localhost;Database=DataBaseName";

            connection.Open();

            return connection;
        }
    }
}
