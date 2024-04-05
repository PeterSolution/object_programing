using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Najedzony : ICzlowiek
    {
        Czlowiek czlowiek;
        public Najedzony(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Przed chwila jadles");
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Nie mozna zakonczyc nie zaczetej pracy");
        }

        public void Prysznic()
        {
            Console.WriteLine("Zrobisz to wieczorem, teraz czas na wyjscie do pracy");
        }

        public void Rekreacja()
        {
            Console.WriteLine("Nie czas na to");
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Nie doszedles do konca");
        }

        public void Spanie()
        {
            Console.WriteLine("Jestes wypoczety");
        }

        public void Wyjscie()
        {
            Console.WriteLine("Wychodzimy do pracy");
            czlowiek.zmienstan(czlowiek.IdzDoPracy);
        }
    }
}
