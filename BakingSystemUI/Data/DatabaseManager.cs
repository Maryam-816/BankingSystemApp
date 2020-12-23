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

        private int IUD_command(string query, Action<SqlCommand> action)
        {
            int affectedRows = default;
            using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConn))
            {
                action(sqlCommand);
                affectedRows = sqlCommand.ExecuteNonQuery();
            }
            return 
        }

        public int AddCards(Card card)
        {

        }

        public int AddUser(User user)
        {
            return IUD_command("INSERT INTO Users(Name, Surname, Age, Email, Password, UserType) VALUES(@n, @s, @a, @e, @ps, @ut)", sqlCommand
            {
                sqlCommand.Parameters.AddWithValue("@n", user.Name);
                sqlCommand.Parameters.AddWithValue("@s", user.Surname);
                sqlCommand.Parameters.AddWithValue("@a", user.Age);
                sqlCommand.Parameters.AddWithValue("@e", user.Email);
                sqlCommand.Parameters.AddWithValue("@ps", user.Password);
                sqlCommand.Parameters.AddWithValue("@ut", user.UserType).ToString();
            });
        }

        public int UpdatedUser(User user)
        {
            return IUD_command("UPDATE Users SET Name=@n, Surname=@s, Age=@a, Password=@ps WHERE Id=@id", sqlCommand
            {
                sqlCommand.Parameters.AddWithValue("@n", user.Name);
                sqlCommand.Parameters.AddWithValue("@s", user.Surname);
                sqlCommand.Parameters.AddWithValue("@a", user.Age);
                sqlCommand.Parameters.AddWithValue("@ps", user.Password);
                sqlCommand.Parameters.AddWithValue("@id", user.Id);
            });
        }

        public int DeleteUser(User user)
        {
            return IUD_command("DELETE Users WHERE Id=@id", sqlCommand
            {
                sqlCommand.Parameters.AddWithValue("@id", user.Id);
            });
            
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
