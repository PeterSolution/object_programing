using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    public class Czlowiek
    {

        public ICzlowiek Obudzony;
        public ICzlowiek Najedzony;
        public ICzlowiek IdzDoPracy;
        public ICzlowiek Pracuj;
        public ICzlowiek IdzDoDomu;
        public ICzlowiek Odpoczynek;
        public ICzlowiek Sen;

        public ICzlowiek stan;

        public Czlowiek()
        {
            Obudzony = new Obudzony(this);
            Najedzony = new Najedzony(this);
            IdzDoPracy = new IdzDoPracy(this);
            Pracuj = new Pracuj(this);
            IdzDoDomu = new IdzDoDomu(this);
            Odpoczynek = new Odpoczynek(this);
            Sen = new Sen(this);
            
        }
        public void zmienstan(ICzlowiek stan)
        {
            this.stan = stan;
        }
        public void jedzenie()
        {
            stan.Jedzenie();
        }
        public void wyjscie()
        {
            stan.Wyjscie();
        }
        public void rozpoczeciepracy()
        {
            stan.RozpoczeciePracy();
        }
        public void koniecpracy()
        {
            stan.KoniecParacy();
        }
        public void rekreacja()
        {
            stan.Rekreacja();
        }
        public void prysznic()
        {
            stan.Prysznic();
        }
        public void spanie()
        {
            stan.Spanie();
        }
    }
}
