// chci, aby se program opakoval po stisku klávesy "a"
string again = "a";
while(again == "a") {
    //Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("******* Převod z 10 do 2 soustavy *******");
    Console.WriteLine("*****************************************");
    Console.WriteLine("******** Yehor Medentsov *********");
    Console.WriteLine("******************************\n\n");
    Console.WriteLine();

    // Vstup od uživatele - lepší varianta
    Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo): ");
    uint cislo;
    while(!uint.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Špatný vstup. Zadejte číslo v desítkové soustavě (přirozené číslo): ");
    }

    Console.Write("Do jaké číselné soustavy chcete číslo převést? (1 - 2-ova; 2 -  5-ova; 3 - 8-ova : ");
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6) { 
    Console.Write("Nezadali jste číslo 1-3. Zadejte znovu: ");
    }
    Console.WriteLine("Vybrali jste možnost: " + choice);
    uint[] myArray = new uint[32];
    uint zaloha = cislo;
    uint zbytek;
    uint i=0;

    if(choice == 1)
    {
        while(cislo > 0) {
        zbytek = cislo % 2;
        cislo = (cislo - zbytek)/2;
        myArray[i] = zbytek;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Celá část = {0}; zbytek = {1}", cislo, zbytek);
        i++;
        }
        Console.WriteLine("Poslední využitý index pole: {0}", i-1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\nVýsledek: ");
    }
    else if(choice == 2)
    {
        while(cislo > 0) {
        zbytek = cislo % 5;
        cislo = (cislo - zbytek)/5;
        myArray[i] = zbytek;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Celá část = {0}; zbytek = {1}", cislo, zbytek);
        i++;
        }
        Console.WriteLine("Poslední využitý index pole: {0}", i-1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\nVýsledek: ");

    }
    else{
        while(cislo > 0) {
        zbytek = cislo % 8;
        cislo = (cislo - zbytek)/8;
        myArray[i] = zbytek;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Celá část = {0}; zbytek = {1}", cislo, zbytek);
        i++;
        }
        Console.WriteLine("Poslední využitý index pole: {0}", i-1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\nVýsledek: ");
    }

    for(int j = (int)i - 1; j >= 0; j--) {
        Console.Write("{0}",myArray[j]);
    }
    Console.WriteLine("\n\n");

    Console.ForegroundColor = ConsoleColor.White;

    // Opakování programu
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}