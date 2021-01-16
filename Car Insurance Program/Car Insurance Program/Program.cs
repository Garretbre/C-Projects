using System;

namespace Car_Insurance_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Program");


            //What is your age?
            string input;
            string myDui;
            int age;
            int speeding;
            int drunk;
            
            
            


            Console.WriteLine("What is your age?");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);

            //Have you ever had a DUI?
            Console.WriteLine("Have you ever had a DUI? (1 for true and 2 for false)");
            myDui = Console.ReadLine();
            drunk = Convert.ToInt32(myDui);


            //How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets do you have?");
            input = Console.ReadLine();
            speeding = Convert.ToInt32(input);


            //Qualified?
            Console.WriteLine("Qualified?");
            if (age >= 15 && drunk == 2 && speeding <= 3)
            {
                Console.Write("true");
            }
            else 
            {
                Console.WriteLine("false");
            }
            
            


            //Are both of these true. All have to be true.
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Or operator
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //equal to
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Does not equal
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Xor operator 
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);



            Console.ReadLine();
        }
    }
}
