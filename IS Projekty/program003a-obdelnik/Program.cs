string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********");
            Console.WriteLine("*********** Obdelník ************");
            Console.WriteLine("****************");
            Console.WriteLine("*********** Yehor Medentsov ************");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();


        

            // Vstup od uživatele -  lepsi varianta
            Console.Write("Zadejte sirku obrazce (CELE CISLO): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu sirku (cele cislo): ");
            }

            Console.Write("Zadejte vysku obrazce (CELE CISLO): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte znovu vysku (cele cislo): ");
            }

            //for(int i = 1; i <= 10; i++)
            //{
              //  Console.WriteLine(i);
            //}

         //   int j = 1;

           // while(j <= 10)
            //{
              // Console.WriteLine(j);
               //j++;
            //}


            for(int i = 1; i <= height ;i++)
            {
                for(int j = 1 ;j <= width; j++)
                {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(1000));
                }
                Console.WriteLine();
            }

            // Opakování programu
            
            Console.WriteLine("Pro opakování programu stisknete klávesu 'a'");
            again = Console.ReadLine();
        }