
namespace Practico6
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mensaje = "";
            int Mayor = 0, Menor = 0;
            int Suma5 = 0, c5 = 0, Mayor5 = 0, MenorImpar = 0;
            Double Prom5 = 0, PorPares = 0;
            int ConImpar = 0, ConPar = 0;
            int Con = 0, Numero = 0, Resto5 = 0, Resto2 = 0;
            while (Con < 5)
            {
                Mensaje = "Ingresar numero " + (Con + 1).ToString();
                Console.WriteLine(Mensaje);
                Numero = Convert.ToInt32(Console.ReadLine());
                Resto5 = Numero % 5;
                Resto2 = Numero % 2;
                if (Resto5 == 0)
                {
                    if (c5 == 0)
                    {

                        Mayor5 = Numero;
                    }

                    if (Numero > Mayor5)
                    {

                        Mayor5 = Numero;
                    }
                    c5++;
                    Suma5 = Suma5 + Numero;

                }
                if (Resto2 == 0)
                {
                    ConPar++;
                }
                else
                {
                    if (ConImpar == 0)

                    {

                        MenorImpar = Numero;
                    }

                    if (Numero < MenorImpar)
                    {

                        MenorImpar = Numero;
                    }

                    ConImpar = ConImpar + 1;

                }
                if (Con == 0)
                {
                    Mayor = Numero;
                    Menor = Numero;

                }
                if (Numero > Mayor)
                {
                    Mayor = Numero;

                }
                if (Numero < Menor)
                {
                    Menor = Numero;
                }
                Con = Con + 1;
            }
            if (c5 > 0)
            {
                Prom5 = (Double)Suma5 / c5;
            }
            Console.WriteLine("-----------------------");
            Mensaje = "Promedio de div 5 es " + Prom5.ToString();
            Console.WriteLine(Mensaje);
            Mensaje = "El mayor divisible por 5 es " + Mayor5.ToString();
            Console.WriteLine(Mensaje);
            Mensaje = "El menor de los impares es " + MenorImpar.ToString();
            Console.WriteLine(Mensaje);
            PorPares = (Double)ConPar * 100 / Con;
            Mensaje = "Porcentaje de pares " + PorPares.ToString();
            Console.WriteLine(Mensaje);
            Mensaje = "Mayor de la serie " + Mayor.ToString() + " Menor " +
            Menor.ToString();
            Console.WriteLine(Mensaje);
            Console.ReadLine();
        }
    }
}