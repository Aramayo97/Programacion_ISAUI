using System;

class A3
{
    static void Main()
    {
        Console.Write("Inglés: ");
        int ing = int.Parse(Console.ReadLine());
        Console.Write("Francés: ");
        int fra = int.Parse(Console.ReadLine());
        Console.Write("Portugués: ");
        int por = int.Parse(Console.ReadLine());

        int total = ing + fra + por;

        Console.WriteLine("Inglés: " + (ing * 100.0 / total) + "%");
        Console.WriteLine("Francés: " + (fra * 100.0 / total) + "%");
        Console.WriteLine("Portugués: " + (por * 100.0 / total) + "%");
    }
}
