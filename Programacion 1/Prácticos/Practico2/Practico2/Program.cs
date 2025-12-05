using System;

namespace Practico2
{
    class Program
    {
        static void Main(string[] args)
        {
            int CanIngles = 0;
            int CanFrances = 0;
            int CanPor = 0;
            int Suma = 0;

            double PorI = 0, PorF = 0, PorP = 0;
            string Mensaje = "";

            Console.WriteLine("Ingresar cantidad de alumnos de Inglés");
            CanIngles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar cantidad de alumnos de Francés");
            CanFrances = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar cantidad de alumnos de Portugués");
            CanPor = Convert.ToInt32(Console.ReadLine());

            Suma = CanIngles + CanFrances + CanPor;

            PorI = (double)CanIngles * 100 / Suma;
            PorF = (double)CanFrances * 100 / Suma;
            PorP = (double)CanPor * 100 / Suma;

            Console.WriteLine("-------------------");

            Mensaje = "Porcentaje de Inglés: " + PorI.ToString("0.00") + "%";
            Console.WriteLine(Mensaje);

            Mensaje = "Porcentaje de Francés: " + PorF.ToString("0.00") + "%";
            Console.WriteLine(Mensaje);

            Mensaje = "Porcentaje de Portugués: " + PorP.ToString("0.00") + "%";
            Console.WriteLine(Mensaje);

            Console.ReadLine();
        }
    }
}
