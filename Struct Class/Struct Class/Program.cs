using System;
using System.Collections.Generic;
using System.Text;

namespace Struct_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Amount!");

            
           

            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number num1 = new Number();
            
            num1.Amount = 15.15M;

            //3. Print this amount to the console.
            Console.WriteLine("This is your decimal number: ");
            Console.WriteLine(num1.Amount);
            Console.ReadKey();
        }
    }
}
