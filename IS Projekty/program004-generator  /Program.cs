string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Generátor pseudonáhodných čísel *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**************** Yehor Medentsovv ******************");
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
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            //deklarace pole

            int[]myArray = new int [n];

            //priprava pro generovani nahodnych cisel

            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            int check = 0;
                int kladna = 0;
                int zaporna = 0;
                int nulova = 0;

            for(int i = 0; i < n; i++)
            {
         
                check = randomNumber.Next(dm, hm + 1);
                if(check>0)
                {
                    myArray[i] = check;
                    kladna++;

                }else if(check < 0)
                {
                    myArray[i] = check;
                    zaporna++;
                }else if(check == 0)
                {
                    myArray[i] = check;
                    nulova++;
                }
        
            Console.WriteLine("{0}; ", myArray[i]);
            }
             Console.WriteLine("zapornych : {0} ", zaporna);
             Console.WriteLine("kladnych -  {0}", kladna);
             Console.WriteLine("nuly -  {0}", nulova);
            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }