using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class Room : MapSite
    {
        public Room(int roomNo)
        {
            RoomNumber = roomNo;
            Sides = new List<MapSite>();

            Console.WriteLine("Creating Room Nº " + roomNo);
        }
        public List<MapSite> Sides { get; private set; }
        public int RoomNumber { get; private set; }


        public MapSite GetSide(EnumDirection direction)
        {
            return null;
        }

        public void SetSide(EnumDirection direction, MapSite mapSite)
        {
            Sides.Add(mapSite);
            
        }
    }
}
