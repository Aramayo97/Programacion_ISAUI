
using System;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Suma = 0;
            double Prom = 0;
            string Mensaje = "";

            Console.WriteLine("Ingresar número 1");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar número 2");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar número 3");
            Num3 = Convert.ToInt32(Console.ReadLine());

            Suma = Num1 + Num2 + Num3;

            Prom = (double)Suma / 3;

            Mensaje = "El promedio es " + Prom.ToString();
            Console.WriteLine(Mensaje);

            Console.ReadLine();
        }
    }
}
