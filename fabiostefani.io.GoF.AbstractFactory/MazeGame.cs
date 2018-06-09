using fabiostefani.io.GoF.AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class MazeGame
    {
        public void CreateMaze(MazeFactory factory)
        {
            var maze = factory.MakeMaze();
            var r1 = factory.MakeRoom(1);
            var r2 = factory.MakeRoom(2);
            var theDoor = factory.MakeDoor(r1, r2);
            

            r1.SetSide(EnumDirection.North, factory.MakeWall());
            r1.SetSide(EnumDirection.East, theDoor);
            r1.SetSide(EnumDirection.South, factory.MakeWall());
            r1.SetSide(EnumDirection.West, factory.MakeWall());

            r2.SetSide(EnumDirection.North, factory.MakeWall());
            r2.SetSide(EnumDirection.East, factory.MakeWall());
            r2.SetSide(EnumDirection.South, factory.MakeWall());
            r2.SetSide(EnumDirection.West, theDoor);

            maze.AddRoom(r1);
            maze.AddRoom(r2);
        }
    }
}
