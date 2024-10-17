// chci aby se program opakoval po stisku klavesy "a"
using System.Data;

string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********");
            Console.WriteLine("*********** Součet a součin cifer ************");
            Console.WriteLine("****************");
            Console.WriteLine("*********** Yehor Medentsov ************");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            Console.Write("Zadejte cele cislo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte cele cislo: ");
            }


            Console.WriteLine("==============================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("==============================");

            int suma = 0;
            int numberBackup = number;
            int digit;

            if(number < 0)
            {
                number = - number;
            }

            while(number >= 10)
            {
               digit = number % 10; // % operator modulovy
               number = (number - digit) / 10;
               Console.WriteLine("Digit = {0}", digit);
               suma = suma + digit;
            }
               Console.WriteLine("Digit = {0}", number);

            suma = suma + number;
            Console.WriteLine("\n\nSoucet cifer cisla {0} je {1}", numberBackup, suma);

            // Opakování programu
            
            Console.WriteLine("Pro opakování programu stisknete klávesu 'a'");
            again = Console.ReadLine();
        }
        