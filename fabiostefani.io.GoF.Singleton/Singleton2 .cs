using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Singleton
{
    public class Singleton2
    {
        private static readonly Singleton2 _instance = new Singleton2();
        private Singleton2()
        {

        }

        public static Singleton2 GetInstance()
        {
            return _instance;
        }
    }
}
