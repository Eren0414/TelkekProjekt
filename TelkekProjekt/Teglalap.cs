using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Teglalap : Telek
    {
        public double A { get; private set; }
        public double B { get; private set; }

        public Teglalap(string helyrajziSzam, bool vanKozmu, double a, double b) : base(helyrajziSzam, vanKozmu)
        {
            A = a;
            B = b;
        }

        public override double TeruletSzamol()
        {
            return A * B;
        }

        public override double KeruletSzamol()
        {
            return 2 * (A + B);
        }

        public override string InformaciokKozol()
        {
            return $"Téglalap telek ({HelyrajziSzam}): terület = {TeruletSzamol()} m2, kerület = {KeruletSzamol()} m, ár = {ArSzamol()} Ft";
        }
    }
}
