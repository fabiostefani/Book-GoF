using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory.Factory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public Spell CastSpell { get; set; }
        public override Room MakeRoom(int roomNo)
        {
            return new EnchantedRoom(roomNo, CastSpell);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeddingSpell(room1, room2);
        }
    }
}
