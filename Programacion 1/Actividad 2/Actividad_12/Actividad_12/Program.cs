using System;

class A12
{
    static void Main()
    {
        int dia, diaMayor = 0;
        double min, max, mayorAmp = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Día (número): ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Temp mínima: ");
            min = double.Parse(Console.ReadLine());
            Console.Write("Temp máxima: ");
            max = double.Parse(Console.ReadLine());

            double amp = max - min;

            if (i == 1 || amp > mayorAmp)
            {
                mayorAmp = amp;
                diaMayor = dia;
            }
        }

        Console.WriteLine("El día con mayor amplitud fue el día: " + diaMayor);
    }
}
