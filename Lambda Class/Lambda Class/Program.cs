using System;

namespace Lambda_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //1.In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".

            Employee emp1 = new Employee();
            emp1.FirstName = "Sample";
            emp1.LastName = " Student";
            emp1.Id = 2;

            Employee emp2 = new Employee();
            emp2.FirstName = "joe";
            emp2.LastName = " smith";
            emp2.Id = 123;

            Employee emp3 = new Employee();
            emp3.FirstName = "jane";
            emp3.LastName = " archer";
            emp3.Id = 3;

            Employee emp4 = new Employee();
            emp4.FirstName = "timmy";
            emp4.LastName = " zilla ";
            emp4.Id = 87;

            Employee emp5 = new Employee();
            emp5.FirstName = "koto";
            emp5.LastName = " roboto";
            emp5.Id = 26;

            Employee emp6 = new Employee();
            emp6.FirstName = "joe";
            emp6.LastName = " wren";
            emp6.Id = 345;

            Employee emp7 = new Employee();
            emp7.FirstName = "sarah";
            emp7.LastName = " anderson";
            emp7.Id = 90;

            Employee emp8 = new Employee();
            emp8.FirstName = "bruce";
            emp8.LastName = " banner";
            emp8.Id = 999;

            Employee emp9 = new Employee();
            emp9.FirstName = "garret";
            emp9.LastName = " breitenbach";
            emp9.Id = 4;

            Employee emp10 = new Employee();
            emp10.FirstName = "tony";
            emp10.LastName = " stark";
            emp10.Id = 1;


            
            Employee name = new Employee();
            foreach (Employee name in emp.joe)
            {
                Console.WriteLine(name.joe);
            }

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            //Employee name1 = new Employee();

            //foreach (Employee name in emp1.FirstName)
            //{
            //    Console.WriteLine(name1.FirstName);
            //}

            //3.Perform the same action again, but this time with a lambda expression.
            //List<Employee> newList = Employee.Where(x => x.emp == .Joe).ToListString();

            //foreach (Employee emp in newList)
            //{
            //Console.WriteLine(emp.Joe);
            //}
            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.

            Console.ReadLine();
        }
    }
}
