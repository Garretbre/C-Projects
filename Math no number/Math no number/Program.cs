﻿using System;

namespace Math_no_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The 2nd number does not need to be entered application");
            //1.Create a class. In that class, create a method that takes two integers as parameters.
            //Make one of them optional.Have the method do a math operation and return an integer result.
            // *Creating a class you right click on Math no number and scroll down to Add. Then add new class.*

            //2. In the Main() method of the console app, instantiate the class.
            TwoIntegers thumb = new TwoIntegers(); //instantiate
            //thumb.Add(int num1);
            //thumb.Add(int num2);


            //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
            Console.WriteLine("Pick a number you would like to use math operations on ");
            Console.Write("number: ");
            int oneNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("You do not need to enter a number here ");
            //Console.Write("number: ");
            //int twoNum = Convert.ToInt32(Console.ReadLine());





            //4. Call the method in the class, passing in the one or two numbers entered.


            //Console.WriteLine(thumb.Method1(oneNum, twoNum));
            
            
            Console.WriteLine("Currently your number ");
            try
            {
                Console.WriteLine("You do not need to enter a number here ");
                Console.Write("number: ");
                int twoNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your numbers were added and that number was multiplied by 3 ");
                Console.WriteLine(thumb.Method1(oneNum, twoNum));
                //*Instructor input*
                //string secondInput = Console.ReadLine();
                //if (secondInput == '')  // empty string
                //{
                //    // call method with one parameter 
                //}
                //else
                //{
                //    // convert secondInput to int
                //    // call method with two parameters
                //}
                //*Try when you have time*
            }
            catch (Exception)
            {
                Console.WriteLine("Your first number was multiplied by 3");
                Console.WriteLine(thumb.Method1(oneNum));
            }


            Console.ReadLine();
            //5. Try various combinations of numbers on the code, including having no second number.
            //* I tested with both numbers and with one number. All paths of code worked*
            
        }
    }
}
