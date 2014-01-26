using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class Maszyna
        {
        private Zdarzenie workingEvent { get; set; }
        private bool empty = true;

        public Maszyna()
            {

            }

        public bool isEmpty()
            {
            if (empty == true) return true;
            else return false;
            }

        public Zdarzenie get()
            {
            Zdarzenie ev = new Zdarzenie(workingEvent);
            workingEvent = null;
            empty = true;
            ev.timeLeaving += 60;
            Console.Out.WriteLine("zdjeto " + ev.ID);
            return ev;
            }

        public void put(Zdarzenie z)
            {
            workingEvent = z;
            empty = false;
            Console.Out.WriteLine("polozono " + workingEvent.ID);
            }

        public void print()
            {
            if (isEmpty()) Console.Out.WriteLine("maszyna jest pusta");
            else Console.Out.WriteLine("maszyna " + workingEvent.ID);
            }

        }
    }
