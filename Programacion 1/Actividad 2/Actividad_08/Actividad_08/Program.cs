using System;

class A8
{
    static void Main()
    {
        int num, mayor1 = 0, menor2 = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Número " + i + ": ");
            num = int.Parse(Console.ReadLine());

            if (i == 1) mayor1 = num;
            if (i == 6) menor2 = num;

            if (i <= 5 && num > mayor1) mayor1 = num;
            if (i >= 6 && num < menor2) menor2 = num;
        }

        Console.WriteLine("Mayor primera mitad: " + mayor1);
        Console.WriteLine("Menor segunda mitad: " + menor2);
    }
}
