using System;
using System.IO;

namespace Log_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Log Class");

            Console.WriteLine("Please enter a number you would like log to a text file");

            //1.Asks the user for a number.
            string cent = Console.ReadLine();
            //*Tested with the number 3 and the integer was in the log.txt file*

            //2.Logs that number to a text file.
            File.WriteAllText(@"C:\Users\grret\Logs\log.txt", cent);

            //3.Prints the text file back to the user.
            String path = @"C:\Users\grret\Logs\log.txt"; //* The path to the file we want to read*

            String lines;                   //*Reading all the lines that have been written by the User.*
            lines = File.ReadAllText(path);  
            Console.WriteLine("This is the number you wrote: ");
            Console.WriteLine(lines); //*Printing to the Console the lines that were read.*

            //4.Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
            Console.ReadLine();

            //5.Upload your code to GitHub.
        }
    }
}
