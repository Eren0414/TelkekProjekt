using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Haromszog : Telek
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Haromszog(string helyrajziSzam, bool vanKozmu, double a, double b, double c) : base(helyrajziSzam, vanKozmu)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double TeruletSzamol()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double KeruletSzamol()
        {
            return A + B + C;
        }

        public override string InformaciokKozol()
        {
            return $"Háromszög telek ({HelyrajziSzam}): terület = {TeruletSzamol():F2} m2, kerület = {KeruletSzamol()} m, ár = {ArSzamol()} Ft";
        }
    }
}
