using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class IdzDoDomu : ICzlowiek
    {
        Czlowiek czlowiek;
        public IdzDoDomu(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Mozesz zjesc cos jutro");
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Juz zakonczyles prace");
        }

        public void Prysznic()
        {
            Console.WriteLine("Można to zrobic w domu a nie na ulicy");
        }

        public void Rekreacja()
        {
            Console.WriteLine("Zaczynamy zabaweeeeee.....");
            czlowiek.zmienstan(czlowiek.Odpoczynek);
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Juz dzisiaj pracowales");
        }

        public void Spanie()
        {
            Console.WriteLine("Potem mozesz zasnac ale nie na ulicy");
        }

        public void Wyjscie()
        {
            Console.WriteLine("Ranu wyszedles z domu");
        }
    }
}
