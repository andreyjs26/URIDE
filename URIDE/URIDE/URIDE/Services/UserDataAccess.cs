using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using URIDE.Models;

namespace URIDE.Services
{
    public class UserDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public ObservableCollection<User> Users { get; set; }

        public UserDataAccess()
        {
            database =
              DependencyService.Get<IDatabaseConnection>().
              DbConnection();
            database.CreateTable<User>();
            this.Users =
              new ObservableCollection<User>(database.Table<User>());
            // If the table is empty, initialize the collection
            if (!database.Table<User>().Any())
            {
                AddNewUser();
            }
        }

        public void AddNewUser()
        {
            this.Users.
              Add(new User
              {
                  name = "Andrey",
                  lastName = "Jaen",
                  email = "andrey260393@gmail.com",
                  password = "1234",
                  residence = "Guadalupe",
                  destination = "Desamparados",                  
                  entrance = new TimeSpan(6,0,0),
                  exit = new TimeSpan(6, 0, 0),
                  discapacity = false

              });
        }

        public IEnumerable<User> GetUsers()
        {
            lock (collisionLock)
            {
                var query = from user in database.Table<User>()                           
                            select user;
                return query.AsEnumerable();
            }
        }

        public User GetUserById(int id)
        {
            lock (collisionLock)
            {
                var query = from user in database.Table<User>()
                            where user.Id == id
                            select user;
                return query.FirstOrDefault();
            }
        }

        public User GetUserLogin(string email, string pass)
        {
            lock (collisionLock)
            {
                var query = from user in database.Table<User>()
                            where user.email == email && user.password == pass
                            select user;
                return query.FirstOrDefault();
            }
        }

        public int SaveUser(User user)
        {
            lock (collisionLock)
            {
                if (user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    database.Insert(user);
                    return user.Id;
                }
            }
        }

        public int DeleteUser(User user)
        {
            var id = user.Id;
            if (id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<User>(id);
                }
            }
            this.Users.Remove(user);
            return id;
        }

    }
}
