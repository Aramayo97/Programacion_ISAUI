using System;

class A10
{
    static void Main()
    {
        int nota, aprob = 0, reprob = 0, suma = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write("Nota " + i + ": ");
            nota = int.Parse(Console.ReadLine());

            suma += nota;

            if (nota > 3) aprob++;
            else reprob++;
        }

        Console.WriteLine("Aprobados: " + aprob);
        Console.WriteLine("Reprobados: " + reprob);
        Console.WriteLine("Promedio general: " + (suma / 15.0));
        Console.WriteLine("Promedio aprobados: " + (aprob > 0 ? suma / (double)aprob : 0));
    }
}
