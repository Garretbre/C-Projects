using System;
using System.Collections.Generic;
using System.Text;

namespace Math_no_number
{
    class twoIntegers
    {
        public int Method1(int num1, int num2)
        {

            //int result = 0;
            bool x = (num1 + num2) > 0;
            int result = num1 + num2;
            //int result = Int32.Parse(num3);
            //return result;


            if (x)
            {
                return result + 25;
            }
            else
            {
                throw new Exception("You have not entered a number");
            }
            //public int Method1(int num1, int num2)

            //{

            //    int result = num1 + num2 + 25;

            //    if (num2 < 0)
            //    {
            //        return result;
            //    }
            //    else
            //    {
            //        Console.WriteLine(num1);
            //    }
            //}

        }

     }
}
