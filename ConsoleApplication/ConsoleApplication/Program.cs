using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input from User gets muiltiplied by 50 then prints result to console.
            Console.WriteLine("What number would you like to be multiplied by 50?" + Environment.NewLine + "Number:");
            string sonic = Console.ReadLine();
            int num1 = Int32.Parse(sonic);
            int newSonic = num1 * 50;
            
            Console.WriteLine("The total is " + newSonic);

            //Input from User adds 25 to it, then prints the result to the console.
            Console.WriteLine("What number would you like to add 25 to?" + Environment.NewLine + "Number:");
            string Tails = Console.ReadLine();
            int num2 = Int32.Parse(Tails);
            int newTails = num2 + 25;

            Console.WriteLine("The total is " + newTails);


            //Input from User divides by 12.5, then prints the result to the console.
            Console.WriteLine("What number would you like divided by 12.5?" + Environment.NewLine + "Number:");
            string robot = Console.ReadLine();
            int num3 = Int32.Parse(robot);
            double newrobot = num3 / 12.5;

            Console.WriteLine("The total is " + newrobot);


            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            int z;
            Console.WriteLine("Is your number greater than 50?" + Environment.NewLine + "Number:");
            z = int.Parse(Console.ReadLine());
            if(z>=50)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }

            Console.WriteLine();

            //Takes an input from the user, divides it by 7, then prints the remainder to the console.(think % operator)
            Console.WriteLine("Does your number have a remainder after being divided by 7?" + Environment.NewLine + "Number:");
            string notbot = Console.ReadLine();
            int num5 = Int32.Parse(notbot);
            double newnotbot = num5 % 7;

            Console.WriteLine("The remainder is " + newnotbot);

            Console.ReadLine();
        }
    }
}
