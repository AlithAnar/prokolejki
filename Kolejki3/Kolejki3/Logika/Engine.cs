using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Engine
    {

        List<Modul> listaModulow;
        public List<Zdarzenie> listaZdarzen;
        List<Komunikat> listaWydarzen;
        double engTime = 0;
        float m; 
        public bool Simulating;

        public Engine(List<Modul> lm, List<Zdarzenie> lz, List<Komunikat> lw, float m)
        {
            this.listaModulow = lm;
            this.listaZdarzen = lz;
            this.listaWydarzen = lw;
            this.m = m;
            Simulating = false;
            if (lz == null)
                this.listaZdarzen = new List<Zdarzenie>();
            if (lw == null)
                this.listaWydarzen = new List<Komunikat>();
        

        }

        internal void run(int stopTime)
        {
            Komunikat wydarzenie;
            Zdarzenie zdarzenie;

            while (engTime < stopTime)
            {
                noweZdarzenie(listaZdarzen);

                wydarzenie = listaWydarzen.First();

                zdarzenie = findRequestById(listaZdarzen, wydarzenie.getRequestId());

                engTime = wydarzenie.getRequestTime();

                systemResponse(wydarzenie, zdarzenie);
                /*
                 * listaWydarzen.Sort(); //   <-- To dla mnie
                 *
                 * http://msdn.microsoft.com/pl-pl/library/w56d4y5z(v=vs.110).aspx
                 * nazwy na angielski
                 * ładne metody
                 */

                Console.Out.WriteLine(engTime);
               // Thread.Sleep(1000);
            }
        }

        private void systemResponse(Komunikat wydarzenie, Zdarzenie zdarzenie)
        {
            switch (wydarzenie.getRequestType())
            {
                case "weszło do systemu":
                    dodajDoSystemu(zdarzenie);

                    break;
                case "zeszło z systemu":

                    break;
                case "weszło do maszyny":

                    break;
                case "zeszło z maszyny":

                    break;
                case "weszło do bufora":

                    break;
                case "zeszło z bufora":

                    break;
                default:
                    break;
            }
        }

        private void dodajDoSystemu(Zdarzenie z)
        {
            znajdzPierwszyModul().putQueue(z);
            noweWydarzenie("weszło do maszyny 1", z.ID);
        }

        private Modul znajdzPierwszyModul()
        {
            foreach (Modul m in listaModulow)
                if (m.ID == 1)
                    return m;
            return listaModulow.First();
        }

        private void noweWydarzenie(String type, int id)
        {
            listaWydarzen.Add(new Komunikat(engTime, type, id));
        }

        private void noweZdarzenie(List<Zdarzenie> lz)
        {
            lz.Add(new Zdarzenie(0));
            lz.Last().wylosujCzas();
            noweWydarzenie("weszło do systemu", lz.Last().ID);
        }

        private Zdarzenie findRequestById(List<Zdarzenie> lz, int id)
        {
            foreach (Zdarzenie z in lz)
                if (z.ID == id)
                    return z;
            return lz.First();
        }
    }
}
