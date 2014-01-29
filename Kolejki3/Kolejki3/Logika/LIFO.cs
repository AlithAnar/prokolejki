using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class LIFO : Kolejka
        {
        Stack<Zdarzenie> queueLIFO;
        public LIFO(int ms)
            {
            MaxSize = ms;
            queueLIFO = new Stack<Zdarzenie>();
            }

        public override bool put(Zdarzenie ev)
            {
            if (isFull())
                {
                Console.Out.WriteLine("kolejka jest pelna");
                return false;
                }
            queueLIFO.Push(ev);
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
            ev = queueLIFO.Pop();
            Console.Out.WriteLine("kolejka starcila " + ev.ID);
            return ev;
            }

        public override void print()
            {
            Console.Out.Write("kolejka ");
            foreach (Zdarzenie z in queueLIFO)
                {
                Console.Out.Write(z.ID + " ");
                }
            Console.Out.Write("\n");
            }

        public override string getRuleType()
            {
            return "LIFO";
            }
        }
    }
