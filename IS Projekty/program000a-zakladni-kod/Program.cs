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

            // Vstup od uživatele -  lepsi varianta
            Console.Write("Zadejte prvni cislo rady (cele cislo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first ))
            {
                Console.Write("Nezadali jste cele cislo. Zadejte prvni cislo rady (cele cislo): ");
            }
            
            // Opakování programu
            
            Console.WriteLine("Pro opakování programu stisknete klávesu 'a'");
            again = Console.ReadLine();
        }
    }
}