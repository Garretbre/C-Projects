using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Class
{
    
    class Employee : Person
    {
        //1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator >(Employee person, Employee person2)
        {
            if (person.Id > person2.Id)
                return true;
            else if (person.Id == person2.Id)
                return false;
            else
                return false;
        }

        public static bool operator <(Employee person, Employee person2)
        { 

            if (person.Id < person2.Id)
                return false;
            else if (person.Id == person2.Id)
                return false;
            else
                return true;
        }


        public override void SayName()
        {


            Console.WriteLine("Name: " + FirstName + LastName + " -Id: " + Id);
        }

        
    }

}

