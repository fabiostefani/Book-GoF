
using System;

namespace fabiostefani.io.GoF.Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called target request");
        }
    }
}
