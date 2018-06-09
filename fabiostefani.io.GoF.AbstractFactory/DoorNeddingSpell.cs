﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class DoorNeddingSpell : Door
    {
        public DoorNeddingSpell(Room room1, Room room2) 
            : base(room1, room2)
        {
            Console.WriteLine("Creating DoorNeddingSpell");
        }
    }
}
