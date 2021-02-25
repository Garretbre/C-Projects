using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public abstract class Person
    {
        //1.Create an abstract class called Person with two properties: string firstName and string lastName.
        public string firstName;
        public string lastName;

        //2. Give it the method SayName().
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }

    }
}
