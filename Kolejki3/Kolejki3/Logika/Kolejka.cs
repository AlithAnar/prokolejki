using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    class Kolejka
        {
        public int MaxSize { get; set; }
        public int CurrentSize { get; set; }

        public virtual bool put();

        public virtual Zdarzenie get();

        public bool isEmpty()
            {
            if (CurrentSize == 0) return true; else return false;
            }

        public bool isFull()
            {
            if (CurrentSize == MaxSize) return true; else return false;
            }
        }
    }
