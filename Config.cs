using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_JuanHernandez
{
    public class Config
    {
        // Fields for configuration settings
        public static string connectionString;

        // Update Config Information

        public static void UpdateConnectionString(string server, string database, string userName, string password)
        {
            string driver = "Driver={SQL Server Native Client 11.0};";
            string serv = $"Server={server};";
            string db = $"Database={database};";
            string userId = $"Uid={userName};";
            string pass = $"Pwd={password}";

            connectionString = $"{driver}{serv}{db}{userId}{pass}";
        }
    }
}
