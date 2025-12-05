int[] vec = new int[10];
Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    vec[i] = rnd.Next(1, 101); // 1 a 100
}

Console.WriteLine("Vector generado:");
for (int i = 0; i < 10; i++)
    Console.Write(vec[i] + " ");

Console.WriteLine("\nDivisibles por 6:");
for (int i = 0; i < 10; i++)
    if (vec[i] % 6 == 0)
        Console.Write(vec[i] + " ");

Console.WriteLine("\nDivisibles por 2 y 5:");
for (int i = 0; i < 10; i++)
    if (vec[i] % 2 == 0 && vec[i] % 5 == 0)
        Console.Write(vec[i] + " ");
