using BB203_Exception.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB203_Exception.Models
{
    internal class Hotel
    {
        public string Name { get; set; }
        Room[] Rooms =new Room[0];
        public Hotel(string name)
        {
            Name = name;    
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length+1);
            Rooms[Rooms.Length-1] = room;
        }
        public void MakeReservation(int? roomId)
        {
            if(roomId != null)
            {
                foreach (var item in Rooms)
                {
                    if(item.Id==roomId)
                    {
                        if(item.IsAvailable)
                        {
                            item.IsAvailable = false;
                            Console.WriteLine("Rezervasya olundu");
                        }
                        else
                        {
                            throw new NotAvailableException("Otaq doludur");
                        }
                    }
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
