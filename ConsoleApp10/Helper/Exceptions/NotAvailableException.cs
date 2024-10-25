using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Helper.Exceptions
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException():base("elimizde yok") { }
        public NotAvailableException(string message) : base(message) { }
    }
}
