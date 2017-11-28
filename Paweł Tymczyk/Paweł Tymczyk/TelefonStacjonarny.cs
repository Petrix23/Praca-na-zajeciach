using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paweł_Tymczyk
{
    class TelefonStacjonarny: IStacjonarny
    {
        private int numer;
        private int starePoloczenie= 123456789;

        public TelefonStacjonarny(string numer)
        {
            this.numer = Convert.ToInt32(numer);
        }

        public int GetNumer()
        {
            Console.WriteLine("Było nie odebrane połączenie: ");
            return starePoloczenie;
        }


        void ITelefon.OdbierzPolaczenie()
        {
            Console.WriteLine("Jest nowe połączenie przychodzące.");
        }

        public void SetNumer(int numer)
        {
            Console.WriteLine("Podaj numer:");
            Console.ReadLine();            
        }

        void ITelefon.WykonajPolaczenie()
        {
            Console.WriteLine("Nowe połaczenie jest wykonywane.");
        }
    }
}
