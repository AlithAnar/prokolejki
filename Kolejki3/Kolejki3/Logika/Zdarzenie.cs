using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class Zdarzenie
        {
        public double timeIncoming { get; set; } 
        //public double time { get; set; }
        public double timeLeaving { get; set; }  //?

        static private int _ID = 0;
        public int ID { get; set; }
        Random randomGenerator = new Random();

       // private Zdarzenie ev;

        public Zdarzenie()
        {
            ID = _ID;
            _ID++;
        }

        public Zdarzenie(double cp)
            {
            timeIncoming = cp;
           // CzasWykonywania = 0;
            timeLeaving = 0;
            ID = _ID;
            _ID++;
            }

        public Zdarzenie(Zdarzenie ev)
            {
            timeIncoming = ev.timeIncoming;
            //CzasWykonywania = zdarzenie.CzasWykonywania;
            timeLeaving = ev.timeLeaving;
            ID = ev.ID;
            }
        
        public void getFromMachine(List<Zdarzenie> le)
            {
            le.Add(this);
            }

        private double random(double alfa)
        {
            double x = randomGenerator.NextDouble();
            return -(1 / alfa) * Math.Log(1 - x);
        }

        public double randomTime(double alfa) 
            {
                timeIncoming = Math.Abs( random(alfa) );
                return timeIncoming;
            }

        }
    }
