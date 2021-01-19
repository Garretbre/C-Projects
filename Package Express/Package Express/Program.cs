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
            int currentWeight = Convert.ToInt32(Console.ReadLine());

            if (currentWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }

            //2nd
            else
            

                //Secound question to User width.
                Console.WriteLine("Please enter the package width:");
                int currentWidth = Convert.ToInt32(Console.ReadLine());
            
            if (currentWeight + currentWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            //3rd
            else
            
                //Third question to User height.
                Console.WriteLine("Please enter the package height:");
                int currentHeight = Convert.ToInt32(Console.ReadLine());
            
            if (currentWeight + currentWidth + currentHeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            //4th
            else
            
                //Fourth question to User length. 
                Console.WriteLine("Please enter the package length:");
                int currentLength = Convert.ToInt32(Console.ReadLine());
            
            if (currentWeight + currentWidth + currentHeight + currentLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else
            
               Console.WriteLine($"Your estimated total for shipping this package is:    ${Convert.ToDecimal(currentWeight * currentWidth * currentHeight * currentLength) / 100}");

                Console.WriteLine("Thank you!");

                Console.ReadLine();
            
                
              
                


        }
    }
}
