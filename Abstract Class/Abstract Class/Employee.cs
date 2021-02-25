using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    //2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
    class Employee : Person, IQuittable
    {
        
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
        
        public void Quit()
        {
            Console.WriteLine("Do you wish to quit?");
        }
    }
}
