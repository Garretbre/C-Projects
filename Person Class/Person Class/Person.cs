using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Class
{
    public class Person
    {
        
        public string FirstName;
        public string LastName;
        public int Id;

        public void SayName()
            {
                Console.WriteLine("Name: " + FirstName + LastName + "Emploee Number: " + Id);
            }
        
    }
}
