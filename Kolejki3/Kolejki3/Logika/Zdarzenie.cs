using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    class Zdarzenie
        {
        public Zdarzenie(double cp)
            {
            CzasPrzyjscia = cp;
            CzasWykonywania = 0;
            CzasOpuszczenia = 0;
            ID = _ID;
            _ID++;
            }
        public double CzasPrzyjscia { get; set; }
        public double CzasWykonywania { get; set; }
        public double CzasOpuszczenia { get; set; }

        static private int _ID = 0;

        public int ID { get; set; }
        public void opuszczenieMaszyny() { }
        public void weszloNaMaszyne()        { }
        public void weszloDoKolejki() { }
        public void weszloDoSieci() { }
        public void zeszloZSieci() { }

        }
    }
