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
    public class DataAccess
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
                AddNewCustomer();
            }
        }

        public void AddNewCustomer()
        {
            this.Users.
              Add(new User
              {
                  CompanyName = "Company name...",
                  PhysicalAddress = "Address...",
                  Country = "Country..."
              });
        }
    }
}
