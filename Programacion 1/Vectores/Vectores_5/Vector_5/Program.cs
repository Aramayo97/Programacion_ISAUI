int[] vec = new int[10];
List<int> pares = new List<int>();
List<int> impares = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write("Ingrese número: ");
    vec[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (vec[i] % 2 == 0)
        pares.Add(vec[i]);
    else
        impares.Add(vec[i]);
}

Console.WriteLine("Pares:");
foreach (int n in pares)
    Console.Write(n + " ");

Console.WriteLine("\nImpares:");
foreach (int n in impares)
    Console.Write(n + " ");
