
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
            int countMax = 0;
            int countMin = 0;
            int min = myArray[0];

            for (int i = 1; i < n; i++)
            {
                if (max < myArray[i])
                {
                    max = myArray[i];
                }
                if (min > myArray[i])
                {
                    min = myArray[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if(max == myArray[i])
                {
                    countMax++;
                }
                else if(min == myArray[i])
                {
                    countMin++;
                }
            }
            int[] myArrayIndexMax = new int[countMax];
            int[] myArrayIndexMin = new int[countMin];

            int j = 0;
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if(max == myArray[i])
                {
                    myArrayIndexMax[j] = i;
                    j++;
                }
                else if(min == myArray[i])
                {
                    myArrayIndexMin[s] = i;
                    s++;
                }
                
            }

            Console.Write("\n\n\n Max: {0}; ", max);
            Console.Write("\n\n\n Min: {0}; ", min);
            Console.Write("\n\n\n Počet maximálních hodnot: {0};\n\n\n", countMax);
            Console.Write(" Pozice všech maximálních prvků : ");
            for(int i = 0; i < countMax; i++) 
            {
                Console.Write("{0}; ", myArrayIndexMax[i]);
            }
            Console.Write("\n\n\n Počet minimálních hodnot: {0};\n\n\n", countMin);
            Console.Write(" Pozice všech minimálních prvků : ");
            for(int i = 0; i < countMin; i++) 
            {
                Console.Write("{0}; ", myArrayIndexMin[i]);
            }

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }