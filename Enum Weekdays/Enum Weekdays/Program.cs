using System;
using System.Collections.Generic;
using System.Text;


namespace Enum_Weekdays
{

    class Program
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
        static void Main(string[] args)
        {

            Console.WriteLine("Hello to days of the week!");

            try
            {

                Console.WriteLine("1 Monday");
                Console.WriteLine("2 Tuesday");
                Console.WriteLine("3 Wednesday");
                Console.WriteLine("4 Thursday");
                Console.WriteLine("5 Friday");
                Console.WriteLine("6 Saturday");
                Console.WriteLine("7 Sunday");

                //2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Pick a day of the week.");
                DaysOfTheWeek day = (DaysOfTheWeek)Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(day - 1);

                //3. Assign the value to a variable of that enum data type you just created.
                //var weekday = new List <DaysOfTheWeek>();
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
