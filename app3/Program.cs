using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek = new Czlowiek();
            czlowiek.stan = czlowiek.Obudzony;
            czlowiek.jedzenie();
            czlowiek.wyjscie();
            czlowiek.rozpoczeciepracy();
            czlowiek.koniecpracy();
            czlowiek.rekreacja();
            czlowiek.prysznic();
            czlowiek.spanie();
            Console.ReadKey();
        }
    }
}
