using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int roomNo) 
            : base(roomNo)
        {
            Console.WriteLine("Creating RoomWithABomb");
        }
    }
}
