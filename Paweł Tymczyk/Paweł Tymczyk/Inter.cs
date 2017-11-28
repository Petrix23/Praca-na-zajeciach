using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paweł_Tymczyk
{
    interface ITelefon
    {
        void OdbierzPolaczenie();
        void WykonajPolaczenie();
    }

    interface IMobile:ITelefon
    {
        string KartaSim();
        string PamiecWewnetrzna();


        void WyslijSms();
        void ZrobZdjecie();
    }

    interface IStacjonarny:ITelefon
    {
    }

}
