using ConsoleApp10.Helper.Enums;
using ConsoleApp10.Helper.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Product
    {
        static int _no;

        float _price;


        public int No { get; }
        public string? Name { get; set; }
        public ProductType Type { get; set; }
        public float Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price < 0) 
                {
                    throw new PriceMustBeGratherThanZeroException(" menfi qiymet olmurr !!! ");
                }
                _price = value;
            }
        }
       
           
        public Product(string? name, ProductType type, float price)
        {
            No=++_no;
            Name = name;
            Type = type;
            Price = price;
        }


        public override string ToString()
        {
            return $"Product No: {No}, Name: {Name}, Type: {Type}, Price: {Price}";
        }

    }
}
