using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class Try
    {
        //This is known only by the elements of this class
        public double z = 10;
        public double x = 100; 
        public void TestScope()
        {
            Console.WriteLine("Just trying to print a variable z defined in class level {0}", z);
            double x = 30;
        }
        public void Add()
        {
            double y = 20;
            double result;

            double x = 0;

            result = x + y;
            Console.WriteLine($"The sum of {this.x} + {y} is {result}");
        }
    }
}
