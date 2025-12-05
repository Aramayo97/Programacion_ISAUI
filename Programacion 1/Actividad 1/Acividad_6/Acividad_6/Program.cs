using System;

class Actividad6
{
    static void Main()
    {
        int numero;
        int mayor = int.MinValue;
        bool existe = false;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese número {i}: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 6 == 0)
            {
                if (numero > mayor) mayor = numero;
                existe = true;
            }
        }

        if (existe)
            Console.WriteLine("El mayor divisible por 2 y 3 es: " + mayor);
        else
            Console.WriteLine("No se ingresaron números divisibles por 2 y 3.");
    }
}
