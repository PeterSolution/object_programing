using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class Sen : ICzlowiek
    {
        Czlowiek czlowiek;
        public Sen(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Zjemy jutro rano");
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Na dzisiejszy dzien cala prace zakonczylismy");
        }

        public void Prysznic()
        {
            Console.WriteLine("Przed chwila bralismy prysznic");
        }

        public void Rekreacja()
        {
            Console.WriteLine("Na dzisiejszy dzien bylo rekreacji wystarczajaco");
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Praca nam jest juz dzisiaj nie potrzeba");
        }

        public void Spanie()
        {
            Console.WriteLine("Spimy");
            czlowiek.zmienstan(czlowiek.Obudzony);
        }

        public void Wyjscie()
        {
            Console.WriteLine("Jestesmy zbyt zmeczeni na to");
        }
    }
}
