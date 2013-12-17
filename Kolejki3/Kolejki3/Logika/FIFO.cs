using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    class FIFO : Kolejka
        {
        Queue<Zdarzenie> kolejka;

        public FIFO(int ms)
            {
                MaxSize = ms;
            kolejka = new Queue<Zdarzenie>();
            }

        public override bool put(Zdarzenie zdarzenie)
            {
            if (isFull())
                {
                    Console.Out.WriteLine("kolejka jest pelna");
                return false;
                }
            kolejka.Enqueue(zdarzenie);
            CurrentSize++;
            Console.Out.WriteLine("kolejka otrzymala " + zdarzenie.ID);
            return true;
            }

        public override Zdarzenie get()
            {
                if (isEmpty())
                {
                    Console.Out.WriteLine("kolejka jest pusta");
                    return null;
                }
            CurrentSize--;
            Zdarzenie pom = kolejka.Dequeue();
            Console.Out.WriteLine("kolejka starcila " + pom.ID);
            return pom;
            }

        public override void print()
        {
            Console.Out.Write("kolejka ");
            foreach ( Zdarzenie z in kolejka)
            {
                Console.Out.Write(z.ID+" ");
            }
            Console.Out.Write("\n");
        }

        }
    }
