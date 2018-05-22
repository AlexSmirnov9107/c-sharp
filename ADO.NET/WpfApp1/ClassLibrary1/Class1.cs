using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DomainModel;

namespace ClassLibrary1
{
    public class Class1
    {
        private SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = "Data Source=WIN-IPC866TOF41;Initial Catalog=DB_171;Integrated Security=SSPI;MultipleActiveResultSets=True;";
            connection.ConnectionString = connectionString;
            return connection;
        }
        public void CreateDeveloper(Developer developer)
        {
            using (SqlConnection connection = CreateConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "";
            }
        }
    }
}
