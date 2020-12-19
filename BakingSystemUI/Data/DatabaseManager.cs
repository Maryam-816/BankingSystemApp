using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using BakingSystemUI.Models;

namespace BakingSystemUI.Data
{
    public class DatabaseManager : IDisposable
    {
        private readonly SqlConnection _sqlConn;

        public DatabaseManager(string stringConn)
        {
            string connectString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            _sqlConn = new SqlConnection(connectString);
            _sqlConn.Open();
        }

        public void Dispose()
        {
            _sqlConn.Dispose();
        }

        public IEnumerable<User> GetUsers()
        {
            List<User> users = new List<User>();
            string command = "SELECT Id, Name, Surname, Age, Email, Password FROM Users";
            using (SqlCommand sqlCommand = new SqlCommand(command))
            {
                sqlCommand.Connection = _sqlConn;
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        users.Add(new User
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Name = sqlDataReader["Name"].ToString(),
                            Surname = sqlDataReader["Surname"].ToString(),
                            Age = Convert.ToByte(sqlDataReader["Age"]),
                            Email = sqlDataReader["Email"].ToString(),
                            Password = sqlDataReader["Password"].ToString(),
                        });
                    }
                }
            }
            return users;
        }
    }
}
