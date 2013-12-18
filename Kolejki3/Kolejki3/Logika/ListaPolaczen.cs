using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class ListaPolaczen : List <Polaczenie>
    {
        public ListaPolaczen (Polaczenie p)
        {
            this.Add(p);
        }

        public Polaczenie wylosujPolaczenie()
        {
            Random r = new Random();
            foreach (Polaczenie pp in this)
            {
                if (pp.chance <= r.NextDouble())
                    return pp;
            }
            return this[0];
        }
    }
}
