using System;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //This is the Title 
            Console.WriteLine("The Tech Academy" + Environment.NewLine + "Student Daily Report");

            //User inserting variables
            Console.Write("What is your name?         Name:");
            string yourName = Console.ReadLine();

            //Inputting variables and integers
            Console.Write("What Course are you on?    Course:");
            string yourCourse = Console.ReadLine();

            //User inserting integers
            Console.Write("What page number?          Page:");
            string pageNumber = Console.ReadLine();

            //This must include after a true and false statement saying "Please answer "true" or "false" after the question
            Console.Write("Do you need help with anything?" + Environment.NewLine + "Please answer \"true\" or \"false\" " + "Answer:");

            string yourNeed = Console.ReadLine();

            //This must include "Please give specifics" after the question 
            Console.Write("Were there any positive experiances you'd like to share?" + Environment.NewLine + "Please give specifics:");
            string positiveExperiance = Console.ReadLine();

            //This must include"Please be specific" after the question
            Console.Write("Is there any other feedback you'd like to provide?" + Environment.NewLine + "Please be specific:");
            string provideFeedback = Console.ReadLine();

            //User inserting variables and integers
            Console.Write("How many hours did you study today?    Hours:");
            string hourStudy = Console.ReadLine();

            //After all of the questions are asked, print, "Thank you for your answers.An Instructor will respond to this shortly. Have a great day!" This is the end of the program.

            Console.WriteLine("Thank you for your answers.An Instructor will respond to this shortly. Have a great day!");

            Console.Read();

        }
    }
}
