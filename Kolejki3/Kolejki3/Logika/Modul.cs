
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    public class Modul
    {
        static private int _ID = 0;
        public ListaMaszyn machins;
        public Kolejka buffer;
        public ListaPolaczen listConnections;
        public int ID { get ; set; }

        public Modul() { }
        public Modul (Maszyna m, Kolejka k)
        {
            machins = new ListaMaszyn();
            machins.Add(m);
            buffer = k;
            ID = _ID;
        }

        public Modul(ListaMaszyn lm, Kolejka k)
        {
            machins = lm;
            buffer = k;
        }

        public bool isFull()
        {
            if (buffer.isFull()) return true;
            else return false;
        }

        public void putOnQueue(Zdarzenie z)
        {
            Console.Out.Write("modul " + ID + " ");
            buffer.put(z);
            if (machins.isFree())
                machins.freeMachine().put(buffer.get());
        }

        public Zdarzenie getFromMachine(int nr)
        {
            Console.Out.Write("modul " + ID + " ");
            Zdarzenie z = machins[nr].get();
            return z;
        }
    }
}

