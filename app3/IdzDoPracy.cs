using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class IdzDoPracy : ICzlowiek
    {
        Czlowiek czlowiek;
        public IdzDoPracy(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Nie mozna tego zrobic kiedy idziesz do pracy");
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Nie zaczales pracy");
        }

        public void Prysznic()
        {
            Console.WriteLine("Nie jestes w miejscu z prysznicem");
        }

        public void Rekreacja()
        {
            Console.WriteLine("Bedzie na to czas potem");
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Rozpoczynamy prace");
            czlowiek.zmienstan(czlowiek.Pracuj);
        }

        public void Spanie()
        {
            Console.WriteLine("Nie potrzebujesz tego");
        }

        public void Wyjscie()
        {
            Console.WriteLine("Nie mozesz wyjsc ja nigdzie nie wszedles");
        }
    }
}
