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

            
            Employee object1 = new Employee();
            object1.firstName = "Sample";
            object1.lastName = " Student";


            object1.SayName();


            Employee object2 = new Employee();
            object2.Quit();
            

            Console.ReadLine();

           
        }
    }
}
