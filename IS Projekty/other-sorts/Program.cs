using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Další základní řadící metody *******");
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
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            Console.WriteLine("\n");
            Console.Write("Jaký algoritm chcete použit, zadejte číslo (1 - BubbleSort; 2 -  Selection sort; 3 - Insertion sort; 4 - Shaker sort; 5 - Comb sort; 6 - Shell sort): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6) { 
            Console.Write("Nezadali jste číslo 1-3. Zadejte znovu číslo obrázku: ");
            }
            Console.WriteLine("Vybrali jste možnost: " + choice);

            if(choice == 1)
            {
                Stopwatch myStopwatch = new Stopwatch(); // bubble sort
                myStopwatch.Start();

                int numberCompare = 0;
                int numberChange = 0;

                for(int i=0; i<n-1; i++) 
                {
                     for(int j=0 ; j<n-i-1; j++) 
                    {
                         numberCompare++;
                        if(myArray[j] < myArray[j+1]) 
                        {
                             int tmp = myArray[j];
                             myArray[j] = myArray[j+1];
                              myArray[j+1] = tmp;
                              numberChange++;
                        }
                    }
                }
                myStopwatch.Stop();


                 Console.WriteLine("\n\nSeřazené pole bubble sortem: ");
                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Bubble Sort: {0}", myStopwatch.Elapsed);
                Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
                Console.WriteLine("Počet výměn: {0}", numberChange);
                Console.ResetColor();
            }
            else if(choice == 2)
            {
                Stopwatch myStopwatch = new Stopwatch(); // Selection sort
                myStopwatch.Start();

                int numberCompare = 0;
                int numberChange = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    int maxIndex = i;
                    for (int j = i + 1; j < n; j++) 
                    {
                        numberCompare++;
                        if (myArray[j] > myArray[maxIndex]) 
                        {
                            maxIndex = j;
                        }
                    }
                    int tmp = myArray[i];
                    myArray[i] = myArray[maxIndex];
                    myArray[maxIndex] = tmp;
                    numberChange++;
                }
                myStopwatch.Stop();
                Console.WriteLine("\n\nSeřazené pole selection sortem: ");
                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Selection Sort: {0}", myStopwatch.Elapsed);
                Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
                Console.WriteLine("Počet výměn: {0}", numberChange);
                Console.ResetColor();

            }
            else if(choice == 3)
            {
                Stopwatch myStopwatch = new Stopwatch(); // Insertion sort
                myStopwatch.Start();

                int numberCompare = 0;
                int numberChange = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    int j = i + 1;
                    int tmp = myArray[j];
                    while (j > 0 && tmp > myArray[j - 1])
                    {
                        myArray[j] = myArray[j - 1];
                        j--;
                        numberCompare++;
                    }
                    myArray[j] = tmp;
                    numberChange++;
                }
                myStopwatch.Stop();
                Console.WriteLine("\n\nSeřazené pole Insertion sortem: ");
                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Insertion Sort: {0}", myStopwatch.Elapsed);
                Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
                Console.WriteLine("Počet výměn: {0}", numberChange);
                Console.ResetColor();

            }
            else if(choice == 4)
            {
                Stopwatch myStopwatch = new Stopwatch(); // Shaker sort
                myStopwatch.Start();

                int numberCompare = 0;
                int numberChange = 0;
                for (int i = 0; i < n / 2; i++)
                {
                    bool swapped = false;
                    for (int j = i; j < n - i - 1; j++)
                    {
                        if (myArray[j] < myArray[j + 1])
                        {
                            int tmp = myArray[j];
                            myArray[j] = myArray[j + 1];
                            myArray[j + 1] = tmp;
                            swapped = true;
                            numberChange++;
                        }
                        numberCompare++;
                    }
                    for (int j = n - 2 - i; j > i; j--)
                    {
                        if (myArray[j] > myArray[j - 1])
                        {
                            int tmp = myArray[j];
                            myArray[j] = myArray[j - 1];
                            myArray[j - 1] = tmp;
                            swapped = true;
                            numberChange++;
                        }
                        numberCompare++;
                    }
                    if (!swapped) break;
                }
                myStopwatch.Stop();
                Console.WriteLine("\n\nSeřazené pole Shaker sortem: ");
                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Shaker Sort: {0}", myStopwatch.Elapsed);
                Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
                Console.WriteLine("Počet výměn: {0}", numberChange);
                Console.ResetColor();

            }
            else if(choice == 5)
            {
                Stopwatch myStopwatch = new Stopwatch(); // Comb sort
                myStopwatch.Start();

                int numberCompare = 0;
                int numberChange = 0;
                double gap = n;
                bool swaps = true;

                while (gap > 1 || swaps)
                {
                    gap /= 1.247330950103979; 
                    if (gap < 1)
                    {
                        gap = 1;
                    }
                    int i = 0;
                    swaps = false;

                    while (i + gap < n)
                    {
                        int igap = i + (int)gap;

                        if (myArray[i] < myArray[igap])
                        {
                           int temp = myArray[i];
                           myArray[i] = myArray[igap];
                           myArray[igap] = temp;
                           swaps = true;
                           numberChange++; 
                        }
                        numberCompare++; 
                        ++i; 
                    }           
                }
                myStopwatch.Stop();
                Console.WriteLine("\n\nSeřazené pole Comb sortem: ");
                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Comb Sort: {0}", myStopwatch.Elapsed);
                Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
                Console.WriteLine("Počet výměn: {0}", numberChange);
                Console.ResetColor();


            }
            else if(choice == 6)
            {
                Stopwatch myStopwatch = new Stopwatch(); // Shell sort
                myStopwatch.Start();

                int numberCompare = 0;
                int numberChange = 0;
                int gap = n / 2;
                while (gap > 0) //dokud mame co porovnavat
                {
                    for (int i = 0; i < n - gap; i++) //upraveny insertion sort
                    {
                        int j = i + gap;
                        int tmp = myArray[j];
                        while (j >= gap && tmp > myArray[j - gap])
                        {
                            myArray[j] = myArray[j - gap];
                            j -= gap;
                            numberChange++;
                            numberCompare++;
                        }
                        myArray[j] = tmp;
                        numberChange++;
                    }
                    if (gap == 2) //zmena velikosti mezery
                    {
                        gap = 1;
                    }
                    else
                    {
                        gap = (int)(gap / 2.2);
                    }
                }
                myStopwatch.Stop();
                Console.WriteLine("\n\nSeřazené pole Shell sortem: ");
                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Shell Sort: {0}", myStopwatch.Elapsed);
                Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
                Console.WriteLine("Počet výměn: {0}", numberChange);
                Console.ResetColor();
            }
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }