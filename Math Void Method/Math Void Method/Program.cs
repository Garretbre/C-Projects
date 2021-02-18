using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Void_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Void Method in a Class!");
            //1.Create a class. In that class, create a void method that takes two integers as parameters.
            //Have the method do a math operation on the first integer and display the second integer to the screen.

            //2. In the Main() method of the console app, instantiate the class.
            OneVoid oneVoid = new OneVoid();



            //3. Call the method in the class, passing in two numbers.
            oneVoid.Method1(10, 6);

            //4. Call the method in the class, specifying the parameters by name.
            oneVoid.Method1(num1:2, num2:2);
        }
    }
}
