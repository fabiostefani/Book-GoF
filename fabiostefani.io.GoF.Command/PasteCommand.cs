using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Command
{
    public class PasteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Execute Past Command");
        }
    }
}
