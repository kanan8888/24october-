using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Room
    {
        static int _id;


        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        int _personCapacity;
        public int PersonCapacity
        {
            get { return _personCapacity; }
            set 
            {
                if (value<=0) 
                {
                    throw new Exception("PersonCapacity nece 0 veya menfi ola biler ki ?!");
                }
                _personCapacity = value;
            }
        }

        bool _sAvialable=true;
        public bool IsAvialable { get; set; }

        public Room(string name, int price, int personCapacity)
        {
            Id=++_id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public override string ToString() 
        {
            return $"\nId-{Id} Name-{Name} Price-{Price} PersonCapacity-{PersonCapacity} IsAvialable-{IsAvialable}\n";
        }
    }
}
