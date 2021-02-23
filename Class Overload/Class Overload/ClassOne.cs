using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Overload
{
    class ClassOne
    {
        public void Method1(int oneNum)
        {

            int x = oneNum;


            if (x >= 0)
            {
                Console.WriteLine(x / 2);
            }
            else
            {
                Console.WriteLine("You have not entered a number");
            }



        }
        public int Method2(int num3, int num4)
        {
            {
                return num3 + num4;
            }

        }


    }
}
