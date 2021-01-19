using System;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //Static written title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //First question to User weight. weight greater than 50. display error message that reads. "Package too heavy to be shipped via Package Express. Have a good day". At this point the program end
            Console.WriteLine("Please enter the package weight:");
            double currentWeight = Convert.ToInt32(Console.ReadLine());

            if (currentWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
             
            
            //Secound question to User width.
            Console.WriteLine("Please enter the package width:");
            double currentWidth = Convert.ToInt32(Console.ReadLine());


            //Third question to User height.
            Console.WriteLine("Please enter the package height:");
            double currentHeight = Convert.ToInt32(Console.ReadLine());

            //Fourth question to User length. length greater than 50. display error message that reads. "Package too big to be shipped via Package Express.". At this point the program would end
            Console.WriteLine("Please enter the package length:");
            double currentLength = Convert.ToInt32(Console.ReadLine());

            if (currentLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            
            double result = currentWeight * currentWidth * currentHeight * currentLength;
            

            Console.WriteLine($"Your estimated total for shipping this package is:    ${Convert.ToDecimal(result)/100}");
            

            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
