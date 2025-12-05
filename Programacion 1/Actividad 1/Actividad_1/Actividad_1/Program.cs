using System;

class Actividad1
{
    static void Main()
    {
        int numero, mayor = int.MinValue, menor = int.MaxValue;
        int sumaPares = 0, cantidadPares = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese número {i}: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > mayor) mayor = numero;
            if (numero < menor) menor = numero;

            if (numero % 2 == 0)
            {
                sumaPares += numero;
                cantidadPares++;
            }
        }

        double promedio = (cantidadPares > 0) ? (double)sumaPares / cantidadPares : 0;

        Console.WriteLine($"Mayor: {mayor}");
        Console.WriteLine($"Menor: {menor}");
        Console.WriteLine($"Promedio de pares: {promedio}");
    }
}
