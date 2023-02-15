using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Skriv in en bas till en potens: ");
            double tal = double.Parse(Console.ReadLine());
            Console.Write("Skriv in en exponent till potensen: ");
            double potens = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal} upphöjt till {potens} = {Potens(tal, potens)}");
        }

        static double Potens(double tal, double potens)
        {
            double matte = Math.Pow(tal, potens);
            return matte;

        }
    }
}
