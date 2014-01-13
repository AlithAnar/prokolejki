using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolejki3.Logika
    {
    static class Program
        {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
        //    Modul sec;
        //    Modul first;
        //    Maszyna m1 = new Maszyna();
        //    Kolejka ko1 = new FIFO(3);
        //    first = new Modul(m1, ko1);
        //    Maszyna m2 = new Maszyna();
        //    Kolejka ko2 = new FIFO(3);
        //    sec = new Modul(m2, ko2);
        //    Polaczenie pol = new Polaczenie(first, sec, 1);
        //    ListaPolaczen lp = new ListaPolaczen(pol);
        //    first.polaczenia = lp;


        //    Console.Out.WriteLine("logi:");
        ////kolejka
        //    ko2.print();
        //    Zdarzenie z1 = new Zdarzenie(0.3);
        //    ko2.put(z1);
        //    ko2.get();
        ////maszyna
        //    m2.print();
        //    m2.poloz(z1);
        //    m2.zdejmij();
        ////modul
        //    first.putQueue(z1);
        //    Modul pom = first.polaczenia.wylosujPolaczenie().ModulOut;
        //    if (!pom.isFull())
        //    {
        //        Zdarzenie pomZ = first.outMachine(0);
        //        pom.putQueue(pomZ);
        //    }

            Application.Run(new Form1());
            }
        }
    }
