using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Console_instantiate
{
    public class Class2
    {
        public int method4(int num1)

        {
            int result = num1 + 5;
            return result;
        }
        //3. Add a second method to the class with the same name that will take in a decimal, 
        //create a different math operation for it, then return the answer as an integer.

        
        public double method5(int num1)
        {
            double y = 3.3;
            double result = num1 * y;
            return result;
        }

        //5. Add a third method to the class, with the same name, that will take in a string, 
        //convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
        public int method6(int num1)
        {

            int result = num1 / 2;

            if (num1 >= 0)
            {
                Console.WriteLine(Convert.ToInt32(result));
            }
            else
            {
                Console.WriteLine("You have not entered a number");
            }
        }
    }
}
