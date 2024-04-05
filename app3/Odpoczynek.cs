using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class Odpoczynek : ICzlowiek
    {
        Czlowiek czlowiek;
        public Odpoczynek(Czlowiek czlowiek)
        {
            this.czlowiek = czlowiek;
        }
        public void Jedzenie()
        {
            Console.WriteLine("Nie potrzebne jest czlowiekowi jedzenie jak sie relaksuje");
        }

        public void KoniecParacy()
        {
            Console.WriteLine("Juz praca sie zakonczyla");
        }

        public void Prysznic()
        {
            Console.WriteLine("Bierzemy prysznic");
            czlowiek.zmienstan(czlowiek.Sen);
        }

        public void Rekreacja()
        {
            Console.WriteLine("Wlasnie trwa rekreacja");
        }

        public void RozpoczeciePracy()
        {
            Console.WriteLine("Praca zajmiemy sie jutro");
        }

        public void Spanie()
        {
            Console.WriteLine("Potem bedziemy spac");
        }

        public void Wyjscie()
        {
            Console.WriteLine("Jestes zmeczony, moze potem");
        }
    }
}
