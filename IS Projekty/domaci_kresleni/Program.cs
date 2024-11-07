using System.Formats.Asn1;

string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Další obrazce - vykreslování na konzoli *************");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Yehor Medentsov 25.10.2024 *********");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();


            Console.Write("Jaký obrázek chcete nakreslit, zadejte číslo (1 - lehčí; 2 - středně obtížný; 3 - obtížný): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3) { 
            Console.Write("Nezadali jste číslo 1-3. Zadejte znovu číslo obrázku: ");
            }
            Console.WriteLine("Vybrali jste možnost: " + choice);
            Console.Write("Zadejte velikost obrazku (celé a liché číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width) || width % 2 == 0) 
            {
                Console.Write("Nezadali jste celé číslo nebo sudé. Zadejte znovu delku strany (celé a liché číslo): ");
            }
            Console.WriteLine();
            int mid = width / 2;
            if(choice == 1)
            {
                int midd = mid;
                int step = 1;
                for (int i = 0; i <= midd; i++)
                {
                    for (int k = 0; k < mid; k++)
                    {
                        Console.Write("  ");
                        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    for (int j = mid; j <= mid + step; j++)
                    {
                        Console.Write("* ");
                        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    for (int l = mid + step + 1; l < width; l++)
                    {
                        Console.Write("  ");
                        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                    }
                    mid--;
                    step = step + 2;
                    Console.WriteLine();

                }
                step = 0;

                for (int i = 0; i <= midd; i++)
                {
                    for (int r = 0; r < step; r++)
                    {
                         Console.Write("  ");
                         System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    for (int j = 0; j <= width; j++)
                    {
                        Console.Write("* ");
                        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    for (int k = 0; k < step; k++)
                    {
                         Console.Write("  ");
                         System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    step++;
                    width = width - 2;
                    Console.WriteLine();
                }
            }
            else if(choice == 3)
            {
                for (int i = 0; i <= mid; i++)
                {
                    for (int j = 0; j <= mid; j++)
                    {
                        if(i == 0 || i == mid)
                        {
                            Console.Write("* ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                        }
                        else 
                        {
                            if(j == 0 || j == mid)
                            {
                                Console.Write("* ");
                                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                            }
                            else
                            {
                                Console.Write("  ");
                                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                            }   
                        }
                        
                    }
                    Console.WriteLine();

                }

                for (int i = mid + 1; i <= width; i++)
                {
                    for (int j = 0; j <= width; j++)
                    {
                        if(j <= mid)
                        {
                            Console.Write("  ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                        }
                        else if(i == mid + 1 || i == width)
                        {
                            Console.Write("* ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                        }
                        else
                        {
                            if(j == mid + 1 || j == width)
                            {
                                Console.Write("* ");
                                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                            }else
                            {
                                Console.Write("  ");
                                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                            }
                        }
                    }
                    Console.WriteLine();
                }
            } 
            else 
            {
                int midd = mid;
                int step = 1;
                for (int i = 0; i <= midd; i++)
                {
                    for (int k = 0; k < mid; k++)
                    {
                        Console.Write("  ");
                        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    for (int j = mid; j <= mid + step; j++)
                    {
                        if(j == mid || j == mid + step)
                        {
                            Console.Write("* ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                        }
                        else
                        {
                            Console.Write("  ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                        }

                    }
                    for (int l = mid + step + 1; l < width; l++)
                    {
                        Console.Write("  ");
                        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); 
                    }
                    mid--;
                    step = step + 2;
                    Console.WriteLine();

                }
                step = 0;

                for (int i = 0; i <= midd; i++)
                {
                    for (int r = 0; r < step; r++)
                    {
                         Console.Write("  ");
                         System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    for (int j = 0; j <= width; j++)
                    {
                        if(j == 0 || j == width)
                        {
                            Console.Write("* ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                        }
                        else
                        {
                            Console.Write("  ");
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));   
                        }
                    }
                    for (int k = 0; k < step; k++)
                    {
                         Console.Write("  ");
                         System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                    }
                    step++;
                    width = width - 2;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }