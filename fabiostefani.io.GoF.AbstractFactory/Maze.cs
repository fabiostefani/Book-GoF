using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class Maze
    {
        public Maze()
        {
            Rooms = new List<Room>();
            Console.WriteLine("Creating Maze");
        }
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public Room RoomNo(int roomNo)
        {
            return Rooms.Find(x => x.RoomNumber == roomNo);
        }

        public List<Room> Rooms { get; private set; }
    }
}
