using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paweł_Tymczyk
{
    class Samsung: Mobile
    {
        private bool czyDualSim;

        public bool CzyDualSim
        {
            get;
            set;
        }

        public void WlaczWiFi()
        {
            Console.WriteLine("WiFi zostało włączone.");
        }

        public void ZrobZdjecie()
        {
            Console.WriteLine("Zdjecie zostalo zrobione standardowym trybem aparatu(czyli tylnim).");
        }

        public void ZrobZdjecie(string trybKamery)
        {
            if (trybKamery == "Przód")
                Console.WriteLine("Zdjecie zrobiono przednim aparatem");
            else if (trybKamery == "Tył")
                Console.WriteLine("Zdjęcie zostało zrobione tylnim aparatem.");
            else
                Console.WriteLine("Została wybrana błędna kamera lub w ogóle nie została wybrana.");

        }


    }
}
