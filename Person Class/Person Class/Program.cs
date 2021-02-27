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


            
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = " Student";
            person.Id = 12;

            Employee person2 = new Employee();
            person2.FirstName = "Billy";
            person2.LastName = " Joe";
            person2.Id = 12;
            //person2.Id = 13; *Tested to see if the program worked*


            person.SayName();
            person2.SayName();

            Console.WriteLine("The Employee Id's are the same number");
            Console.WriteLine(person == person2);
            Console.WriteLine("The Employee Id's are not the same number");
            Console.WriteLine(person != person2);
            //if (person == person2)
            //    Console.WriteLine("Employee 1 was hired the same day as Employee 2 ");
            //else
            //   Console.WriteLine("Employee 1 were not hired on the same day Employee 2");


            Console.ReadLine();

        } 
    }
}
