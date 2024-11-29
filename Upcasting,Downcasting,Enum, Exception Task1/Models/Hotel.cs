using Upcasting_Downcasting_Enum__Exception_Task1.Exceptions;

namespace Upcasting_Downcasting_Enum__Exception_Task1.Models
{
    public class Hotel
    {
        private Room[] rooms;
        public string Name { get; set; }


        public Hotel(string name)
        {
            rooms = Array.Empty<Room>();
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[^1] = room;
        }

        public void MakeReservation(int? roomid)
        {
            if (roomid == null)
            {
                throw new NullReferenceException("Room id cannot be null!");
            }

            if (roomid <= 0 || roomid > rooms.Length)
            {
                throw new InvalidIdException($"Invalid Id! The room number {roomid} does not exist in the hotel!");
            }

            var room = rooms[(int)roomid - 1];

            if (room.IsAvailable)
            {
                room.IsAvailable = false;
                Console.WriteLine($"The room number {roomid} has been successfully reserved!");
            }
            else
            {
                throw new NotAvailableException($"The room number {roomid} is not available!");
            }



        }
    }
}
