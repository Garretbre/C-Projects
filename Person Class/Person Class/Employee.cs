using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Class
{
    //1.Make the Employee class take a generic type parameter.
    public class Employee<T> : Person
    {
        //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
        public Employee<T> Things;
        //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
        //public string Food;
        //public int Balance;







        //public static bool operator ==(Employee person, Employee person2)
        //{
        //   if (person.Id == person2.Id)
        //        return true;
        //    else
        //        return false;
        //}

        //public static bool operator !=(Employee person, Employee person2)
        //{ 

        //    if (person.Id != person2.Id)
        //        return true;
        //    else
        //        return false;
        //}


        //public override void SayName()
        //{


        //    Console.WriteLine("Name: " + FirstName + LastName + " -Id: " + Id);
        //}


    }

}

