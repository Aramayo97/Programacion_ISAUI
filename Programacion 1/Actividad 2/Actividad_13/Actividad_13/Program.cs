using System;

class A13
{
    static void Main()
    {
        int cod, p1 = 0, p2 = 0, p3 = 0;

        while (true)
        {
            Console.Write("Código (1-3 o 999 para terminar): ");
            cod = int.Parse(Console.ReadLine());

            if (cod == 999) break;

            if (cod == 1) p1++;
            else if (cod == 2) p2++;
            else if (cod == 3) p3++;
        }

        int total = p1 + p2 + p3;

        Console.WriteLine("Partido 1: " + p1 + " (" + p1 * 100.0 / total + "%)");
        Console.WriteLine("Partido 2: " + p2 + " (" + p2 * 100.0 / total + "%)");
        Console.WriteLine("Partido 3: " + p3 + " (" + p3 * 100.0 / total + "%)");
    }
}
