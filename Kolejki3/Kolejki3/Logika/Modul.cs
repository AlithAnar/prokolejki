
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
        public ListaMaszyn maszyny;
        public Kolejka bufor;
        public ListaPolaczen polaczenia;
        public int ID { get ; set; }

        public Modul() { }
        public Modul (Maszyna m, Kolejka k)
        {
            maszyny = new ListaMaszyn();
            maszyny.Add(m);
            bufor = k;
            ID = _ID;
            //_ID++;
        }

        public Modul(ListaMaszyn lm, Kolejka k)
        {
            maszyny = lm;
            bufor = k;
            //_ID++;
        }

        public bool isFull()
        {
            if (bufor.isFull()) return true;
            else return false;
        }

        public void putQueue(Zdarzenie z)
        {
            Console.Out.Write("modul " + ID + " ");
            bufor.put(z);
            if (maszyny.isFree())
                maszyny.freeMachine().poloz(bufor.get());
        }

        public Zdarzenie outMachine(int nr)
        {
            Console.Out.Write("modul " + ID + " ");
            Zdarzenie z = maszyny[nr].zdejmij();
            return z;
        }
    }
}

