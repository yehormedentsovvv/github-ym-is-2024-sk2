using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor a intervaly čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Yehor Medentsov ******************");
            Console.WriteLine("***********************************************\n\n");

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while (!int.TryParse(Console.ReadLine(), out dm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while (!int.TryParse(Console.ReadLine(), out hm) || hm <= dm)
            {
                Console.Write("Nezadali jste platnou horní mez (větší než dolní mez). Zadejte znovu horní mez (celé číslo): ");
            }

            Console.Write("Zadejte počet intervalů (celé číslo): ");
            int interval;
            while (!int.TryParse(Console.ReadLine(), out interval) || interval <= 0)
            {
                Console.Write("Nezadali jste platný počet intervalů (kladné celé číslo). Zadejte znovu počet intervalů: ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}; počet intervalů: {3}", n, dm, hm, interval);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);
            }
            // Výpočet intervalů
            double step = (double)(hm - dm) / interval;
            int[] intervalCounts = new int[interval];
            for (int i = 0; i < myArray.Length; i++)
            {
                int num = myArray[i];
                int index = Math.Min((int)((num - dm) / step), interval - 1);
                intervalCounts[index]++;
            }
            // Výpis výsledků
            Console.WriteLine("\n\nVýsledky intervalů:");
            for (int i = 0; i < interval; i++)
            {
                double lowerBound = dm + i * step;
                double upperBound = dm + (i + 1) * step;
                Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Green : ConsoleColor.Cyan;
                Console.WriteLine($"Interval <{lowerBound:F2}; {upperBound:F2}>: {intervalCounts[i]}");
            }

            Console.ResetColor();

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
