using System;

class Actividad5
{
    static void Main()
    {
        Console.Write("Ingrese a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("X   Y");
        for (int x = 1; x <= 10; x++)
        {
            int y = a * x + b;
            Console.WriteLine($"{x}   {y}");
        }
    }
}
