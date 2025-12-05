using System;

class A5
{
    static void Main()
    {
        int suma = 0, num;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Número " + i + ": ");
            num = int.Parse(Console.ReadLine());
            suma += num;
        }

        Console.WriteLine("Promedio: " + (suma / 10.0));
    }
}
