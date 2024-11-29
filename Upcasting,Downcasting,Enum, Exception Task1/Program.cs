using Upcasting_Downcasting_Enum__Exception_Task1.Exceptions;
using Upcasting_Downcasting_Enum__Exception_Task1.Models;

namespace Upcasting_Downcasting_Enum__Exception_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Room1", 100, 1);
            Room room2 = new Room("Room2", 100, 15);

            Hotel hotel = new Hotel("City Hotel");

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            room1.ShowInfo();
            room2.ShowInfo();

            try
            {
                hotel.MakeReservation(null);
                hotel.MakeReservation(1);
               
            }
            catch (InvalidIdException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            room1.ShowInfo();

        }
    }
}
