using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgOOP_Midterm_Part2_JuanHernandez
{
    public class Honda : Car
    {
        // Fields and Properties
        // Constructor
        public Honda(string make, string model, double price, int miles) : base(make, model, price, miles)
        {

        }

        // Override Method
        public override void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Miles: {Miles}, Price: ${Price}");
        }
    }
}  