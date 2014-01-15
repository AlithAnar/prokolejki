using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class Zdarzenie //: IDisposable
        {

        public Zdarzenie()
        {
            ID = _ID;
            _ID++;
        }

        public Zdarzenie(double cp)
            {
            CzasPrzyjscia = cp;
            CzasWykonywania = 0;
            CzasOpuszczenia = 0;
            ID = _ID;
            _ID++;
            }

        public Zdarzenie(Zdarzenie zdarzenie)
            {
            CzasPrzyjscia = zdarzenie.CzasPrzyjscia;
            CzasWykonywania = zdarzenie.CzasWykonywania;
            CzasOpuszczenia = zdarzenie.CzasOpuszczenia;
            ID = zdarzenie.ID;
            }
        public double CzasPrzyjscia { get; set; }
        public double CzasWykonywania { get; set; }
        public double CzasOpuszczenia { get; set; }

        static private int _ID = 0;
        private Zdarzenie zdarzenie;

        public int ID { get; set; }
        public void opuszczenieMaszyny(List<Zdarzenie> lista)
            {

            lista.Add(this);
            }
        public void weszloNaMaszyne() { }
        public void weszloDoKolejki() { }
        public void weszloDoSieci() { }
        public void zeszloZSieci() { }

        public void Dispose()
            {
            GC.SuppressFinalize(this);
            }


        Random randomGenerator = new Random();

        private double losuj(double alfa)
        {
            double x = randomGenerator.NextDouble();
            return -(1 / alfa) * Math.Log(1 - x);
        }

        public double wylosujCzas() 
            {
                CzasPrzyjscia = losuj(60);
                return CzasPrzyjscia;
            }
        }

        
    }
