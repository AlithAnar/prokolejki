<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Polaczenie
    {
        public float chance { get; set; }
        public Modul modulIn { get; set; }
        public Modul modulOut { get; set; }

        public Polaczenie (Modul modIn, Modul modOut, float percent)
        {
            modulIn = modIn;
            modulOut = modOut;
            chance = percent;
        }
        
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Polaczenie
    {
        public float chance { get; set; }
        public Modul modulIn { get; set; }
        public Modul modulOut { get; set; }

        public Polaczenie (Modul modIn, Modul modOut, float percent)
        {
            modulIn = modIn;
            modulOut = modOut;
            chance = percent;
        }
        
    }
}
>>>>>>> c5f2c03e813084c1da863e281b69f566a4e88c98
