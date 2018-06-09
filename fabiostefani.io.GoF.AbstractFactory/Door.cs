using System;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class Door : MapSite
    {
        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;

            Console.WriteLine("Creating Door with Room1 " + room1.RoomNumber + " and Room2 " + room2.RoomNumber);
        }

        public Room Room1 { get; set; }
        public Room Room2 { get; set; }
        public bool IsOpen { get; set; }

        public Room OtherSideFrom(Room room)
        {
            return null;
        }
    }
}
