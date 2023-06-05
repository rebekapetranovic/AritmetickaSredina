using System;

namespace Prvi
{
    class Program
    {
        /// <summary>
        /// RAČUNANJE ARITMETIČKE SREDINE DECIMALNIH ZNAMENKI
        /// </summary>
        static void Main()
        {
            double broj;
            double decDio;
            int des;
            int sto;
            int tis;
            double arsr;
            Console.Write("Upiši realan broj: ");
            broj = double.Parse(Console.ReadLine());
            decDio = broj - (int)broj;
            des = (int)(decDio * 10);
            sto = (int)(decDio * 100 % 10);
            tis = (int)(decDio * 1000 % 10);
            arsr = (des + sto + tis) / 3;
            Console.WriteLine("Aritmeticka sredina decimalnih znameni: {0} ", arsr);
        }
    }
}