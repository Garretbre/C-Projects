using System;
using System.Collections.Generic;

namespace TryCatch_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Try/catch assignment");

            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.
            //Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //and displays the result to the screen.

            try
            {
                List<int> ageTrees = new List<int>();
                ageTrees.Add(20);
                ageTrees.Add(15);
                ageTrees.Add(200);
                ageTrees.Add(30);


                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (int ageTree in ageTrees)
                {
                //2.Run the code, entering in non - zero numbers as the user.Look at the displayed results.
                    Console.WriteLine(ageTree / numberOne);
                    Console.ReadLine();
                }
            }
           

            //3.Run the code again, entering in zero as the number to divide by.Note any error messages you get.
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message + " Please don't divide by zero.");
            }
            //Entering a zero I recieved this error message above.


            //4.Run the code once again, entering in a string as the number to divide by.Note any error messages you get.
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " Please type a whole number.");
            }
            //Entering in strings I got this error message printed to the screen above.
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


             finally
            {
                Console.WriteLine("You have emerged from the try/catch block");
            }






            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a 
            //message to the display to let you know the program has emerged from the try/catch block and continued on 
            //with program execution.In the catch block, display the error message to the screen.Then try various combinations 
            //of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that 
            //the code after the try/catch block gets executed.



            Console.ReadLine();
            }
    }
}
