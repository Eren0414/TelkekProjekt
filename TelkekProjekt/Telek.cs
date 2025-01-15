using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    abstract class Telek
    {
        public string HelyrajziSzam { get; private set; }
        public bool VanKozmu { get; private set; }

        protected Telek(string helyrajziSzam, bool vanKozmu)
        {
            HelyrajziSzam = helyrajziSzam;
            VanKozmu = vanKozmu;
        }

        public int NegyzetmeterArSzamol()
        {
            return VanKozmu ? 30000 : 10000;
        }

        public abstract double TeruletSzamol();
        public abstract double KeruletSzamol();

        public double ArSzamol()
        {
            return Math.Round(TeruletSzamol() * NegyzetmeterArSzamol());
        }

        public abstract string InformaciokKozol();
    }
}
