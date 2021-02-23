using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overload ");
            //1.Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

            //2. In the Main() method, instantiate that class.
            ClassOne twoClass = new ClassOne();

            //3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Pick a number you would like to use math operations on ");
            Console.Write("number: ");
            int oneNum = Convert.ToInt32(Console.ReadLine());
            twoClass.Method1(oneNum);

            //4. Create a method with output parameters.
            Console.WriteLine("10 + 10 =");
            Console.WriteLine(twoClass.Method2(10, 10));



            //5. Overload a method.
            Person me = new Person();
            me.SayName("Garret");



            
            var number = Calculator.ReturnANumber(4);
            Console.WriteLine("Your Staic number is " + number);


            Console.ReadLine();
        }
    }
}
