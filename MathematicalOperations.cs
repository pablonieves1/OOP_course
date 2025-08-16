using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    internal class MathematicalOperations
    {
        private double num1, num2;
        private double result;

        public void Multiply(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;   
            result = num1 * num2;

            Info();
        }   

        private void Info()
        {
            Console.WriteLine($"The variuable {num1} * {num2} is {result}");
        }
    }
}
