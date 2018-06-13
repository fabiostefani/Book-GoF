﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}