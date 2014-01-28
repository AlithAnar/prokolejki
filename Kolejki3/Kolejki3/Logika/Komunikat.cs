using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejki3.Logika
{
    public class Komunikat
    {
        public String Out { get { return ToString(); }}  
        double requestTime; //czas wydarzenia komunikatu
        string requestType; //typ (tekst) komunikatu
        int requestId;      //ID komunikatu
        Object kontekst;    //Obiek będący kontekstem komunikatu. W praktyce zawsze to Module, ale może być cokolwiek.

        public Komunikat(double time, string type, int id, Object o)
        {
            requestTime = time;
            requestId = id;
            requestType = type;
            kontekst = o;
        }

        public Object getKontekst()
        {
            return kontekst;
        }

        public void setKontekst(Object k)
        {
            kontekst = k;
        }

        public double getRequestTime()
        {
           // Console.Out.WriteLine("time: " + requestTime + " " + requestType);
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

        public override string ToString()
            {
            //Console.Out.WriteLine("----------------------Z: " + requestId + " " + requestType + " :: " + requestTime);
            return "Z: " + requestId + " " + requestType + " :: " + requestTime;
            }

    }
}
