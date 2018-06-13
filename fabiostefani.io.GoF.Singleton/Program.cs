using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInstance();
            GetInstance();
            GetInstance();
            GetInstance();
            GetInstance();

            GetInstance2();
            GetInstance2();
            GetInstance2();
            GetInstance2();

            Console.ReadKey();
        }

        private static void GetInstance()
        {
            var instance = Singleton.GetInstance();
            Console.WriteLine(instance.GetHashCode());
        }

        private static void GetInstance2()
        {
            var instance = Singleton2.GetInstance();
            Console.WriteLine("Singleton2 " + instance.GetHashCode());
        }
    }
}
