using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory.Factory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int roomNo)
        {
            return new RoomWithABomb(roomNo);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}
