using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.AbstractFactory
{
    public class EnchantedRoom : Room
    {
        private readonly Spell castSpell;

        public EnchantedRoom(int roomNo, Spell castSpell) 
            : base(roomNo)
        {
            this.castSpell = castSpell;
            Console.WriteLine("Creating EnchantedRoom");
        }
    }
}
