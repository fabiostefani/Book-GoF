using fabiostefani.io.GoF.AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new MazeGame().CreateMaze(new MazeFactory());
            Console.WriteLine("EnchantedMameFactory");
            new MazeGame().CreateMaze(new EnchantedMazeFactory());

            new MazeGame().CreateMaze(new BombedMazeFactory());

            Console.ReadKey();
        }
    }
}
