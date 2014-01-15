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
        List<String> listaWydarzen;
        float engTime = 0, m = 0;
        public bool Simulating { get; set; }

        public Engine(List<Modul> lm, List<Zdarzenie> lz, List<String> lw, float m)
        {
            this.listaModulow = lm;
            this.listaZdarzen = lz;
            this.listaWydarzen = lw;
            this.m = m;
            Simulating = false;
            if (lz == null)
                this.listaZdarzen = new List<Zdarzenie>();
            if (lw == null)
                this.listaWydarzen = new List<string>();
        

        }


        internal void run(int stopTime)
        {
            String wydarzenie;
            Zdarzenie pierwsze;

            while (engTime < stopTime)
            {
                engTime++;
                //wylosuj z-darzenie
                //pobierz wy-darzenie z listy
                //switch
                //  case
                //    dodaj czas wydarzenia + opis
                //    wykonaj polecenie
                //sort

                noweZdarzenie(listaZdarzen);
                noweWydarzenie("weszło do systemu");

                wydarzenie = listaWydarzen.First();
         
                switch (wydarzenie)
                {
                    case "1":
                        break;
                    default:
                        break;
                }

                pierwsze = listaZdarzen.First();

                if (wydarzenie.Contains("weszło do systemu"))
                {
                    dodajDoSystemu(pierwsze);
                    noweWydarzenie("weszło do maszyny 1");
                }
                if (wydarzenie.Contains("weszło do maszyny"))
                {
                    dodajDoSystemu(pierwsze);
                    noweWydarzenie("weszło do wyszło z maszyny 1");
                }

                Console.Out.WriteLine(engTime);
                Thread.Sleep(1000);
                


                
            }
        }

        private void dodajDoSystemu(Zdarzenie z)
        {
            znajdzPierwszyModul().putQueue(z);
        }

        private Modul znajdzPierwszyModul()
        {
            foreach (Modul m in listaModulow)
                if (m.ID == 1)
                    return m;
            return listaModulow.First();
        }

        private void noweWydarzenie(String type)
        {
            listaWydarzen.Add(engTime + ": " + type);
        }

        private void noweZdarzenie(List<Zdarzenie> lz)
        {
            lz.Add(new Zdarzenie(0));
            lz.Last().wylosujCzas();
        }
    }
}
