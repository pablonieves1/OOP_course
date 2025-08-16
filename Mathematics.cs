using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Mathematics
    {
        double num1, num2, result;


        //The only public method in this class
        public void Sum()
        {
            Console.WriteLine("Give the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine($"The sum of {num1} + {num2} is {result}");

        }

        //[access] [modifier] [return type] [name]([parameters])
        public void Subtract(double num1Pa, double num2Pa)
        {

            result = num1Pa - num2Pa;
            Console.WriteLine($"The subtraction of {num1Pa} - {num2Pa} is {result}");
        }

        //[access] [modifier] [return type] [name]([parameters])
        public  double Multiply()
        {
            Console.WriteLine("Give the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            result = num1 * num2;

            return result;
        }
    }
}
