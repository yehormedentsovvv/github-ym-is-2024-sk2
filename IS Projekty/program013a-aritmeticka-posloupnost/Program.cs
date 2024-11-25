using System;
class Program
{
    static void Main()
    {   
        // chci aby se program opakoval po stisku klavesy "a"
        string again = "a";

        while (again == "a")
        {
            Console.Write("\n\n\nZadejte počet čísel (celé číslo): ");
            int count;
            while(!int.TryParse(Console.ReadLine(), out count)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }
            Console.Write("Zadejte diference (celé číslo): ");
            int diference;
            while(!int.TryParse(Console.ReadLine(), out diference)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diference znovu (celé číslo): ");
            }
            Console.Write("Zadejte první prvek posloupnosti (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první prvek posloupnosti znovu (celé číslo): ");
            }

            Console.Write("Aritmetická posloupnost: ");
            Console.Write("{0}, ", first);
            int next = first;
            int sum = first;

            for (int i = 1; i < count; i++)
            {
                next = next + diference;
                sum += next;
                Console.Write("{0}; ", next);
            }

            Console.Write("\nSoucet = {0}; ", sum);
            Console.WriteLine("\n");
            Console.WriteLine("Pro opakování programu stisknete klávesu 'a'");
            again = Console.ReadLine();
        }
    }
}