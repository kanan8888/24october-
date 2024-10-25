using ConsoleApp10.Helper.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Person
    {
        public string Fullname { get; set; }
        byte _age;
        public byte Age 
        {
            get 
            {
                return  _age;
            }
            set 
            {
                if (value<125 && value>0) 
                {
                    _age = value;
                }
                else 
                {
                    throw new InvalidAgeException();
                }
            }
        }
    }
}
