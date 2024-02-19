using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_JuanHernandez
{
    internal class ItemDatabase
    {
        internal class Database
        {
            List<Car> tempData = new List<Car>();

            static Database _instance = null;

            private Database(ConnectionStringParser csp)
            {
                PopulateData(csp.Database);
            }

            public static Database ConnectToDatabase(string connectionString)
            {
                ConnectionStringParser csp = new ConnectionStringParser(connectionString);

                if (!csp.IsValid())
                {
                    Console.WriteLine("The Connection String you entered was invalid. Check all of your arguments");
                    return null;
                }

                if (!ValidateInfo(csp)) return null;

                if (_instance == null)
                {
                    _instance = new Database(csp);
                }

                return _instance;
            }

            private void PopulateData(string database)
            {
                Random rand = new Random();
                double randPrice = rand.Next(5000,75000);
                int randMiles = rand.Next(1, 99000);

                if (database == "Ford")
                {
                    tempData = new List<Car>
                    {
                    new Fiat("Fiat", "500", randPrice, randMiles),
                    new Ford("Ford", "Focus", randPrice, randMiles),
                    new Honda("Honda","Integra", randPrice, randMiles),
                    new Fiat("Fiat", "500L", randPrice, randMiles),
                    new Ford("Ford", "Mustang", randPrice, randMiles),
                    new Honda("Honda","City", randPrice, randMiles),
                    new Fiat("Fiat", "Tipo", randPrice, randMiles),
                    new Ford("Ford", "Bronco", randPrice, randMiles),
                    new Honda("Honda","Brio", randPrice, randMiles),
                    };
                }
                else
                {
                    tempData = new List<Car> {
                    new Fiat("Fiat", "Spider", randPrice, randMiles),
                    new Ford("Ford", "Raptor", randPrice, randMiles),
                    new Honda("Honda","Civic", randPrice, randMiles),
                    new Fiat("Fiat", "500C", randPrice, randMiles),
                    new Ford("Ford", "F150", randPrice, randMiles),
                    new Honda("Honda","Accord", randPrice, randMiles),
                    new Fiat("Fiat", "500X", randPrice, randMiles),
                    new Ford("Ford", "Escape", randPrice, randMiles),
                    new Honda("Honda","CRV", randPrice, randMiles),
                    new Fiat("Fiat", "Panda", randPrice, randMiles),
                    new Ford("Ford", "Explorer", randPrice, randMiles),
                    new Honda("Honda","Pilot", randPrice, randMiles),
                    new Fiat("Fiat", "Doblo", randPrice, randMiles),
                    new Ford("Ford", "Transit", randPrice, randMiles),
                    new Honda("Honda","Type-R", randPrice, randMiles),
                    new Fiat("Fiat", "Abarth", randPrice, randMiles),
                    new Ford("Ford", "Edge", randPrice, randMiles),
                    new Honda("Honda","Odyssey", randPrice, randMiles),
                    };
                }
            }

            private static bool ValidateInfo(ConnectionStringParser csp)
            {
                if (csp.Server != "CarLot")
                {
                    Console.WriteLine("Unrecognized Database Name");
                    return false;
                }

                if (csp.Database != "training" && csp.Database != "main")
                {
                    Console.WriteLine("Unrecognized Server Name");
                    return false;
                }

                if (csp.Uid != "Admin")
                {
                    Console.WriteLine("Unrecognized Admin Name");
                    return false;
                }

                if (csp.Password != "1234")
                {
                    Console.WriteLine("Unrecognized Password");
                    return false;
                }

                return true;
            }

            public static bool IsConnected()
            {
                return !(_instance == null);
            }

            public List<Car> Data()
            {
                return tempData;
            }

            private class ConnectionStringParser
            {
                public string Driver { get; set; }
                public string Server { get; set; }
                public string Database { get; set; }
                public string Uid { get; set; }
                public string Password { get; set; }

                public ConnectionStringParser(string connectionString)
                {
                    string[] parts = connectionString.Split(';');
                    foreach (var part in parts)
                    {
                        var keyValue = part.Split('=');
                        if (keyValue.Length == 2)
                        {
                            var key = keyValue[0].Trim();
                            var value = keyValue[1].Trim();
                            switch (key.ToLower())
                            {
                                case "driver":
                                    Driver = value;
                                    break;
                                case "server":
                                    Server = value;
                                    break;
                                case "database":
                                    Database = value;
                                    break;
                                case "uid":
                                    Uid = value;
                                    break;
                                case "pwd":
                                    Password = value;
                                    break;
                            }
                        }
                    }
                }

                public bool IsValid()
                {
                    return !string.IsNullOrWhiteSpace(Driver)
                        && !string.IsNullOrWhiteSpace(Server)
                        && !string.IsNullOrWhiteSpace(Database)
                        && !string.IsNullOrWhiteSpace(Uid)
                        && !string.IsNullOrWhiteSpace(Password);
                }

            }

        }
    }
}
