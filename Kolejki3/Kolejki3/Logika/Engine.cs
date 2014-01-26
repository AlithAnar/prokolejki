using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolejki3.Logika
{
    class Engine
    {

        List<Modul> listModules;
        public List<Zdarzenie> listEvents;
        public List<Komunikat> listRequest;
        public List<Komunikat> statystyki;
        double engTime;
        float M; 
        //public List<String> listaWydarzen;
        public Form1 MainForm { get; set; }

        public Engine(List<Modul> lm, List<Zdarzenie> lz, List<Komunikat> lw, float m, Form1 mf)
        {
            this.listModules = lm;
            this.listEvents = lz;
            this.listRequest = lw;
            this.M = m;
            if (lz == null)
                this.listEvents = new List<Zdarzenie>();
            if (lw == null)
                this.listRequest = new List<Komunikat>();

            MainForm = mf;
            statystyki = new List<Komunikat>();
           
        }

        internal void run(int stopTime)
        {
            Komunikat helpyRequest;
            Zdarzenie helpyEvent;
            engTime = 0;
            Console.Out.WriteLine(engTime); 
            while (engTime < stopTime)
            {
               //losuj nowe zdarzenie (czyli zadanie do wykonania) i dodaj na koniec listy komunikatów
                newRandomEvent(listEvents);
                //pobierz pierwszy komunikat z listy komunikatów
                helpyRequest = listRequest.First();
                //pobierz zdarzenie którego dotyczył pobrany komunikat  
                helpyEvent = findRequestById(listEvents, helpyRequest.getRequestId());
                //uaktualnij czas, czyli z komunikatu przeczytaj czas
                engTime = helpyRequest.getRequestTime();
                //zareaguj na komunikat (jesli weszło do sytemu to przenieś do modułu, 
                //jesli weszło do kolejki do daj do maszyny, 
                //jeśli jest w maszynie do wyjmij z modułu), każda reakcja generuje komunikat. 
                //Jesli: "weszło do systemu" -> reakcją jest wylosowanie do którego modułu przejść i czy kolejka jest wolna, 
                //jesli tak, to generuje komunikat "weszło do kolejki", 
                //jeśli "weszło do kolejki" to sprawdz maszynę jesli wolna to "weszło do maszyny", 
                //jeśli "weszło do maszyny" to obliczamy czas zakończenia i generujemy komunikat "zeszło z maszyny", 
                //jesli "zeszło z maszyny" to sprawdź czy ma gdzi iść.
                //tak powinno to działać, jeszcze tego wszystkiego nie robi
                systemResponse(helpyRequest, helpyEvent);
                //usuń wykonany już komunikat z listy komunikatów                
                listRequest.RemoveAt(0);
                //usuń wykonany już komunikat z listy komunikatów                
                listRequest.Sort(CompareRequestsById);

                MainForm.akcjeBox.DataSource = null;
                MainForm.akcjeBox.DataSource = statystyki;
                MainForm.akcjeBox.DisplayMember = "Out";
                Console.Out.WriteLine(engTime); 
                Thread.Sleep(1000);
            }
        }

        private void systemResponse(Komunikat helpyRequest, Zdarzenie helpyEvent)
        {
            switch (helpyRequest.getRequestType())
            {
                case "weszło do systemu":
                    weszloDoSystemu(helpyEvent);
                    break;
                case "zeszło z systemu":
                    zeszloZSystemu(helpyEvent);
                    break;
                case "weszło do maszyny":
                    weszloDoMaszyny(helpyEvent);
                    break;
                case "zeszło z maszyny":
                    zeszloZMaszyny(helpyEvent);
                    break;
                case "weszło do bufora":
                    weszloDoBufora(helpyEvent);
                    break;
                case "zeszło z bufora":
                    zeszloZBufora(helpyEvent);
                    break;
                default:
                    break;
            }
        }

        private void zeszloZBufora(Zdarzenie z)
            {
            findFirstModule().machins.First(x => x.isEmpty() == true).put(z);
            newRequest(engTime, "weszło do maszyny", z.ID);
            }



        private void weszloDoBufora(Zdarzenie z)
            {
            z = findFirstModule().buffer.get();
            //newRequest(engTime, "zeszło z bufora", z.ID);
            }
        private void zeszloZSystemu(Zdarzenie z)
            {
            
            }

        private void zeszloZMaszyny(Zdarzenie z)
            {
           
            }

        private void weszloDoMaszyny(Zdarzenie z)
            {
            z.getFromMachine(listEvents);
            engTime += z.timeLeaving;
            newRequest(engTime, "zeszło z maszyny", z.ID);
            }

        private void weszloDoSystemu(Zdarzenie z)
        {
        Modul m = findFirstModule();
        if (!m.buffer.isFull())
            {
            m.putOnQueue(z);
            newRequest(engTime, "weszło do bufora", z.ID);
            }
            
        }

        private Modul findFirstModule()
        {
            foreach (Modul m in listModules)
                if (m.ID == 0)
                    return m;
            return listModules.First();
        }

        private void newRequest(double time, string type, int id)
        {
            listRequest.Add(new Komunikat(time, type, id));
            statystyki.Add(new Komunikat(time, type, id));
        }

        private void newRandomEvent(List<Zdarzenie> lz)
        {
            lz.Add(new Zdarzenie(0));
            lz.Last().randomIncomingTime(M);
            lz.Last().timeIncoming += engTime;
            newRequest(lz.Last().timeIncoming, "weszło do systemu", lz.Last().ID);
        }

        private Zdarzenie findRequestById(List<Zdarzenie> lz, int id)
        {
            foreach (Zdarzenie z in lz)
                if (z.ID == id)
                    return z;
            return lz.First();
        }


        private static int CompareRequestsById(Komunikat x, Komunikat y)
        {
            return x.getRequestTime().CompareTo(y.getRequestTime());
        }

    }
}
