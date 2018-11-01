using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Command
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Execute Open Command");
        }
    }
}
