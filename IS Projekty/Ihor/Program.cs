using System.Formats.Asn1; 
 
string again = "a"; 
        while(again == "a") { 
            //Console.Clear(); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******* Úkol 003 - další obrazce - vykreslování na konzoli *************"); 
            Console.WriteLine("******************************"); 
            Console.WriteLine("******** Ihor Panchenko  *********"); 
            Console.WriteLine("******************************\n\n"); 
            Console.WriteLine(); 
 
 
            Console.Write("Jaký obrázek chcete nakreslit, zadejte číslo (1 - lehčí; 2 - středně obtížný; 3 - obtížný): "); 
            int choice; 
            while (!int.TryParse(Console.ReadLine(), out choice) ||  choice < 1 || choice > 3) {  
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
                for (int i = 0; i <= width; i++)   
                {   
                    for (int j = 0; j <= width; j++)   
                    {   
                        if(j == 0 || j == width)   
                        {   
                            Console.Write("* ");    
                            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));    
                        }   
                        else if(i == j)   
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
                 Console.WriteLine();      
                 } 
            }
            else if(choice == 2) 
            { 

            }  
            else  
            { 

            } 
 
            Console.WriteLine(); 
             
            // Opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a"); 
            again = Console.ReadLine(); 
        } 
