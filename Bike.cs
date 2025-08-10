using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Bike
    {
        // [access] [type] [name]
        public string make;
        public string model;
        public string color;
        public int diameter;
        public int gears;

        //[access] [modifier] [return type] [name]([parameters])
        public void Accelerate()
        {
            Console.WriteLine("The bike is accelerating.");
        }
        public void Brake()
        {
            Console.WriteLine("The bike is braking.");
        }
        public void ChangeGear(int gear)
        {
            Console.WriteLine($"The bike is changing to gear {gear}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Bike Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Diameter: {diameter} inches");
            Console.WriteLine($"Gears: {gears}");
        }
    }
}
