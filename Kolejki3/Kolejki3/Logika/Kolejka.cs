using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
    {
    abstract class Kolejka
        {
        public int MaxSize { get; set; }
        public int CurrentSize { get; set; }

        
        public abstract bool put(Zdarzenie zdarzenie);
        public abstract Zdarzenie get();
        public abstract void print();

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
