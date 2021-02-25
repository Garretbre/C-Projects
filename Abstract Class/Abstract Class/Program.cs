using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Abstract Class!");

            //5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.
            Employee object1 = new Employee();
            object1.firstName = "Sample";
            object1.lastName = " Student";


            object1.SayName();

            Console.ReadLine();
        }
    }
}
