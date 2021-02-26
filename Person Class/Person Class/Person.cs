using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Class
{
    class Person
    {
        
        public string FirstName;
        public string LastName;
        public int Id;

        public virtual void SayName()
            {
                Console.WriteLine("Name: " + FirstName + LastName);
            }
        
    }
}
