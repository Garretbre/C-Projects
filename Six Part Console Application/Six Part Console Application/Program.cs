using System;
using System.Collections.Generic;

namespace Six_Part_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the 6 part assignment on Step 210


            Console.WriteLine("Hello pedestrian. Fortune Teller Jasper at your service. \nDo you want to become a fortune teller in 2 minutes? \nLet us begin  ");

            // Part 1 question 1: A one-dimensional array of strings
            string[] jaspersName = { "Abra ", "Kadabra ", "Let us begin " };

            
            // Part 1 question 2: Ask the user to input some text
            
            Console.Write("Please enter a pets name: ");
            string oneUser = Console.ReadLine();
            
            //Part 1 question 3: A loop that iterates through each string in the array and adds the user's text input to the end of each string. 
            //This step will not output anything to the console, but will update each array element by appending the users text.
            for (int n = 0; n < jaspersName.Length; n++)
            {
                jaspersName[n] += oneUser;
            }
            // Part 1 question 4: Then create a loop that prints off each string in the array on a separate line
            Console.WriteLine("Now for your amazement I bring you. what you wrote. Hazza!");
            for (int n = 0; n < jaspersName.Length; n++)
            {
                Console.WriteLine(jaspersName[n]);
            }


            // Part 1 question 5: Save and execute your code
            //Done

            Console.WriteLine("Ok...Ok that is just a good memory. Now for lesson one. Let us take a deep breath and then count to ten. \nAnd not think about the infinite loop behind the curtain ");
            
            //Part 2 step 1: An infinte loop
            //Part 2 step 2: Save your code
            //for(; ; )
            //{
                //Console.WriteLine("forever");
            //}

            //Part 2 step 3: Fix the infinite loop so that it will execute properly
            //Part 2 step 4: Save and execute your code
            for (int i = 0; i<= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Part 3 step 1: A loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator
            //Part 3 step 2: Save and execute your code
            Console.WriteLine("Think of a small number ");
            Console.Write("number: ");
            int oneCount = Convert.ToInt32(Console.ReadLine());

            for (int p = 1; p < oneCount; p++)
            {
                Console.WriteLine(p);
            }

            //Part 3 step 3: A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            //Part 3 step 4: Save and execute your code
            Console.WriteLine("Think of another number, I forgot to include your number in my count: ");
            Console.Write("number: ");
            int twoCount = Convert.ToInt32(Console.ReadLine());

            for (int q = 1; q <= twoCount; q++)
            {
                Console.WriteLine(q);
            }

            //Part 4-1.A list of strings where each item in the list is unique.
            List<string> itemsList = new List<string>();
            itemsList.Add("PC");
            itemsList.Add("Laptop");
            itemsList.Add("Tablet");
            itemsList.Add("Phone");

            Console.WriteLine("Choose an item from this list you can't live without in your daily life");
            Console.WriteLine("PC, Laptop, Tablet, Phone");
            //Part 4-2.Ask the user to input text to search for in the list.
            Console.WriteLine("Write in your response: ");
            string search1 = Console.ReadLine();

            //Part 4-3.A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            for ( int y = 0; y < itemsList.Count; y++)
            {
                if (itemsList[y] == search1)
                {
                    Console.WriteLine("You have Chosen:" + y);
             //Part 4-5.Add code to the loop that stops it from executing once a match has been found.
                    break;
                }
             //Part 4-4.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                else if (y == itemsList.Count -1 )
                {
                    Console.WriteLine("Your input is not on the List!");
                }

            }
            //Part 4-6.Save and execute your code.


            //Part 5-1.A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Blue");
            colorList.Add("Yellow");

            Console.WriteLine("On the table behind me you can't see that there are 4 colored cups. \nPlease think of a color in your mind but please type the word Blue: ");
            string search2 = Console.ReadLine();

            //Part 5-2.Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            for (int c = 0; c < colorList.Count; c++)
            {
                if (colorList[c] == search2)
                {
                    Console.WriteLine(c);
                    
                }
             //Part 5-3.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                else if (c == colorList.Count)
                {
                    Console.WriteLine("Your input is not on the List!");
                    
                }

            }

            //Part 5-4.Save and execute your code.

            //Part 6-1.Create a list of strings that has at least two identical strings in the list.
            List<string> names = new List<string>() { "Magic", "Crystal ball", "Color Cups", "Magic", "Magic"};
            List<string> nameList = new List<string>();

            Console.WriteLine("Crystal ball please show us words of Magic ");

            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string name in names)
            {
                if (nameList.Contains(name))
               {
                    Console.WriteLine(name);
                    break;
                } 
                else 
               {
                       Console.WriteLine(name);
                        nameList.Add(name);
                }
            //    //if (name == "Magic")
            //    //{
            //    //    nameList.Add(name);
            //    //}

            }
            
            Console.WriteLine(" Hazza! You have recieved a Fortune Tellers Certificate and complimentary crystal ball!");
            //3.Save and execute your code.


            Console.WriteLine("Congratulations! I am sure you are ready to go home and give your new crysal ball a try on " + oneUser);

            Console.ReadLine();
        }
    }
}
