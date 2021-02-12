using System;
using System.Collections.Generic;
using System.Text;
using Math_Class_Methods;

namespace Math_Class_Methods
{
    //1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
    //The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.
    public class Class1
    {
        //Method one
        public int method1(int num1)
       
        {
            int result = num1 + 5;
            return result;
        }


        //Method two
        public int method2(int num2)
        {
            int result = num2 * 5;
            return result;
        }

        //Method three
        public int method3(int num3)
        {
            int result = num3 / 5;
            return result;
        }


    }
}
