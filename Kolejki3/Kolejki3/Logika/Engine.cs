using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Engine
    {

        List<Modul> listaModulow;
        public List<Zdarzenie> listaZdarzen;
        List<Komunikat> listaWydarzen;
        double engTime = 0;

        public Engine(List<Modul> lm, List<Zdarzenie> lz, List<Komunikat> lw)
        {
            this.listaModulow = lm;
            this.listaZdarzen = lz;
            this.listaWydarzen = lw;

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
             //engTime++;
                //wylosuj z-darzenie
                //pobierz wy-darzenie z listy
                //switch
                //  case
                //    dodaj czas wydarzenia + opis
                //    wykonaj polecenie
                //sort

                

                noweZdarzenie(listaZdarzen);
                

                wydarzenie = listaWydarzen.First();

                zdarzenie = listaZdarzen.First();

                engTime = wydarzenie.getRequestTime();

                switch (wydarzenie.getRequestType())
                {
                    case "weszło do systemu":
                        dodajDoSystemu(zdarzenie);
                        
                        break;
                    case "weszło do maszyny":

                        break;
                    case "weszło do maszyny1":

                        break;
                    case "weszło do maszyny2":

                        break;
                    case "weszło do maszyny3":

                        break;
                    case "weszło do maszyny4":

                        break;
                    default:
                        break;
                }

                
/*
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
                */
                Console.Out.WriteLine(engTime);
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
    }
}
