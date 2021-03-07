using System;

namespace ConsoleApp_Chain_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chain Constructor World!");

            Console.WriteLine("\nVariables will be written on the next few lines as var");
            //1.Create a const variable.
            Variable var1 = new Variable("Not a var");
            Variable var2 = new Variable("var var");
            Variable var3 = new Variable("var var var");


            //2.Create a variable using the keyword “var.”
            var1.var = "var";  
            //*Creating a variable "var" that will be the variable that will replace the const variable that 

            //3.Chain two constructors together.
            Console.WriteLine(var1.var +  " and " + var3.var); // *Both constructors together* 
            Console.WriteLine(var2.var);
            Console.WriteLine(var3.var);
            //4.Add comments to each line or block of your code to explain what it does exactly, 
            //so that another developer could read and understand your code.
            //*My comments*

            //5.Upload your code to GitHub.
            //*Uploaded*
            Console.ReadLine();
        }
    }
}
