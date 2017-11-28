using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paweł_Tymczyk
{
    class Mobile
    {
        protected string kartaSim;
        protected string numerIMEI;
        protected int pamiecWewnetrzna;
        protected string procesor;

        public string KartaSim
        {
            get; 
            set; 
        }

        public int PamiecWewnetrzna
        {
            get { return pamiecWewnetrzna; }
        }

        public string Procesor
        {
            get { return procesor; }
        }

        public void OdbierzPolaczenie()
        {
            Console.WriteLine("Połączenie zostało odebrane.");
        }

        public void PobierzNumerIMEI()
        {
            Console.WriteLine("Numer IMEI został pobrany do pamięci.");
        }

        public void WykonajPolaczenie()
        {
            Console.WriteLine("Połączenie jest wykonywane");
        }

        public void WyslijSMS()
        {
            Console.WriteLine("Napisz treść SMS'a (w jednej linijce):");
            Console.ReadLine();
            Console.WriteLine("SMS został wysłany.");
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Zdjęcie zostało zrobione.");
        }


    }
}
