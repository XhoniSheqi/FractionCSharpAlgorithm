using System;

namespace ConsoleApp
{
    public class SommaFrazioni
    {

        // ATTRIBUTI
        private int a;
        private int b;
        private int c;
        private int d;
        private int e;
        private int f;


        // COSTRUTTORE
        public SommaFrazioni(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        // FUNZIONI


        // FUNZIONE RICORSIVA DI EUCLIDE 
        public int CalcolaMcd(int b, int d)
        {
            if (d == 0)
                return b;
            else
                return CalcolaMcd(d, b % d);
        }

        // FUNZIONE CALCOLA MCM

        public int CalcolaMcm(int b, int d)
        {
            return (b * d) / CalcolaMcd(b, d);
        }

        // FUNZIONE SOMMMA LE FRAZIONI

        public string CalcolaSommaFrazioni()
        {
            e = (CalcolaMcm(b, d) / b * a) + (CalcolaMcm(b, d) / d * c);
            f = CalcolaMcm(b, d);
            string res = "La frazione ottenuta e' : " + e + " / " + f;
            return res;
        }


        // RIDUCE LE FUNZIONI

        public string RiduciFunzioni()
        {
            string res = " ";
            CalcolaSommaFrazioni();
            if (e % CalcolaMcd(b, d) != 0)
            {
                res = "Il numeratore non può essere semplificato ... ";
                if (f % CalcolaMcd(b, d) != 0)
                {
                    res = "Il numeratore e il denominatore non possono essere semplificati ... ";
                    return res + e + " / " + f;
                }
                else
                {
                    res = "Il numeratore non può essere semplificato mentre il denominatore si !!  ... ";
                    return res + e + (f / CalcolaMcd(b, d));
                }
            }

            if (f % CalcolaMcd(b, d) != 0)
            {
                res = "Il denominatore non può essere semplificato ... ";
                if (e % CalcolaMcd(b, d) != 0)
                {
                    res = "Il numeratore e il denominatore non possono essere semplificati ... ";
                    return res + e + " / " + f;
                }
                else
                {
                    res = "Il denominatore non può essere semplificato mentre il numeratore si !!  ... ";
                    return res + (e / CalcolaMcd(b, d)) + f;
                }
            }

            if (f % CalcolaMcd(b, d) == 0 && e % CalcolaMcd(b, d) == 0)
            {
                res = "La frazione può essere semplificata ";
                return res + (e / CalcolaMcd(b, d)) + " / " + (f / CalcolaMcd(b, d));
            }
            return "c";
        }
    }
}