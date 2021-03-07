using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Chain_Constructor
{
    class Variable
    {
        public string var;

        public Variable(string avar)
        {
            //3.Chain two constructors together.
            //*string var and string avar are chained together in line 15*
            var = avar;
        }
    }
}
