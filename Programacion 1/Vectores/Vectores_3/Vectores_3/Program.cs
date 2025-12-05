int[] dni = new int[10];
string[] nombres = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Ingrese DNI: ");
    dni[i] = int.Parse(Console.ReadLine());

    Console.Write("Ingrese nombre: ");
    nombres[i] = Console.ReadLine();
}

Console.Write("Ingrese DNI a buscar: ");
int buscado = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i < 10; i++)
{
    if (dni[i] == buscado)
    {
        Console.WriteLine("Persona: " + nombres[i]);
        encontrado = true;
        break;
    }
}

if (!encontrado)
    Console.WriteLine("No se encuentra la persona.");
