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
        //4. Create a method with output parameters.
        public void Method2(out int answer, out string message)
        {
            {
                message = "I am outputting a string and then the number 10";
                answer = 10;
                
                
                
                
            }

        }


    }
}
