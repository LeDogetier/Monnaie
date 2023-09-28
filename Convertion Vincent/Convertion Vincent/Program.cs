using System;

namespace Monnaie
{

    internal class Program
    {
        static void Main()
        {
            String Sorte;
            Double DollarCanadien = 0, DollarUs = 0, Euro = 0;
            Console.WriteLine("Pour la monnaie cannadienne entrer CAD, pour la monnaie us entreer US et pour l'euro entrer EURO");
            String Argent = Console.ReadLine();
            if (Argent == "CAD")
            {
                Console.WriteLine("Pour us entrer US et pour euro entrer EURO");
                Sorte = Console.ReadLine();
                if (Sorte == "US")
                {
                    Console.WriteLine("Entrer la valeur");
                    DollarCanadien = Convert.ToDouble(Console.ReadLine());
                    DollarUs = DollarCanadien * 0.74;
                    Console.WriteLine("La valeur en USD est : " + DollarUs);
                }
                if (Sorte == "EURO")
                {
                    Console.WriteLine("Entrer la valeur");
                    DollarCanadien = Convert.ToDouble(Console.ReadLine());
                    Euro = DollarCanadien * 0.70;
                    Console.WriteLine("La valeur en Euro est : " + Euro);
                }
            }
            if (Argent == "US")
            {
                Console.WriteLine("Pour CAD entrer CAD et pour euro entrer EURO");
                Sorte = Console.ReadLine();
                if (Sorte == "CAD")
                {
                    Console.WriteLine("Entrer la valeur");
                    DollarUs = Convert.ToDouble(Console.ReadLine());
                    DollarCanadien = DollarUs * 1.35;
                    Console.WriteLine("La valeur en CAD est : " + DollarCanadien);
                }
                if (Sorte == "EURO")
                {
                    Console.WriteLine("Entrer la valeur");
                    DollarUs = Convert.ToDouble(Console.ReadLine());
                    Euro = DollarUs * 0.95;
                    Console.WriteLine("La valeur en Euro est : " + Euro);
                }
            }
            if (Argent == "EURO")
            {
                Console.WriteLine("Pour CAD entrer CAD et pour USD entrer USD");
                Sorte = Console.ReadLine();
                if (Sorte == "CAD")
                {
                    Console.WriteLine("Entrer la valeur");
                    DollarUs = Convert.ToDouble(Console.ReadLine());
                    DollarCanadien = Euro * 1.43;
                    Console.WriteLine("La valeur en CAD est : " + DollarCanadien);
                }
                if (Sorte == "USD")
                {
                    Console.WriteLine("Entrer la valeur");
                    DollarUs = Convert.ToDouble(Console.ReadLine());
                    DollarUs = Euro * 1.06;
                    Console.WriteLine("La valeur en USD est : " + DollarUs);
                }
                Console.ReadKey();
            }
        }
    }


}