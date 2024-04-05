using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class Obudzony : ICzlowiek
    {
        Czlowiek czlowiek;
        public Obudzony(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Jemy");
            czlowiek.zmienstan(czlowiek.Najedzony);
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Nie jesteś w pracy, by mieć sile na prace cos zjedz");
        }

        public void Prysznic()
        {
            Console.WriteLine("To zrobisz wieczorem, teraz idz cos zjedz");
        }

        public void Rekreacja()
        {
            Console.WriteLine("Na początku zjedz coś i zacznij pracować");
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Przed praca musisz cos zjesc");
        }

        public void Spanie()
        {
            Console.WriteLine("Dopiero co wstales");
        }

        public void Wyjscie()
        {
            Console.WriteLine("Przed wyjsciem cos musisz zjesc");
        }
    }
}
