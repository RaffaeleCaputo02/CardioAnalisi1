using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioLibrary
{
    public class DataCardio
    {
        public static string Battiti(int eta)
        {
            if (eta <= 0)
            {
                return "impossibile";
            }
            else
            {
                double massimo = 220 - eta;
                double massimoCon = massimo / 100 * 90;
                double minimoCon = massimo / 100 * 70;
                string consigliato = ($"{minimoCon};{massimoCon}");
                return consigliato;
            }
        }

    }
}
