using System;

class A14
{
    static void Main()
    {
        int p1, p2, rec;
        int promo = 0, regular = 0, libre = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("\nAlumno " + i);

            Console.Write("Parcial 1: ");
            p1 = int.Parse(Console.ReadLine());

            Console.Write("Parcial 2: ");
            p2 = int.Parse(Console.ReadLine());

            if (p1 >= 6 && p2 >= 6)
            {
                promo++;
            }
            else if (p1 >= 4 && p2 >= 4)
            {
                regular++;
            }
            else
            {
                Console.Write("Recuperatorio: ");
                rec = int.Parse(Console.ReadLine());

                if (rec >= 4) regular++;
                else libre++;
            }
        }

        Console.WriteLine("\nPromocionados: " + promo);
        Console.WriteLine("Regulares: " + regular);
        Console.WriteLine("Libres: " + libre);
    }
}
