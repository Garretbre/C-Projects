using System;
using System.Collections.Generic;
using System.Text;
using Math_Class_Methods;



namespace Math_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Operators");


            //2. In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Pick a number you would like to use math operations on ");
            Console.Write("number: ");
            int oneNum = Convert.ToInt32(Console.ReadLine());

            

            //3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            Console.WriteLine(Add);
        }
    }
}
