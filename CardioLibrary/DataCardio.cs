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

        public static string Calorie(string sesso, int F, double P, int A, int T)
        {
            if (F > 0 && P > 0 && A > 0 && T > 0)
            {
                if (sesso == "uomo")
                {
                    double calorie = Math.Round(((A * 0.2017) + (P * 0.199) + (F * 0.6309) - 55.0969) * T / 4.184, 2);
                    return Convert.ToString(calorie);
                }
                if(sesso=="donna")
                {
                    double calorie = Math.Round(((A * 0.074) - (P * 0.126) + (F * 0.4472) - 20.4022) * T / 4.184, 2);
                    return Convert.ToString(calorie);
                }
            }
           
            return "impossibile";
        }

        public static string SpesaEnergetica(string esercizio, double kmPercorsi, double peso)
        {
            if(kmPercorsi>0 && peso>0)
            {
                if(esercizio=="corsa")
                {
                    double spesaEnergetica = Math.Round(0.9 * kmPercorsi * peso, 2);
                    return Convert.ToString(spesaEnergetica);

                }
                if(esercizio=="camminata")
                {
                    double spesaEnergetica = Math.Round(0.50 * kmPercorsi * peso, 2);
                    return Convert.ToString(spesaEnergetica);
                }
            }
                return "impossibile";
        }


    }
}
