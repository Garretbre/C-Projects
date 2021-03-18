using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
