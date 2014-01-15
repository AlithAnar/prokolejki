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

        List<Modul> listModules;
        public List<Zdarzenie> listEvents;
        List<Komunikat> listRequest;
        double engTime;
        float M; 
        public bool Simulating;

        public Engine(List<Modul> lm, List<Zdarzenie> lz, List<Komunikat> lw, float m)
        {
            this.listModules = lm;
            this.listEvents = lz;
            this.listRequest = lw;
            this.M = m;
            Simulating = false;
            if (lz == null)
                this.listEvents = new List<Zdarzenie>();
            if (lw == null)
                this.listRequest = new List<Komunikat>();
        }

        internal void run(int stopTime)
        {
            Komunikat helpyRequest;
            Zdarzenie helpyEvent;
            engTime = 0;

            while (engTime < stopTime)
            {
                newRandomEvent(listEvents);

                helpyRequest = listRequest.First();
                
                helpyEvent = findRequestById(listEvents, helpyRequest.getRequestId());

                engTime = helpyRequest.getRequestTime();

                systemResponse(helpyRequest, helpyEvent);
                
                listRequest.RemoveAt(0);

                listRequest.Sort(CompareRequestsById);

                Console.Out.WriteLine(engTime);
               // Thread.Sleep(1000);
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

        private void weszloDoSystemu(Zdarzenie z)
        {
            findFirstModule().putOnQueue(z);
            newRequest(engTime, "weszło do maszyny 1", z.ID);
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
