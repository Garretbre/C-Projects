using System;

namespace Console_Application_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to don't guess the 8, if you do you will end your groundhogs day");
            Console.Write("What is your guess? ");

            
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 8;



            // do-while will run once and then check condition to see if it should run again
            // do while loop is first in this code
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("You guessed 2. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 3:
                        Console.WriteLine("You guessed 3. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("You guessed 4. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("You guessed 6. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("You guessed 7. Groundhog's day.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("Congratulations! You guessed 8. You have escaped Groundhog's day.");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You have guessed a number greater than 8. Please try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

            }

        } 
    while (!isGuessed);

            //Please do not enter 88! Just in the code to produce a while loop
            Console.WriteLine("Please Exit and remember. Do Not Enter Infinite 88:");
            number = Convert.ToInt32(Console.ReadLine());
            while (number == 88) 
            {
                Console.WriteLine("88");
            }
            //Again writting 88 will loop Infinitely 


    Console.ReadLine();



        }
    }
}
