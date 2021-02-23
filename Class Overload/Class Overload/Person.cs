using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Overload
{
    public class Person
    {
        public void SayName()
        {
            Console.WriteLine("This is your name.");
        }

        public void SayName(string firstName)
        {
            Console.WriteLine("This is your name " + firstName);
        }
      
    }
}
