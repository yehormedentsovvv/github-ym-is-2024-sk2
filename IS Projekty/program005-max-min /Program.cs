
string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Yehor Medentsov ******************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počeet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) 
            {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            
            int max = myArray[0];
            int posMax = 0;
            int posMin = 0;
            int min = myArray[0];

            for (int i = 1; i < n; i++)
            {
                if (max < myArray[i])
                {
                    max = myArray[i];
                    posMax = i;
                }
                if (min > myArray[i])
                {
                    min = myArray[i];
                    posMin = i;
                }
            }

            Console.Write("\n\n\n max - {0}; ", max);
            Console.Write("\n\n\n min - {0}; ", min);
            Console.Write("\n\n\n indexMax - {0}; ", posMax);
            Console.Write("\n\n\n indexMin - {0}; ", posMin);



            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }