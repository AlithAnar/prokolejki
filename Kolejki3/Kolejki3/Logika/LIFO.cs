using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class LIFO : Kolejka
        {
        Stack<Zdarzenie> kolejka;
        public LIFO(int ms)
            {
            MaxSize = ms;
            kolejka = new Stack<Zdarzenie>();
            }

        public override bool put(Zdarzenie zdarzenie)
            {
            if (isFull())
                {
                Console.Out.WriteLine("kolejka jest pelna");
                return false;
                }
            kolejka.Push(zdarzenie);
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
            Zdarzenie pom = kolejka.Pop();
            Console.Out.WriteLine("kolejka starcila " + pom.ID);
            return pom;
            }

        public override void print()
            {
            Console.Out.Write("kolejka ");
            foreach (Zdarzenie z in kolejka)
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
