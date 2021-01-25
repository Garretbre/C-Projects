using System;
using System.Text;

namespace Concatenates_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string qoute = "The man said, \"Hello\", Garret. \n Hello on a new line. \n \t Hello on a tab.";
            //Console.WriteLine(firstName + Environment.NewLine + lastName + Environment.NewLine + qoute);


            //String concatenation using string class
            String str = " \nEnter in your first";
            str += " and last name";
            str += " to be entered into the Tech Academy system";
            Console.WriteLine("Welcome to a Tech Academy String Assignment" + str);

            
            Console.Write("Enter in your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter in your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter in the city you are living: ");
            string Location = Console.ReadLine();

            firstName = firstName.ToUpper();
            lastName = lastName.ToUpper();
            Location = Location.ToUpper();
            
            
            //String concatenation using stringbuilder class
            StringBuilder sb = new StringBuilder("My Name is:" + firstName);
            sb.Append("\nI am a student at the Tech Academy learning how to code");
            sb.Append("\nThis is a paragraph that has printed your last name here: " + lastName);
            sb.Append("\nThis is a paragraph that has printed your city: " + Location);
            sb.Append("\nCongratulations there is still more to learn");
            sb.Append("\nSee you next time!");
            Console.WriteLine(sb);

           //string fileName = @"C:\Users\Garret";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");



            Console.ReadLine();

        }
    }
}
