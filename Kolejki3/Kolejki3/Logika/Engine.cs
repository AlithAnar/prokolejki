﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolejki3.Logika
{
    class Engine
    {
        public int _END_MODUL = 3;      // ID moduły, który jest już poza systemem
        private static int _START_MODUL = 0;    // ID pierwszego modułu do którego wejdzie zadanie

        List<Modul> listModules;
        public List<Zdarzenie> listEvents;
        public List<Komunikat> listRequest;
        public List<Komunikat> stats;
        public bool Simulating { get; set; }
        double engTime;
        float M;    //mi -> losuje czas wykonania się zadania na maszynie
        float L;    //lambda -> losuje czas przyjścia zadań
        public Form1 MainForm { get; set; }

        public delegate void ProgressUpdate(List<Komunikat> list, string s1, string s2, string s3, string s4);
        public event ProgressUpdate OnProgressUpdate;
        string avarageIO = "";
        string avarageInBuffer = "";
        string absolutePerformance = "";
        string relativePerformance = "";
        int eventsout = 0;
        int eventsrejected = 0;
        double queueTime = 0;


        public Engine(List<Modul> lm, List<Zdarzenie> lz, List<Komunikat> lw, float m, Form1 mf, float lambda)
        {
            this.listModules = lm;
            this.listEvents = lz;
            this.listRequest = lw;
            this.M = m;
            this.L = lambda;
   
            MainForm = mf;
            stats = new List<Komunikat>();
            if (lz == null)
                this.listEvents = new List<Zdarzenie>();
            if (lw == null)
                this.listRequest = new List<Komunikat>();

            MainForm = mf;
            stats = new List<Komunikat>();
           
        }

        internal void run(int tick)
        {
            Komunikat helpyRequest;
            Zdarzenie helpyEvent;
            engTime = 0;
            double t1 = 0;
            double lastRandomTime = 0;

            Console.Out.WriteLine(engTime); 
            Simulating = true;
            // while (engTime < stopTime)
            while (true)
            {
            t1 = engTime;
               //losuj nowe zdarzenie (czyli zadanie do wykonania) i dodaj na koniec listy komunikatów
                newRandomEvent(listEvents, lastRandomTime);
                    //zapamiętaj wylosowany czas ostatniego zdarzenia (na jego podstawie jest losowaney czas pojawienia się kolejnego zadania)
                lastRandomTime = getLastEventIncomingTime();
                //pobierz pierwszy komunikat z listy komunikatów
                helpyRequest = listRequest.First();
                //pobierz zdarzenie którego dotyczył pobrany komunikat  
                helpyEvent = findRequestById(listEvents, helpyRequest.getRequestId());
                //uaktualnij czas, czyli z komunikatu przeczytaj czas
                engTime = helpyRequest.getRequestTime();
                queueTime+=Math.Abs(t1-engTime);
                //Console.WriteLine(" queue time " + (t1 - engTime));
                //zareaguj na komunikat (jesli weszło do sytemu to przenieś do modułu, 
                //jesli weszło do kolejki do daj do maszyny, 
                //jeśli jest w maszynie do wyjmij z modułu), każda reakcja generuje komunikat. 
                //Jesli: "weszło do systemu" -> reakcją jest wylosowanie do którego modułu przejść i czy kolejka jest wolna, 
                //jesli tak, to generuje komunikat "weszło do kolejki", 
                //jeśli "weszło do kolejki" to sprawdz maszynę jesli wolna to "weszło do maszyny", 
                //jeśli "weszło do maszyny" to obliczamy czas zakończenia i generujemy komunikat "zeszło z maszyny", 
                //jesli "zeszło z maszyny" to sprawdź czy ma gdzi iść.
                    //jeśli "odrzucone z systemu" to kolejka jest pełna, a zadanie wypadło z obiegu
                systemResponse(helpyRequest, helpyEvent);
                    //dodanie komunikatu do statystyk (historia komunikatów)
                stats.Add(helpyRequest);
                Console.Out.WriteLine("--------------  "+helpyRequest.ToString());

                //usuń wykonany już komunikat z listy komunikatów                
                listRequest.RemoveAt(0);
                    //posortowanie list komunikatów, aby najwcześniejsze było na pierwszym miejscu              
                listRequest.Sort(CompareRequestsByTime);
                    //wyświetlanie komunikatów
                updateStats();
                if (OnProgressUpdate != null)
                    {
                    OnProgressUpdate(stats, avarageIO, avarageInBuffer, absolutePerformance, relativePerformance);
                    }

                Console.Out.WriteLine(engTime); 
                Thread.Sleep(tick);         //  <-----  może usunąć?
                if (!Simulating) break;
                }
            }

        private void updateStats()
            {
            double sum = 0, sum2=0;
            foreach (Komunikat ko in stats)
                {
                if (ko.getRequestType() == "wyszło z systemu")
                    {
                    double outtime = ko.getRequestTime();
                    int id = ko.getRequestId();
                    Komunikat ki = stats.First(x => x.getRequestId() == id && x.getRequestType() == "weszło do systemu");
                    if (ki != null)
                        {
                        sum += outtime - ki.getRequestTime();
                        }
                    }

                if (ko.getRequestType() == "zeszło z bufora")
                    {
                    double outtime = ko.getRequestTime();
                    int id = ko.getRequestId();
                    Komunikat ki = stats.First(x => x.getRequestId() == id && x.getRequestType() == "weszło do bufora");
                    if (ki != null)
                        {
                        sum2 += outtime - ki.getRequestTime();
                        }
                    }

                }

            if (eventsout != 0)
                {
                sum = sum / (double)eventsout;
                sum2 = sum2 / (double)eventsout;
                avarageInBuffer = sum2.ToString();
                avarageIO = sum.ToString();
               // avarageInBuffer = (queueTime / (double)eventsout).ToString();
                   
                double t = Math.Abs( 1 - ((double)eventsrejected / (double)eventsout) );
                double t2 = t * (1/L);
                absolutePerformance = t.ToString();
                relativePerformance = t2.ToString();
                }                
            }

        private double getLastEventIncomingTime()
        {
            //pobranie czasu ostatniego wylosowanego zadania
            return listEvents.Last().timeIncoming;
        }

        private void systemResponse(Komunikat helpyRequest, Zdarzenie helpyEvent)
        {
            switch (helpyRequest.getRequestType())
            {
                case "weszło do systemu":
                    weszloDoSystemu(helpyEvent, helpyRequest);      //czasem trzeba przekazać kontekst komunikatu. Jak nazwa sugeruje jest w komunikacie, 
                    break;                                          //    nie w zdarzeniu. Optymalnie możnaby usunąć helpyRequest, bo on jest wyciągany z komunikatu.
                case "wyszło z systemu":
                    wyszloZSystemu(helpyEvent);
                    break;
                case "weszło do maszyny":
                    weszloDoMaszyny(helpyEvent, helpyRequest);
                    break;
                case "zeszło z maszyny":
                    zeszloZMaszyny(helpyEvent, helpyRequest);
                    break;
                case "weszło do bufora":
                    weszloDoBufora(helpyEvent, helpyRequest);
                    break;
                case "zeszło z bufora":
                    zeszloZBufora(helpyEvent, helpyRequest);
                    break;
                case "odrzucone z systemu":
                    odrzuconeZSystemu(helpyEvent);
                    break;
                case "sprawdzenie kolejnego modułu":
                    sprawdzenieKolejnegoModulu(helpyEvent, helpyRequest);
                    break;
                default:
                    break;
            }
        }

        private void sprawdzenieKolejnegoModulu(Zdarzenie z, Komunikat k)
        {// TODO wiele maszyn
            Modul futureModule = ((Modul)k.getKontekst()).listConnections.randomConnection().ModulOut;
            Console.WriteLine("sprawdzam modul " + futureModule.ID);
            //czy moduł na który chce przejść zadanie po wykonaniu się na maszynie jest już poza systemem (_END_MODUL)
            if (futureModule.ID == _END_MODUL)
            {
                newRequest(engTime, "zeszło z maszyny", z.ID, ((Modul)k.getKontekst()));
                newRequest(engTime, "wyszło z systemu", z.ID, ((Modul)k.getKontekst()));
                return;
            }  
            
            //jesli przyszła kolejka jest wolna
            if (futureModule.buffer.isFree())
            {
                //to umieść w niej zadanie
                futureModule.putOnQueue(z);
                newRequest(engTime, "zeszło z maszyny", z.ID, ((Modul)k.getKontekst()));
                newRequest(engTime, "weszło do bufora", z.ID, futureModule);
                return;
            }
            
            //jesli kolejka jest pełna
            if (futureModule.buffer.isFull())
            {
                futureModule.wait();
                return;
            }
        }

        private void odrzuconeZSystemu(Zdarzenie z)
            {
            eventsrejected++;
            //skoro nie ma miejsca w kolejce, to wypada również z listy
            listEvents.Remove(z);
            }

        private void zeszloZBufora(Zdarzenie z, Komunikat k)
            {
                //gdy zadanie zeszło z kolejki to wchodzi na maszynę
                ((Modul)k.getKontekst()).putOnMachine(z);
                newRequest(engTime, "weszło do maszyny", z.ID, ((Modul)k.getKontekst()));   //tu przekazuję kontekst. Jest typu Object, bo myślałem, 
                                                                                        //  że może łatwie będzie przenosić różne, ale w praktyce są wszędzie Modul. 
            // TODO czy to działa?
            foreach (Modul m in listModules)
            {
                if (m.isWaiting())
                {
                    m.stopWaiting();
                    newRequest(engTime, "sprawdzenie kolejnego modułu", m.getWaitingEventID(), ((Modul)k.getKontekst()));
                }
            }
            
        }
        private void weszloDoBufora(Zdarzenie z, Komunikat k)
            {
           // z = findFirstModule().buffer.get();

                //sprawdzamy czy zadanie może wejść na maszynę
                if (((Modul)k.getKontekst()).machins.isFree())
                {
                    //jeśli tak to już ściągamy je z kolejki
                    ((Modul)k.getKontekst()).getFromQueue();
                    newRequest(engTime, "zeszło z bufora", z.ID, ((Modul)k.getKontekst()));
                }
            }

        private void wyszloZSystemu(Zdarzenie z)
            {
            eventsout++;
                //czyszczę listę zdarzeń, gdy zdarzenie skończy swój cykl życia
                listEvents.Remove(z);

            }

        private void zeszloZMaszyny(Zdarzenie z, Komunikat k)
            {
                    //skoro tak to zdejmij zadanie z maszyny
                    ((Modul)k.getKontekst()).getOutEvent(z);
                    //sprawdź czy coś czeka w kolejce
                if (!((Modul)k.getKontekst()).buffer.isEmpty())
                    {
                        //TYLKO przeczytaj ID zadania oczekującego, bo "zeszło z bufora" usunie je już z kolejki
                        int id = ((Modul)k.getKontekst()).getFromQueue().ID;
                        newRequest(engTime, "zeszło z bufora", id, ((Modul)k.getKontekst()));
                    }
                }

        private void weszloDoMaszyny(Zdarzenie z, Komunikat k)
            {
            //z.getFromMachine(listEvents);
            //engTime += z.timeLeaving;

                //wylosuj czas opuszczenia maszyny
                double leavingTime = z.randomTime(M) + engTime;
                newRequest(leavingTime, "sprawdzenie kolejnego modułu", z.ID, ((Modul)k.getKontekst()));
            }

        private void weszloDoSystemu(Zdarzenie z, Komunikat k)
        {
            //jesli kolejka jest pusta
            if (!((Modul)k.getKontekst()).buffer.isFull())
        {
                //to umieść w niej zadanie
                ((Modul)k.getKontekst()).putOnQueue(z);
                newRequest(engTime, "weszło do bufora", z.ID, ((Modul)k.getKontekst()));
            }
            else
            {
                //w przeciwnym razie odrzuć zadanie z systemu
                newRequest(engTime, "odrzucone z systemu", z.ID, ((Modul)k.getKontekst()));
            }
            }

        private Modul findFirstModule()
        {
            //znajdź moduł startowy, taki do którego najpierw wejdą zadania (_START_MODUL)
            foreach (Modul m in listModules)
                if (m.ID == _START_MODUL)
                    return m;
            return listModules.First();
        }

        private void newRequest(double time, string type, int id, Object kontekst)
        {
            //stwórz i dodaj komunikat
            listRequest.Add(new Komunikat(time, type, id, kontekst));
        }

        private void newRandomEvent(List<Zdarzenie> lz, double lastRandomEvent)
        {
            //wylosuj nowe zdarzenie (zadanie)
            lz.Add(new Zdarzenie(0));
            lz.Last().randomTime(L);
            lz.Last().timeIncoming += lastRandomEvent;
            newRequest(lz.Last().timeIncoming, "weszło do systemu", lz.Last().ID, findFirstModule());
        }

        private Zdarzenie findRequestById(List<Zdarzenie> lz, int id)
        {
            //znajdz zdarzenie na liście zdarzeń (wiem ,że lista zdarzeń jest atrybutem, ale niech zostanie już)
            foreach (Zdarzenie z in lz)
                if (z.ID == id)
                    return z;
            return lz.First();
        }

        //To jest komperator, metoda która porównuje komunikaty. Metoda niezbędna do sortowania.
        private static int CompareRequestsByTime(Komunikat x, Komunikat y)
        {
                if (x.getRequestTime() == y.getRequestTime())
            {
                if (x.getRequestType() == "zeszło z maszyny" && y.getRequestType() == "wyszło z systemu")
                    return -1;
                if (x.getRequestType() == "zeszło z maszyny" && y.getRequestType() == "weszło do bufora")
                    return -1;
                if (y.getRequestType() == "zeszło z maszyny" && x.getRequestType() == "wyszło z systemu")
                    return 1;
                if (y.getRequestType() == "zeszło z maszyny" && x.getRequestType() == "weszło do bufora")
                    return 1;
                    return 0;
            }
                else if (x.getRequestTime() > y.getRequestTime())
                    return 1;
                else
                    return -1;
        }
    }
}
