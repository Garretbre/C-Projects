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
            Console.WriteLine(thumb.method4(oneNum));




            //4. In the Main() method of the console app, instantiate the class and call the second method, 
            //passing in a decimal. Display the result to the screen.
            Console.WriteLine("Your number uses decimals. Your number multipied by 3.3");
            Console.WriteLine(thumb.method5(oneNum));


            //6. In the Main() method of the console app, instantiate the class and call the third method, 
            //passing in a string that equates to an integer.Display the result to the screen.
            Console.WriteLine("Your number is now a string");
            Console.WriteLine(thumb.method6(oneNum));


            Console.ReadLine();
        }
    }
}
