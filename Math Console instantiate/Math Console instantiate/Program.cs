using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Console_instantiate
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create a method that will take in an integer, 
            //create a math operation for this integer(addition, subtraction, etc.), then return the answer as an integer.
            Console.WriteLine("Math Operators: Decimal and string ");


            
            Console.WriteLine("Pick a number you would like to use math operations on ");
            Console.Write("number: ");
            int oneNum = Convert.ToInt32(Console.ReadLine());


            //2. In the Main() method of the console app, instantiate the class and call the one method, 
            //passing in an integer.Display the result to the screen.
            Class2 thumb = new Class2();
            Console.WriteLine("Your number plus 5");
            Console.WriteLine(thumb.Method4(oneNum));




            //4. In the Main() method of the console app, instantiate the class and call the second method, 
            //passing in a decimal. Display the result to the screen.
            Console.WriteLine("Pick a number you would like to use math operations on ");
            Console.Write("number: ");
            decimal twoNum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Your number uses decimals. Your number plus by 3");
            var result = thumb.Method4(twoNum);
            Console.WriteLine(result);
            //Console.WriteLine(result.GetType()); Test that we actually returned an integer.


            //6. In the Main() method of the console app, instantiate the class and call the third method, 
            //passing in a string that equates to an integer.Display the result to the screen.
            Console.WriteLine("Enter a number ");
            string threeNum = Console.ReadLine();
            Console.WriteLine("Currently your number is a string times 3 ");
            try
            {
                Console.WriteLine(thumb.Method4(threeNum));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
