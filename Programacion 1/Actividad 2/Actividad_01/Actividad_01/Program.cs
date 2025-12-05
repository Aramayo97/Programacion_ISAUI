using System;

class A1
{
    static void Main()
    {
        int n1, n2, n3;
        Console.Write("Ingrese número 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese número 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese número 3: ");
        n3 = int.Parse(Console.ReadLine());

        double prom = (n1 + n2 + n3) / 3.0;

        Console.WriteLine("Promedio: " + prom);
    }
}
