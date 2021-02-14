using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Console_instantiate
{
    public class Class2
    {
        public int Method4(int num1)

        {
            int result = num1 + 5;
            return result;
        }
        //3. Add a second method to the class with the same name that will take in a decimal, 
        //create a different math operation for it, then return the answer as an integer.


        public int Method4(decimal num2)
        {
            
            
            return Convert.ToInt32(num2 + 3);
            
        }

        //5. Add a third method to the class, with the same name, that will take in a string, 
        //convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
        public int Method4(string num3)
        {
                //int result = 0;
                bool x = Int32.TryParse(num3, out int result);
                //int result = Int32.Parse(num3);
                //return result;
                

            if (x)
            {
                return result * 3;
            }
            else
            {
              throw new Exception("You have not entered a number");
            }
            
        }
    }
}
