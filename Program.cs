



namespace OOP_course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("First bike:\n");
            ////Instantiate object 1
            //Bike bike1 = new Bike();
            //bike1.make = "Specialized";
            //bike1.model = "X45";
            //bike1.color = "Red";
            //bike1.diameter = 23;
            //bike1.gears = 7;

            //bike1.DisplayInfo();

            //bike1.Accelerate();
            //bike1.ChangeGear(3);
            //bike1.Brake();
            //Console.WriteLine("\nSecond bike:\n");

            ////instantiate object 2
            //Bike bike2 = new Bike();
            //bike2.DisplayInfo();

            //bike2.make = "Trek";
            //bike2.model = "A56";
            //bike2.color = "Blue";
            //bike2.diameter = 27;
            //bike2.gears = 10;

            //bike2.DisplayInfo();

            Calculator calculator = new Calculator();

            calculator.num1 = 10;
            calculator.num2 = 20;

            calculator.Add();
            calculator.PrintResult();



        }
    }
}