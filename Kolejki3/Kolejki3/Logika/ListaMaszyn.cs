<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class ListaMaszyn : List <Maszyna>
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class ListaMaszyn : List <Maszyna>
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
>>>>>>> c5f2c03e813084c1da863e281b69f566a4e88c98
