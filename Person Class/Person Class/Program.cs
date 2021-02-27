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





            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
            List<string> Things = new List<string>();
            Things.Add("Gourmet Sandwich");
            Things.Add("Fondue");
            Things.Add("Macaroni");
            

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
            List<int> Things = new List<int>();
            Things.Add(1);
            Things.Add(2);
            Things.Add(3);
            //5. Create a loop that prints all of the Things to the Console.
            foreach (string thing in Things)
            {
                Console.WriteLine(thing);
            }

            //foreach (int Balances in Balance)
            //{
            //    Console.WriteLine(Balances);
            //}

            Person person = new Person();
            person.FirstName = "Sample";
            person.LastName = " Student";
            person.Id = 12;

            //Employee person2 = new Employee();
            //person2.FirstName = "Billy";
            //person2.LastName = " Joe";
            //person2.Id = 12;
            ////person2.Id = 13; *Tested to see if the program worked*


            person.SayName();
            //person2.SayName();

            //Console.WriteLine("The Employee Id's are the same number");
            //Console.WriteLine(person == person2);
            //Console.WriteLine("The Employee Id's are not the same number");
            //Console.WriteLine(person != person2);
            //if (person == person2)
            //    Console.WriteLine("Employee 1 was hired the same day as Employee 2 ");
            //else
            //   Console.WriteLine("Employee 1 were not hired on the same day Employee 2");


            Console.ReadLine();

        } 
    }
}
