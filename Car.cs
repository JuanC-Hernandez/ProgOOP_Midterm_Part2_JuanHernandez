using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_JuanHernandez
{
    public abstract class Car
    {
        //public string Brand { get; set; };

        // Constructor
        protected Car(string make,string model, double price, int miles )
        {
            Make = make;
            Model = model;
            Price = price;
            Miles = miles;  
        }

        // Fields and Properties
        public string Make { get;  set; }
        public double Price { get;  set;}
        public int Miles { get;  set;}
        public string Model { get;  set; }

        // abstract method
        public abstract void DisplayCarInfo();
    }
}
