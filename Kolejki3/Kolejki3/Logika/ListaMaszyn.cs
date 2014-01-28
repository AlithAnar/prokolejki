
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    public class ListaMaszyn : List <Maszyna>
    {
        private float lambda { get; set; }  //Ściema, ostatecznie losuje czas w Engine

        //Odpowiada na pytanie czy którakolwiek z maszyn jest wolna
        public bool isFree()
        {
            foreach (Maszyna m in this)
            {
                if (m.isEmpty()) return true;
            }
            return false;
        }

        //Zwraca pierwszą wolną maszynę
        public Maszyna freeMachine()
        {
            foreach (Maszyna m in this)
                if (m.isEmpty()) return m;

            return null;
        }

        //Zdejmuje zdarzenie z listy maszyn. Ty dajesz zdarzenie, on znajduje maszyne i je zdejmuje. Lepiej byłoby po ID nie po zdarzeniu, ale już nie zmienie.
        internal void getOutEvent(Zdarzenie z)
        {
            foreach (Maszyna m in this)
            {
                if (m.getWorkingEvent() != null)
                    if (m.getWorkingEvent().ID == z.ID)
                        m.get();
            }
        }
    }
}
