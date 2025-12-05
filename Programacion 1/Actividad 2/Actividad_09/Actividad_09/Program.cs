using System;

class A9
{
    static void Main()
    {
        int num, suma = 0, cont = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Número " + i + ": ");
            num = int.Parse(Console.ReadLine());

            if (num % 6 == 0)
            {
                suma += num;
                cont++;
            }
        }

        if (cont > 0)
            Console.WriteLine("Promedio: " + (suma / (double)cont));
        else
            Console.WriteLine("No hay números divisibles por 2 y 3.");
    }
}
