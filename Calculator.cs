using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_course
{
    class Calculator
    {
        //[access] [type] [name]

        public int num1;
        public int num2;
        public int result;


        // [access] [modifier] [return type] [name]([parameters])
        public void Add()
        {
            result = num1 + num2;

        }
        public void PrintResult()
        {
            Console.WriteLine("The result is: " + result);
        }
    }
}
