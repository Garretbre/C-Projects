using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Employee World!");

            //4. Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".


            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = " Student";
            person.Id = 123;

            //5. Call the superclass method SayName() on the Employee object.
            person.SayName();

            Console.ReadLine();

        } 
    }
}
