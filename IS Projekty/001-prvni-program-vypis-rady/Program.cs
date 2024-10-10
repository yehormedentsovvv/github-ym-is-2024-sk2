using System;

class Program
{
    static void Main()
    {   
        // chci aby se program opakoval po stisku klavesy "a"
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********");
            Console.WriteLine("*********** Výpis řady ************");
            Console.WriteLine("****************");
            Console.WriteLine("*********** Yehor Medentsov ************");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup do uživatele -  spatna varianta
            //Console.Write("Zadejte prvni cislo rady: ");
            //int first = int.Parse(Console.ReadLine());


            // Vstup od uživatele -  lepsi varianta
            Console.Write("Zadejte prvni cislo rady (cele cislo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte prvni cislo rady (cele cislo): ");
            }

            Console.Write("Zadejte posledni cislo rad (cele cislo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte posledni cislo rady (cele cislo): ");
            }

            Console.Write("Zadejte diference (cele cislo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte diference (cele cislo): ");
            }



            //Vypis uzivatelskeho vstupu
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine("Prvni cislo: {0}", first);
            Console.WriteLine("Posledni cislo: {0}", last);
            Console.WriteLine("Diference cislo: {0}", step);
            Console.WriteLine();
            Console.WriteLine();




            // Logika pro výpis řady - TO-DO

            // Opakování programu
            
            Console.WriteLine("Pro opakování programu stisknete klávesu 'a'");
            again = Console.ReadLine();
        }
    }
}