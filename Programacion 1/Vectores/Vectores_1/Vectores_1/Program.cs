int[] vec = new int[10];
int mayor, menor, suma = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Ingrese número: ");
    vec[i] = int.Parse(Console.ReadLine());
}

mayor = vec[0];
menor = vec[0];

for (int i = 0; i < 10; i++)
{
    suma += vec[i];

    if (vec[i] > mayor)
        mayor = vec[i];

    if (vec[i] < menor)
        menor = vec[i];
}

double promedio = (double)suma / 10;

Console.WriteLine("Mayor: " + mayor);
Console.WriteLine("Menor: " + menor);
Console.WriteLine("Promedio: " + promedio);
