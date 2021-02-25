using System;
using System.Collections.Generic;
using System.Text;

namespace Person_Class
{
    //class TwentyOneGame : Game
    class Employee : Person
    {
        //3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
        public int Id;
        public override void SayName()
        {


            Console.WriteLine("Name: " + FirstName + LastName + " -Id: " + Id);

            
        }
    }

}

