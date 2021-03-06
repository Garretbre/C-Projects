using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lambda_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.
            //At least two employees should have the first name "Joe".
            List<Employee> Employees = new List<Employee>()
            {
                new Employee                                         //*Each new Employee needs a firstname, lastname, and ID object in the list*
                {
                    firstname = "Joe", lastname = "Jackson", ID = 34
                },
                new Employee
                {
                    firstname = "Bob", lastname = "Smith", ID = 4
                },
                new Employee
                {
                    firstname = "Jeff", lastname = "Miller", ID = 7
                },
                new Employee
                {
                    firstname = "Dale", lastname = "Turner", ID = 1
                },
                new Employee
                {
                    firstname = "Kate", lastname = "Johnson", ID = 45
                },
                new Employee
                {
                    firstname = "Joe", lastname = "Abraham", ID = 78  //*Joe is a firstname for the secound time in our employee list*
                },
                new Employee
                {
                    firstname = "Allen", lastname = "Zilla", ID = 12
                },
                new Employee
                {
                    firstname = "Timmy", lastname = "Banner", ID = 9
                },
                new Employee
                {
                    firstname = "Ann", lastname = "Stark", ID = 35
                },
                new Employee
                {
                    firstname = "Tommy", lastname = "Thanos", ID = 44
                },
            };





            List<Employee> Joes = new List<Employee>();
            Console.WriteLine("joe in the Joes");
            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            foreach (var employee in Employees) //*Loops through the employees*
            {
                if( employee.firstname.ToLower() == "joe") //* finds the 2 joes *
                {
                    Joes.Add(employee);  //* Adds the 2 Joes to the new list Joes
                    Console.WriteLine(employee.firstname);
                }
            }
            //Console.WriteLine(Joes);
            //3.Perform the same action again, but this time with a lambda expression.
            List<Employee> newList = Employees.Where(x => x.firstname == "Joe").ToList();
            //* x => x.firstname == "Joe", which specifies a parameter that's named x, searches through firstname of all employees and returns the value of Joe, is assigned to a variable of a delegate type*
            //*Uses lambda expression in the Where brackets to find the 2 joes and puts the joes into newList.
            Console.WriteLine("Joe in newList");
            foreach (Employee employee in newList)
            {
                
                Console.WriteLine("Joe");
            }
            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            //Console.WriteLine(newList);
            List<Employee> greaterthan5 = Employees.Where(x => x.ID > 5).ToList();
            //*Similar to above the Where is looking through the ID int to find all numbers above 5. and puts those into greaterthan5*
            Console.WriteLine("These ID's are over 5:");
            
            foreach (Employee employee in greaterthan5)
            {

                Console.WriteLine(employee.ID);
            }
            //5.Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
            //*My comments in each block*

            
            Console.ReadLine();
        }
    }
}
