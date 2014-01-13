using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class Maszyna
        {
        private Zdarzenie zdarzenie { get; set; }
        private bool empty = true;

        public Maszyna()
            {

            }
        public bool isEmpty()
            {
            if (empty == true) return true;
            else return false;
            }

        public Zdarzenie zdejmij()
            {
            using (var kopia = new Zdarzenie(zdarzenie))
                {
                zdarzenie = null;
                empty = true;
                Console.Out.WriteLine("zdjeto " + kopia.ID);
                return kopia;
                }
            }

        public void poloz(Zdarzenie z)
            {
            zdarzenie = z;
            empty = false;
            Console.Out.WriteLine("polozono " + zdarzenie.ID);
            }

        public void print()
            {
            if (isEmpty()) Console.Out.WriteLine("maszyna jest pusta");
            else Console.Out.WriteLine("maszyna " + zdarzenie.ID);
            }

        }
    }
