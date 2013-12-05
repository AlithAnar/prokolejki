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

        public FIFO()
            {
            kolejka = new Queue<Zdarzenie>();
            }

        public override bool put(Zdarzenie zdarzenie)
            {
            if (isFull())
                {
                return false;
                }
            kolejka.Enqueue(zdarzenie);
            CurrentSize++;
            return true;

            }

        public override Zdarzenie get()
            {
            if (isEmpty()) return null;
            CurrentSize--;
            return kolejka.Dequeue();
            }


        }
    }
