using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paweł_Tymczyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int czyJuz = 0;
            string polecenie= null;
            Console.Write("Jaki telefon chcesz (stacjonarny ; komorka): ");
            string jakiTelefon = Console.ReadLine();



            if (jakiTelefon == "komorka")
            {
                Iphone8 telefon = new Iphone8();

                do
                {
                    if (polecenie == "NagrywanieHD")
                        telefon.NagrywanieHD();
                    else if(polecenie == "SMS")
                        telefon.WyslijSMS();


                    Console.WriteLine("Czy już zakończyłeś/-łaś pracę ze swoją komórką (0-tak / 1-nie) ?");
                    czyJuz = Convert.ToInt32(Console.ReadLine());
                } while (czyJuz == 1);


            }
            else if (jakiTelefon == "stacjonarny")
            {
                Console.WriteLine("Podaj numer swojego telefonu: ");
                string numer = Console.ReadLine();
                TelefonStacjonarny telefon = new TelefonStacjonarny(numer);


                do
                {
                    Console.WriteLine("Czy już zakończyłeś/-łaś pracę ze swoją komórką (0-tak / 1-nie) ?");
                    czyJuz = Convert.ToInt32(Console.ReadLine());
                } while (czyJuz == 1);
            }


        }
    }
}
