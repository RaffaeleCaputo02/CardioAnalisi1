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

        public static string ValoreFrequenza(int freqRiposo)
        {
            if(freqRiposo<=0)
            {
                return "Impossibile";
            }
            else if(freqRiposo>100)
            {
                return "Tachicardia";
            }
            else if(freqRiposo<60)
            {
                return "Bradicardia";
            }
            else
            {
                return "Normale";
            }
        
        }

        public static string Calorie(string sesso, int F, int P, int A, int T)
        {
            if (F > 0 && P > 0 && A > 0 && T > 0)
            {
                if (sesso == "uomo")
                {
                    string calorie=Convert.ToString(((A * 0.2017) + (P * 0.199) + (F * 0.6309) - 55.0969) * T / 40184);
                    return calorie;
                }
                else
                {
                    string calorie = Convert.ToString(((A * 0.074) - (P * 0.126) + (F * 0.4472) - 20.4022) * T / 4.184);
                    return calorie;
                }
            }
            else
            {
                return "impossibile";
            }
                

        }


    }
}
