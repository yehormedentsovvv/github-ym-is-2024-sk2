using System.Drawing;
using System.Text.Json.Serialization.Metadata;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("******* Výpočet PI *******");
            Console.WriteLine("******************************");
            Console.WriteLine("******** Yehor Medentsov *********");
            Console.WriteLine("******************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte přesnost: ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste přestnost spravně. Zadejte znovu: ");
            }

            double i = 1;
            double piCtvrt = 1;
            double znamenko = 1;

            while((1/i) >= presnost)
            {
               i = i + 2;
               znamenko = -znamenko;
               piCtvrt = piCtvrt + znamenko * 1 / i;
               if(znamenko == 1)
               {
                 Console.Write("\nZlomek: +1/{0}; aktuální hodnota PI = {1}", i, piCtvrt * 4);
               }
               else
               {
                 Console.Write("\nZlomek: -1/{0}; aktuální hodnota PI = {1}", i, piCtvrt * 4);
               }
            }

            double pi = 4 * piCtvrt;
            Console.Write("\nPi: {0}; ", pi);
            Console.Write("\nPi: {0:f4}; ", pi);

            Console.Write("\n\n"); 

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }   


}