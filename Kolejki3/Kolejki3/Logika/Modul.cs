
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
        public bool waiting = false;
        public int waitingEventID = -1;

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

        //Kladzie zdarzenie na kolejce
        public void putOnQueue(Zdarzenie z)
        {
            Console.Out.Write("modul " + ID + " ");
            buffer.put(z);
        }

        //Zwraca pierwszy element z kolejki
        public Zdarzenie getFromQueue()
        {
            return buffer.get();
        }

        //kładzie zdarzenie na maszynę
        public void putOnMachine(Zdarzenie z)
        {
            machins.freeMachine().put(z); //<---!!
            Console.Out.Write("modul " + ID + " na maszynę zadanie " + z.ID);
        }

        //Zdejmuje zdarzenie z maszyny
        public void getOutEvent(Zdarzenie z)
        {
            machins.getOutEvent(z);
        }

        public bool isWaiting()
        {
            return waiting;
        }

        public void wait()
        {
            waiting = true;
        }

        public void stopWaiting()
        {
            waiting = false;
            waitingEventID = -1;
        }

        public int getWaitingEventID()
        {
            return waitingEventID;
        }
    }
}

