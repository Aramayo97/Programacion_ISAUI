using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VecCodigo = new int[8] { 1, 1, 2, 2, 3, 3, 1, 2 };
            int[] VecVenta = new int[8] { 100, 200, 200, 400, 300, 400, 700, 1000 };
            int Codigo = 0, Con = 0, Suma = 0, b = 0, VentaMayor = 0;
            Double Prom = 0;
            string Mensaje = "";
            Console.Write("Ingresar el código a buscar: ");
            Codigo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < VecCodigo.Length; i++)
            {
                if (VecCodigo[i] == Codigo)
                {
                    Con++;
                    Suma = Suma + VecVenta[i];
                    if (b == 0)
                    {
                        VentaMayor = VecVenta[i];
                        b = 1;
                    }
                    if (VecVenta[i] > VentaMayor)
                        VentaMayor = VecVenta[i];

                }
            }

            if (Con > 0)
                Prom = (Double)Suma / Con;
            Mensaje = "El promedio de ventas del Produco con Código " + Codigo.ToString() + " es: " + Prom.ToString();
            Console.WriteLine(Mensaje);
            Mensaje = " La venta mayor del Produco con Código " + Codigo.ToString() + " es: " + VentaMayor.ToString();
            Console.WriteLine(Mensaje);
            Console.ReadLine();

        }
    }
}