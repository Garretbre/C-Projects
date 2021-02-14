using System;

namespace Math_no_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 2nd number does not need to be entered application");
            //1.Create a class. In that class, create a method that takes two integers as parameters.
            //Make one of them optional.Have the method do a math operation and return an integer result.
            // *Creating a class you right click on Math no number and scroll down to Add. Then add new class.*

            //2. In the Main() method of the console app, instantiate the class.
            twoIntegers thumb = new twoIntegers(); //instantiate

            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
            Console.WriteLine("Pick a number you would like to use math operations on ");
            Console.Write("number: ");
            int oneNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You do not need to enter a number here ");
            Console.Write("number: ");
            int twoNum = Convert.ToInt32(Console.ReadLine());

            //4. Call the method in the class, passing in the one or two numbers entered.
            
            Console.WriteLine("Your number ");
            Console.WriteLine(thumb.Method1(oneNum, twoNum));

            //5. Try various combinations of numbers on the code, including having no second number.
        }
    }
}
