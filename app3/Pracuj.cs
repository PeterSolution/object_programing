using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class Pracuj : ICzlowiek
    {
        Czlowiek czlowiek;
        public Pracuj(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Jadels z rana, teraz na to nie czas");
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Konczym prace");
            czlowiek.zmienstan(czlowiek.IdzDoDomu);
        }

        public void Prysznic()
        {
            Console.WriteLine("Nie mozna w miejscu pracy brac prysznica");
        }

        public void Rekreacja()
        {
            Console.WriteLine("To nie miejsce na rekreacje");
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Juz prace zaczales");
        }

        public void Spanie()
        {
            Console.WriteLine("Spac mozna w domu a nie w pracy");
        }

        public void Wyjscie()
        {
            Console.WriteLine("Jestes poza domem wiec nie mozesz wyjsc z niego");
        }
    }
}
