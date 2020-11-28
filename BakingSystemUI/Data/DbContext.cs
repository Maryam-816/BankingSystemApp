using BakingSystemUI.Core;
using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Data
{
    public class DbContext
    {
        public  DbSet<User> Users;
        public  DbSet<Card> Cards;

        public DbContext()
        {
            Users = new DbSet<User>();
            Cards = new DbSet<Card>();
        }

        public void AddDefaultUsers()
        {
            Users.Add(new User { Id = Identificator<User>.GetId(), Email = "maryam@gmail.com", Password = "12345", UserType = Roles.UserType.Moderator });
            Users.Add(new User { Id = Identificator<User>.GetId(), Email = "admin@gmail.com", Password = "admin1", UserType = Roles.UserType.Admin });
            Users.Add(new User { Id = Identificator<User>.GetId(), Name = "Julia", Surname = "Rustamova", Age = 38, Email = "julia@gmail.com", Password = "J08101982A", UserType = Roles.UserType.User });

        }
    }
}
