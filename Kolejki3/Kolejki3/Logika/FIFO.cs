using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    class FIFO : Kolejka
        {
        Queue<Zdarzenie> queueFIFO;

        public FIFO(int ms)
            {
            MaxSize = ms;
            queueFIFO = new Queue<Zdarzenie>();
            }

        public override bool put(Zdarzenie ev)
            {
            if (isFull())
                {
                Console.Out.WriteLine("kolejka jest pelna");
                return false;
                }
            queueFIFO.Enqueue(ev);
            CurrentSize++;
            Console.Out.WriteLine("kolejka otrzymala " + ev.ID);
            return true;
            }

        public override Zdarzenie get()
            {
            
            if (isEmpty())
                {
                Console.Out.WriteLine("kolejka jest pusta");
                return null;
                }

            Zdarzenie ev;
            CurrentSize--;
            ev = queueFIFO.Dequeue();
            Console.Out.WriteLine("kolejka starcila " + ev.ID);
            return ev;
            }

        public override void print()
            {
            Console.Out.Write("kolejka ");
            foreach (Zdarzenie z in queueFIFO)
                { 
                Console.Out.Write(z.ID + " ");
                }
            Console.Out.Write("\n");
            }

        public override string getRuleType()
            {
            return "FIFO";
            }
        }
    }
