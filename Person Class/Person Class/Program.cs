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

            
            
            person.SayName();
            person2.SayName();

            if (person.Id > person2.Id)
                Console.WriteLine("Employee 1 was hired before Employee 2 ");
            else if (person.Id == person2.Id)
                Console.WriteLine("Employee 1 was hired on the same day as Employee 2");
            else
                Console.WriteLine("Employee 2 was hired before Employee 1");


            Console.ReadLine();

        } 
    }
}
