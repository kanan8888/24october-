using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Helper.Exceptions
{
    public class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException() : base("price 0 olmamalidirrrrr") { }
        public PriceMustBeGratherThanZeroException(string message) : base(message) { }

    }
}
