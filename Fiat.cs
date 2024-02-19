using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_JuanHernandez
{
    public class Fiat : Car
    {
        // Constructor
        public Fiat(string make, string model, double price, int miles) : base(make, model, price, miles)
        {

        }

        // Override Method
        public override void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Miles: {Miles}, Price: ${Price}");
        }
    }
}
