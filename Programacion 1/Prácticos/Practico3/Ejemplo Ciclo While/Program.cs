int Con = 0, Suma = 0;
int Nro = 0, Mayor = 0;
string Msj = "";
double Prom = 0;

while (Con < 10)
{
    Msj = "Ingresar número " + (Con + 1).ToString();
    Console.WriteLine(Msj);

    Nro = Convert.ToInt32(Console.ReadLine());

    // Guardar el primer número como mayor
    if (Con == 0)
    {
        Mayor = Nro;
    }

    // Comparar para actualizar el mayor
    if (Nro > Mayor)
    {
        Mayor = Nro;
    }

    Suma = Suma + Nro;
    Con = Con + 1;
}

Console.WriteLine("------------------------");

Prom = (double)Suma / Con;

Msj = "El promedio es " + Prom.ToString();
Console.WriteLine(Msj);

Msj = "El mayor número de la serie es " + Mayor.ToString();
Console.WriteLine(Msj);

Console.ReadLine();
