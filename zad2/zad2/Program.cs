﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov c162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov pc_21 = new Zrakoplov("Pilatus", 1200, 1333);
        }
    }
}
