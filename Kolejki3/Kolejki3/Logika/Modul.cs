<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Modul
    {
        static private int _ID = 0;
        private ListaMaszyn maszyny;
        private Kolejka bufor;
        public ListaPolaczen polaczenia;
        public int ID { get; set; }

        public Modul (Maszyna m, Kolejka k)
        {
            maszyny = new ListaMaszyn();
            maszyny.Add(m);
            bufor = k;
            ID = _ID;
            _ID++;
        }

        public Modul(ListaMaszyn lm, Kolejka k)
        {
            maszyny = lm;
            bufor = k;
            _ID++;
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Modul
    {
        static private int _ID = 0;
        private ListaMaszyn maszyny;
        private Kolejka bufor;
        public ListaPolaczen polaczenia;
        public int ID { get; set; }

        public Modul (Maszyna m, Kolejka k)
        {
            maszyny = new ListaMaszyn();
            maszyny.Add(m);
            bufor = k;
            ID = _ID;
            _ID++;
        }

        public Modul(ListaMaszyn lm, Kolejka k)
        {
            maszyny = lm;
            bufor = k;
            _ID++;
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
>>>>>>> c5f2c03e813084c1da863e281b69f566a4e88c98
