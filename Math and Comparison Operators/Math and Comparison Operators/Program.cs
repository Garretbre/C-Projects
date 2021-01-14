using System;

namespace Math_and_Comparison_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //This is the title Anonymous Income Comparison Program.
            Console.WriteLine("Anonymous Income Comparison Program");

            //Variables for Person 1 and Person 2.
            //int myRate2 = 20;int myHours1 = 40;int myHours2 = 40;int myAnnual1 = 31,200;int myAnnual2 = 41,600;
            int[] rateNumbers = { 15, 20 };
            int[] myHours = { 40, 40 };


            //Print Person 1
            Console.WriteLine("Person 1");

            //Ask about- hourly rate and print person 1 hourly rate
            Console.WriteLine("Hourly Rate?" + Environment.NewLine + rateNumbers[0]);

            //Ask about- Hours worked per week?
            Console.WriteLine("Hours worked per week?" + Environment.NewLine + myHours[0]);

            //Print Person 2
            Console.WriteLine("Person 2");

            //Ask about- hourly rate and print person 2 hourly rate
            Console.WriteLine("Hourly Rate?" + Environment.NewLine + rateNumbers[1]);

            //Ask about- Hours worked per week?
            Console.WriteLine("Hours worked per week?" + Environment.NewLine + myHours[1]);

            //Annual salary of person 1:
            Console.WriteLine("Annual salary of Person 1:");
            
            int x = 31200;
            Console.WriteLine(x.ToString("##,###"));
            
            //Annual salary of person 2:
            Console.WriteLine("Annual salary of Person 2:");
            
            int Y = 41600;
            Console.WriteLine(Y.ToString("##,###"));

            //Bool does Person 1 make more money than Person 2?
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (x > Y)
            {
            Console.Write("True");
            }
            else
            {
            Console.Write("False");
            }




            //string yourCourse = Console.ReadLine();

            //User inserting integers
            //Console.Write("What page number?          Page:");
            //string pageNumber = Console.ReadLine();

            //This must include after a true and false statement saying "Please answer "true" or "false" after the question
            //Console.Write("Do you need help with anything?" + Environment.NewLine + "Please answer \"true\" or \"false\" " + "Answer:");
            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            //int z;
            //Console.WriteLine("Is your number greater than 50?" + Environment.NewLine + "Number:");
            //z = int.Parse(Console.ReadLine());
            //if (z >= 50)
            //{
            //    Console.Write("True");
            //}
            //else
            //{
            //    Console.Write("False");
            //}

            //string yourNeed = Console.ReadLine();

            //This must include "Please give specifics" after the question 
            //Console.Write("Were there any positive experiances you'd like to share?" + Environment.NewLine + "Please give specifics:");
            //string positiveExperiance = Console.ReadLine();

            //This must include"Please be specific" after the question
            //Console.Write("Is there any other feedback you'd like to provide?" + Environment.NewLine + "Please be specific:");
            //string provideFeedback = Console.ReadLine();

            //User inserting variables and integers
            //Console.Write("How many hours did you study today?    Hours:");
            //string hourStudy = Console.ReadLine();

            //After all of the questions are asked, print, "Thank you for your answers.An Instructor will respond to this shortly. Have a great day!" This is the end of the program.

            //Console.WriteLine("Thank you for your answers.An Instructor will respond to this shortly. Have a great day!");

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

            Console.Read();

        }

        


    }
}
