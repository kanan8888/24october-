using ConsoleApp10.Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Store
    {
        Product[] _products = new Product[0];

        public void AddProduct(Product product) 
        {
            Array.Resize(ref _products, _products.Length+1);
            _products[^1] = product;
        }
        public void RemoveProduct(int? no) 
        {
            Product[] newArray = new Product[0];
            for (int i=0; i < _products.Length; i++)
            {
                if (_products[i].No != no)
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    newArray[^1] = _products[i];
                }
            }
            _products = newArray;
        }
        public Product? GetProduct(int? no)
        {
            foreach (Product product in _products)
            {
                if (product.No == no)
                {
                    Console.WriteLine(product.ToString());
                    return product;
                }
            }
            return null;
        }
        public void FilterProductsByType(ProductType type)
        {
            foreach (Product product in _products) 
            {
                if (product.Type==type)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        public void FilterProductByName(string name)
        {
            foreach (Product product in _products)
            {
                if (product.Name.Contains(name))
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
    }
}
