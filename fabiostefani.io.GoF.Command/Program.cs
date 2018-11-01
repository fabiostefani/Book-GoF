using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var open = new OpenCommand();
            var paste = new PasteCommand();

            open.Execute();
            paste.Execute();
            Console.ReadKey();
        }
    }
}
