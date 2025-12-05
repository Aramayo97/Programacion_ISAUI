using System;

class A6
{
    static void Main()
    {
        int num, mayor = 0, menor = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Número " + i + ": ");
            num = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                mayor = menor = num;
            }

            if (num > mayor) mayor = num;
            if (num < menor) menor = num;
        }

        Console.WriteLine("Mayor: " + mayor + " - Menor: " + menor);
    }
}
