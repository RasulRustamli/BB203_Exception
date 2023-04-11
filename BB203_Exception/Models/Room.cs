using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB203_Exception.Models
{
    internal class Room
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Room(string name,double price,int personcapacity)
        {
            _id++;
            Id= _id;
            Name= name;
            Price= price;
            PersonCapacity= personcapacity;

        }
        public string ShowInfo()
        {
            return $"id:{Id} name:{Name} price:{Price}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
