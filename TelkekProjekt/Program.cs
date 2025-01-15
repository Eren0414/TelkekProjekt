using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkekProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Telek> telekLista = new List<Telek>
            {
            new Teglalap("T1", true, 13.95, 12.9),
            new Negyszog("T2", true, 13.95, 16.38, 14.24, 19.26, 21.52),
            new Haromszog("T7", false, 14.48, 22.84, 22.14),
            new Negyszog("T8", false, 22.84, 38, 13.95, 19.71, 24.15)
            };

            double osszesBevetel = 0;

            foreach (var telek in telekLista)
            {
                Console.WriteLine(telek.InformaciokKozol());
                osszesBevetel += telek.ArSzamol();
            }

            Console.WriteLine($"\nÖsszes bevétel: {Math.Round(osszesBevetel)} Ft");

            Console.ReadLine();
        }
    }
}
