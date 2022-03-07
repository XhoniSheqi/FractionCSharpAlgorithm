using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SommaFrazioni s = new SommaFrazioni(12, 8, 2, 4);
            Console.WriteLine($"Il minimo comune divisiore e' {s.CalcolaMcd(9, 4)}");
            Console.WriteLine($"Il minimo comune multiplo e' {s.CalcolaMcm()}");
            Console.WriteLine($"La somma delle frazioni e' {s.CalcolaSommaFrazioni()} ");
            Console.WriteLine(s.RiduciFunzioni());
        }
    }
}


