
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    public class ListaMaszyn : List <Maszyna>
    {
        private float lambda { get; set; }

        public bool isFree()
        {
            foreach (Maszyna m in this)
	            if (m.isEmpty()) return true;
	
            return false;
        }

        public Maszyna freeMachine()
        {
            foreach (Maszyna m in this)
                if (m.isEmpty()) return m;

            return null;
        }
    }
}
