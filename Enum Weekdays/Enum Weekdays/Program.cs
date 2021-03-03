using System;
using System.Collections.Generic;
using System.Text;


namespace Enum_Weekdays
{
    //1.Create an enum for the days of the week.
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    { 
        static void Main(string[] args)
        {

            Console.WriteLine("Hello to days of the week!");

            try
            {


                
                //2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Pick a day of the week: ");
                string day = Console.ReadLine();

                //3. Assign the value to a variable of that enum data type you just created.
                DaysOfTheWeek getParse;
                bool checkParse = Enum.TryParse(day, out getParse);
                if (checkParse == true)
                {
                    Console.WriteLine("Did you enter a day of the week? " + checkParse);
                }
                else
                {
                    Console.WriteLine("Please enter a day of the week");
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Please enter an actual day of the week");
            }
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            Console.ReadLine();
        }
    }
}
