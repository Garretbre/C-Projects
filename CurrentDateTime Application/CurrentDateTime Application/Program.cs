using System;

namespace CurrentDateTime_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Date and Time Application");
            //1.Prints the current date and time to the console.
            var data01 = new DateTime(2021, 8, 9, 10, 11, 12);
            //Console.WrieLine(data01) 
            //*to print the data I assigned*

            //DateTime properties
            var date02 = DateTime.Now;

            //Printing the time now
            Console.WriteLine(date02);

            //2.Asks the user for a number.
            Console.WriteLine("Please enter how many hours you would like to travel into the past:" + "\n *side note if you wish to go to the future enter a negative number:  ");

            //Users input turned into the int yesterday
            int X = Convert.ToInt32(Console.ReadLine());
            //*Converting the Users input line to an integer.*

            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            var past = date02.AddHours(-X);
            //*Adding hours or whichever date, hour or second. In the brackets what you want to change that integeter to. Subtract or Add*
            Console.WriteLine(past);
            //*Printing the new hour from how much the user wanted to subtract hours from the current time the user would be entering their number.*

            //4.Add comments to each line or block of your code to explain what it does exactly, 
            //so that another developer could read and understand your code.
            //*My comments*



            //5.Upload your code to GitHub.
            //*Uploaded*
            Console.ReadLine();
            //*pauses the console for User to read*
        }
    }
}
