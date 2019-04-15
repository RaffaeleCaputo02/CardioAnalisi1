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
                int massimo = 220 - eta;
                int massimoCon = massimo / 100 * 90;
                int minimoCon = massimo / 100 * 70;
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

        public static string MediaBattiti(int[] battiti)
        {
            bool flag = false;
            int somma = 0;
            for (int i=0;i<battiti.Length;i++)
            {
                if (battiti[i] <= 0) flag = true;
                somma = somma + battiti[i];
            }
            if(flag==false)
            {
                int media = somma / battiti.Length;
                return Convert.ToString(media);
            }
            return "impossibile";
        }

        public static string BattitoRiposo(int[] battiti)
        {
            bool flag = false;
            int minimo=battiti[0];
            for (int i = 0; i < battiti.Length; i++)
            {
                if (battiti[i] <= 0) flag = true;
                if (battiti[i] < minimo) minimo = battiti[i];
            }
            if (flag == false)
            {
                return Convert.ToString(minimo);
            }
            return "impossibile";
        }

        public static string VariabilitàBattito(int[] battiti)
        {
            bool flag = false;
            int minimo = battiti[0];
            int massimo = battiti[0];
            for (int i = 0; i < battiti.Length; i++)
            {
                if (battiti[i] <= 0) flag = true;
                if (battiti[i] < minimo) minimo = battiti[i];
                if (battiti[i] > massimo) massimo = battiti[i];
            }
            if (flag == false)
            {
                int variabilità = massimo - minimo;
                return Convert.ToString(variabilità);
            }
            return "impossibile";
        }
        public static string[] OrdinamentoBattiti(int[] battiti)
        {
            bool flag = false;
            
            for (int i = 0; i < battiti.Length; i++)
            {
                if (battiti[i] <= 0) flag = true;
            }

            for(int i=0;i<battiti.Length;i++)
            {
                for(int j=0; j<battiti.Length-1;j++)
                {
                    if(battiti[j]>battiti[j+1])
                    {
                        int tmp = battiti[j];
                        battiti[j] = battiti[j + 1];
                        battiti[j + 1] = tmp;
                    }
                }
            }
            if (flag == false)
            {
                return battiti;
            }
            
        }

    }
}
