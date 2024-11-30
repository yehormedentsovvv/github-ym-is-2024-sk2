using System.Security.Authentication.ExtendedProtection;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Kombinovaná úloha *******");
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
            Console.Write("\nMax: {0}; ", max);
            Console.Write("\nMin: {0}; ", min);
            Console.Write("\nPozice všech maximálních prvků : ");
            for(int i = 0; i < countMax; i++) 
            {
                Console.Write("{0}; ", myArrayIndexMax[i]);
            }
            Console.Write("\nPozice všech minimálních prvků : ");
            for(int i = 0; i < countMin; i++) 
            {
                Console.Write("{0}; ", myArrayIndexMin[i]);
            }

            for (int i = 0; i < n / 2; i++)
                {
                    bool swapped = false;
                    for (int j1 = i; j1 < n - i - 1; j1++)
                    {
                        if (myArray[j1] < myArray[j1 + 1])
                        {
                            int tmp = myArray[j1];
                            myArray[j1] = myArray[j1 + 1];
                            myArray[j1 + 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int j2 = n - 2 - i; j2 > i; j2--)
                    {
                        if (myArray[j2] > myArray[j2 - 1])
                        {
                            int tmp = myArray[j2];
                            myArray[j2] = myArray[j2 - 1];
                            myArray[j2 - 1] = tmp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
                Console.WriteLine("\n\nSeřazené pole Shaker sortem: ");

                for(int i=0; i<n; i++) 
                {
                    Console.Write("{0}; ", myArray[i]);
                }

                int counters = 0;
                int second = 0;
                int third = 0;
                int fourth = 0;
                for (int i = 0; i < n; i++)
                {
                    if (myArray[i + 1] < myArray[i] && counters == 0)
                    {
                        counters++;
                        second = myArray[i + 1];

                    }
                    else if(myArray[i + 1] < myArray[i] && counters == 1)
                    {
                        counters++;
                        third = myArray[i + 1];
                    }
                    else if(myArray[i + 1] < myArray[i] && counters == 2)
                    {
                        fourth = myArray[i + 1];
                        break;
                    }
                }

                Console.WriteLine("\n\nDruhé největší číslo: {0}; ", second);
                Console.WriteLine("\n\nTřetí největší číslo: {0}; ", third);
                Console.WriteLine("\n\nČtvrté největší číslo: {0}; ", fourth);
                int mediana = 0;
                if(n % 2 == 1)
                {
                    mediana = myArray[n / 2];
                }
                else 
                {
                    mediana = (myArray[n / 2 - 1] + myArray[n / 2]) / 2;
                }
                Console.WriteLine("\n\nMedián generovaných čísel: {0}; ", mediana);

                int[] myArrayy = new int[32];
                int zbytek;
                int ichko = 0;
                while(fourth > 0) {
                    zbytek = fourth % 2;
                    fourth = (fourth - zbytek)/2;
                    myArrayy[ichko] = zbytek;
                    ichko++;
                }
                Console.WriteLine("\n\nČtvrté největší číslo převedené do binární soustavy: ");
                for(int j3 = (int)ichko- 1; j3 >= 0; j3--)
                {
                    Console.Write("{0}",myArrayy[j3]);
                }
                Console.WriteLine("\n\nObrazec – výška = medián {0}; šířka = třetí největší číslo {1}", mediana, third);

                for (int i = 0; i < mediana / 2 - 1; i++) 
                {
                    for (int s1 = 0; s1 < 4; s1++)  
                    {
                        Console.Write("   ");
                    }
                    for (int j1 = 0; j1 < 3; j1++) 
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < 2; i++) 
                {
                    for (int j2 = 0; j2 < third; j2++) 
                    {
                        Console.Write("* ");
                    }
                Console.WriteLine();
                }

                for (int i = 0; i < mediana / 2 - 1; i++) 
                {
                    for (int s3 = 0; s3 < 4; s3++)  
                    {
                        Console.Write("   ");
                    }
                for (int j4 = 0; j4 < 3; j4++) 
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }