﻿using System;

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
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");




            //2.Run the code, entering in non - zero numbers as the user.Look at the displayed results.


            //3.Run the code again, entering in zero as the number to divide by.Note any error messages you get.


            //4.Run the code once again, entering in a string as the number to divide by.Note any error messages you get.


            //5.Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a 
            //message to the display to let you know the program has emerged from the try/catch block and continued on 
            //with program execution.In the catch block, display the error message to the screen.Then try various combinations 
            //of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that 
            //the code after the try/catch block gets executed.

        }
    }
}
