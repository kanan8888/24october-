using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Helper.Exceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException():base("defoult mesaj: yas duzgun deyil") {}
        public InvalidAgeException(string message) : base(message) {}
    }
}
