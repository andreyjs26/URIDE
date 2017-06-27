using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite;
using System.IO;
using URIDE.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_iOS))]
namespace URIDE.iOS
{
   public class DatabaseConnection_iOS
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "URIDEDb.db3";
            string personalFolder =
              System.Environment.
              GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder =
              Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}