
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    public class ListaPolaczen : List<Polaczenie>
        {
        public ListaPolaczen(Polaczenie p)
            {
            this.Add(p);
            }

        //Losuje połączenie z listy według wag połączeń
        public Polaczenie randomConnection()
            {
            Random r = new Random();
            foreach (Polaczenie pp in this)
                if (pp.Chance <= r.NextDouble())
                    return pp;
            return this[0];
            }
        }

    }
