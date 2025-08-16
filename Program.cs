



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

            //Calculator calculator = new Calculator();

            ////Have a user input both numbers
            //Console.WriteLine("Enter the first number:");
            //calculator.num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //calculator.num2 = Convert.ToInt32(Console.ReadLine());

            ////Call the Add method to calculate the sum
            //calculator.Add();
            //calculator.PrintResult();


            ////Trying scopes
            //double number1;
            //Console.WriteLine("Enter a number for local variable ");
            //number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("The local variable number is {0}", number1);

            //Try testScope = new Try();
            //testScope.Add();

            //testScope.TestScope();

            ////Triying to print a variable defined in another class
            //Console.WriteLine(testScope.z);

            ////Using the field at class level
            ///

            //AccessScopeTry TryObjectScope = new AccessScopeTry();

            //TryObjectScope.a = 10;
            //TryObjectScope.b = 20;
            //Console.WriteLine("The sum of a + b is: {0}", TryObjectScope.a + TryObjectScope.b);

            //MathematicalOperations mathops = new MathematicalOperations();

            ////ask user for bvalues to asign to the fields
            //Console.WriteLine("Enter the first number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //mathops.Multiply(num1, num2);
            ////mathops.Info(); // This method is private and cannot be accessed outside the class


            int option;
            double num1Ar, num2Ar;
            double multresult;

            //Control Menu
            Console.WriteLine("1. Sum two numbers");
            Console.WriteLine("2. Substract two numbers");
            Console.WriteLine("3. Multiply two numbers");

            Console.WriteLine("Choose an option:");
            option = Convert.ToInt32(Console.ReadLine());

            

            //Using the Mathematics class
            Mathematics calculator1 = new Mathematics();


            if (option == 1)
            {
                calculator1.Sum();
            }
            else if (option == 2)
            {
                Console.WriteLine("Give the first number:");
                num1Ar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Give the second number:");
                num2Ar = Convert.ToDouble(Console.ReadLine());

                calculator1.Subtract(num1Ar, num2Ar);
            }
            else if (option == 3)
            {
                multresult = calculator1.Multiply();
                Console.WriteLine($"The multiplication result is: {multresult}");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose 1 or 2.");
            }


        }
    }
}