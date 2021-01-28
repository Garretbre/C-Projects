using System;
using System.Collections.Generic;

namespace Array_Stings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Welcome to the Survival Arena! \nWhere you choose an animal, how much that animal wieghs and what tool you will use to try to survive!");

                
                Console.WriteLine("Enter a number 0 through 3 to choose an animal: \n0- To choose a Lion \n1- To choose a Cheetah  \n2- To choose a Bear \n3- To choose a Tiger ");
                Console.Write("Animal Choice: ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                string[] animal = new string[] { "Lion", "Cheetah", "Bear", "Tiger" };
            if (input1 >= 4)
            {
                Console.WriteLine("You have not made a choice that exists. Try again later");
            }
            //2. Create a one- dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            else
            {
                Console.WriteLine("Enter a number 0 through 3 to choose an wieght of the beast: \n0- 50Lbs \n1- 150Lbs  \n2- 300Lbs \n3- 500Lbs ");
                Console.Write("how much does your animal wiegh: ");
                int input2 = Convert.ToInt32(Console.ReadLine());
                int[] numArray1 = { 50, 150, 150, 300, 500 };
                if (input2 >= 4)
                {
                    Console.WriteLine("You have not made a choice that exists. Try again later");
                }
                else
                {
                    Console.WriteLine("You have chosen " + numArray1[input2] + " lbs " + animal[input1] + " to hide or run away from.");


                    //3. Add in a message that displays when the user selects an index that doesn't exist
                    // Do and While loop for all other indexes for weight animal and list of tools.
                    //4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.


                    List<string> intTool = new List<string>();
                    intTool.Add("Net");
                    intTool.Add("Jet Pack");
                    intTool.Add("Meat Decoy");
                    intTool.Add("Camouflauge");

                    Console.WriteLine("From a wall you may pick one of the following tools: \n0 - Net, \n1- Jet Pack, \n2 Meat Decoy, \n3- Camouflauge Gear");
                    Console.Write("Choose your tool: ");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    if (input3 >= 4)
                    {
                        Console.WriteLine("You have not made a choice that exists. Try again later");
                    }
                    else
                    {

                        //Console.WriteLine("You will be escaping using a " + intTool[input3] + " against a " + numArray1[input2] + " lbs " + animal[input1] + " \nUse your item and survive!");


                        Console.WriteLine("You will be escaping using a " + intTool[input3] + " against a " + numArray1[input2] + " lbs " + animal[input1] + " \nUse your item and survive!");

                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
