using System;

class A7
{
    static void Main()
    {
        int pares = 0, impares = 0, num;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Número " + i + ": ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) pares++;
            else impares++;
        }

        Console.WriteLine("Pares: " + (pares * 100 / 10.0) + "%");
        Console.WriteLine("Impares: " + (impares * 100 / 10.0) + "%");
    }
}
