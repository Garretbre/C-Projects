using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Chain_Constructor
{
    class Variable
    {
        public string var;
        //2.Create a variable using the keyword “var.”
        public Variable() : this("var")
            {
            
            }
        //*A constructor method that takes in no parameters*
         
        public Variable(string avar)
        {
            var = avar;
        }
    }
}
