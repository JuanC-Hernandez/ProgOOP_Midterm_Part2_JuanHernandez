using static ProgOOP_Midterm_Part2_JuanHernandez.ItemDatabase;

namespace ProgOOP_Midterm_Part2_JuanHernandez
{

    // Juan Hernandez
    // Midterm Part 2
    // 02/18/24
    internal class Program
    {
        static void Main(string[] args)
        {
            // Update Connection
            Config.UpdateConnectionString("CarLot", "main", "Admin", "1234");
            // Save connection
            string connectionString = Config.connectionString;

            // Connect
            Database db = Database.ConnectToDatabase(connectionString);

            // Pull the data
            List<Car> data = db.Data();
            Car testGetType = data[0];
            Console.WriteLine(testGetType.GetType());
            Type groceryType = typeof(Car);

            // Comparing GetType to typeof(Groceries)
            bool sameType = testGetType.GetType() == groceryType;

            // Printing the result
            Console.WriteLine($"Are they the same time:  {sameType}");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Display All Items");
                Console.WriteLine("2. Display Ford");
                Console.WriteLine("3. Display Honda");
                Console.WriteLine("4. Display Fiat");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllItems(data);
                        break;
                    case 2:
                        DisplayFord(data);
                        break;
                    case 3:
                        DisplayHonda(data);
                        break;
                    case 4:
                        DisplayFiat(data);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            static void DisplayAllItems(List<Car> data)
            {
                foreach (Car car in data)
                {
                    car.DisplayCarInfo();
                }

            }

            static void DisplayFord(List<Car> data)
            {
                // Code to display all Ford
                foreach (Car car in data)
                {
                    if (car.GetType() == typeof(Ford))
                    {
                        car.DisplayCarInfo();
                    }
                }
            }

            static void DisplayHonda(List<Car> data)
            {
                // Code to display all Honda
                foreach (Car car in data)
                {
                    if (car.GetType() == typeof(Honda))
                    {
                        car.DisplayCarInfo();
                    }
                }
            }

            static void DisplayFiat(List<Car> data)
            {
                // Code to display all Fiat
                foreach (Car car in data)
                {
                    if (car.GetType() == typeof(Fiat))
                    {
                        car.DisplayCarInfo();
                    }
                }

            }
        }
    }

