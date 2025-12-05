int[] A = new int[5];
int[] B = new int[5];
int[] C = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("A[" + i + "]: ");
    A[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.Write("B[" + i + "]: ");
    B[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    C[i] = A[i] + B[i];
    Console.WriteLine("C[" + i + "] = " + C[i]);
}
