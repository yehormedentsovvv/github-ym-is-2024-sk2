 // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Trojuhelnik *************");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Yehor Medentsov *********");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte delku strany (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu delku strany (celé číslo): ");
            }
            Console.WriteLine();
            for(int i=1; i<= width; i++) {
                for(int j = 1; j <= i ;j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }