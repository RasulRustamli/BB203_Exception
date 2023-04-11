using BB203_Exception.Exceptions;
using BB203_Exception.Models;

namespace BB203_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("bbb", 5, 2);
            Room room2 = new Room("bb", 2, 2);
            Hotel hotel=new Hotel("bdu");
            hotel.AddRoom(room);
            hotel.AddRoom(room2);
            try
            {
                hotel.MakeReservation(1);
                hotel.MakeReservation(1);

            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}