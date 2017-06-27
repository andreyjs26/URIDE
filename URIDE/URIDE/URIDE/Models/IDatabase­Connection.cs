using System;
using System.Collections.Generic;
using System.Text;

namespace URIDE.Models
{  
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }    
}
