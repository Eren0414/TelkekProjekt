using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Negyszog : Telek
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double D { get; private set; }
        public double E { get; private set; }

        public Negyszog(string helyrajziSzam, bool vanKozmu, double a, double b, double c, double d, double e) : base(helyrajziSzam, vanKozmu)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override double TeruletSzamol()
        {
            double s = (A + B + C + D) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C) * (s - D));
        }

        public override double KeruletSzamol()
        {
            return A + B + C + D;
        }

        public override string InformaciokKozol()
        {
            return $"Négyszög telek ({HelyrajziSzam}): terület = {TeruletSzamol():F2} m2, kerület = {KeruletSzamol()} m, ár = {ArSzamol()} Ft";
        }
    }
}
