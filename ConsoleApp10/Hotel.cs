using ConsoleApp10.Helper.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Hotel
    {
        static int _id;

        Room[] rooms=new Room[0];
        public int Id { get; }
        public string Name { get; set; }
        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, +1);
            rooms[^1] = room;
        }
        public void FindAllRoomByPrice(int minPrice, int maxPrice) 
        {
            foreach (Room room in rooms) 
            {
                if (room.Price>=minPrice && room.Price <= maxPrice)
                {
                    Console.WriteLine(room.ToString());
                }
            }
        }
        public void MakeReservation(int? id, int musteriSayi)
        {
            if (id == null) 
            {
                throw new NullReferenceException("id problemi");
            }
            foreach (Room room in rooms) 
            {
                if (room.Id==id)
                {
                    if (room.IsAvialable && musteriSayi<= room.PersonCapacity)
                    {
                        Console.WriteLine("otaq rezerv edildi");
                        room.IsAvialable=false;
                    }
                    else 
                    {
                        throw new NotAvailableException();
                    }
                }
            }
        }

    }
}
