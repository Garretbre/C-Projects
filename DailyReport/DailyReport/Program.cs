using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            
                //This is the title with one line on top and one line on bottom 
                Console.WriteLine("The Tech Academy" + Environment.NewLine + "Student Daily Report");

                //User inserting variables
                Console.Write("What is your name?");
                string yourName = Console.ReadLine();
                Console.WriteLine("Your name is: " + yourName);

                //Inputting variables and integers
                Console.Write("What Course are you on?");
                string yourCourse = Console.ReadLine();

                //User inserting integers
                Console.Write("What page number?");
                string pageNumber = Console.ReadLine();

                //This must include after a true and false statement saying "Please answer "true" or "false" after the question
                Console.Write("Do you need help with anything?" + "Please answer \"true\" or \"false\" ");
                string yourNeed = Console.ReadLine();

                //This must include "Please be specific" after the question 
                Console.WriteLine("Were there any positive experiances you'd like to share?" + "Please be specific");
                string positiveExperiance = Console.ReadLine();

                //User inserting variables and integers
                Console.Write("How many hours did you study today?");
                string hourStudy = Console.ReadLine();

                //After all of the questions are asked, print, "Thank you for your answers.An Instructor will respond to this shortly. Have a great day!" This is the end of the program.

                Console.WriteLine("Thank you for your answers.An Instructor will respond to this shortly. Have a great day!");

                Console.Read();
         }
    }
}
