int[] A = new int[5];
int[] B = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("A[" + i + "]: ");
    A[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    B[i] = A[4 - i];
}

Console.WriteLine("Vector invertido:");
for (int i = 0; i < 5; i++)
{
    Console.Write(B[i] + " ");
}
