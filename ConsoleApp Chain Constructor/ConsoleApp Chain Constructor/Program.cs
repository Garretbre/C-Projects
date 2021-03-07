using System;

namespace ConsoleApp_Chain_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Chain Constructor World!");

            Console.WriteLine("\nVar will be written on the next line");
            //1.Create a const variable.
            Variable var1 = new Variable();
            Variable varChain = new Variable();
            //*Instantiates the object that chains constructors*
            
            var1.var = "Not the var we are looking for";
            

            //3.Chain two constructors together.
            Console.WriteLine(varChain.var); 
            
            
            //4.Add comments to each line or block of your code to explain what it does exactly, 
            //so that another developer could read and understand your code.
            //*My comments*

            //5.Upload your code to GitHub.
            //*Uploaded*
            Console.ReadLine();
        }
    }
}
