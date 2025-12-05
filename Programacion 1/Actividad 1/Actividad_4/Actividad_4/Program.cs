using System;

class Actividad4
{
    static void Main()
    {
        int codigo;
        int v1 = 0, v2 = 0, v3 = 0;

        Console.WriteLine("Ingrese código de voto (1-3) o 999 para terminar:");

        while (true)
        {
            Console.Write("Código: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 999) break;

            if (codigo == 1) v1++;
            else if (codigo == 2) v2++;
            else if (codigo == 3) v3++;
            else Console.WriteLine("Código inválido.");
        }

        int total = v1 + v2 + v3;

        Console.WriteLine($"Equipo 1: {v1} votos ({(v1 * 100.0) / total:0.00}%)");
        Console.WriteLine($"Equipo 2: {v2} votos ({(v2 * 100.0) / total:0.00}%)");
        Console.WriteLine($"Equipo 3: {v3} votos ({(v3 * 100.0) / total:0.00}%)");
    }
}
