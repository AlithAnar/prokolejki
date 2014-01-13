
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    public class Polaczenie
    {
        public float Chance { get; set; }
        public Modul ModulIn { get; set; }
        public Modul ModulOut { get; set; }
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Polaczenie (Modul modIn, Modul modOut, float percent, Point p1, Point p2)
        {
            ModulIn = modIn;
            ModulOut = modOut;
            Chance = percent;
            Point1 = p1;
            Point2 = p2;
        }
        
    }
}

