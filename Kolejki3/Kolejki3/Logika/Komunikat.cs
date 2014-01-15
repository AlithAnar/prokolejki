using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    class Komunikat
    {
        double requestTime;
        string requestType;
        int requestId;
        int requestDetail { set; get; }

        public Komunikat(double time, string type, int id)
        {
            requestTime = time;
            requestId = id;
            requestType = type;
        }


        public double getRequestTime()
        {
            Console.Out.WriteLine("time: " + requestTime + " " + requestType);
            return requestTime;
        }
        
        public string getRequestType()
        {
            return requestType;
        }

        public int getRequestId()
        {
            return requestId;
        }

    }
}
