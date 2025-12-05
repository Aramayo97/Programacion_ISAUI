

namespace Practico5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0;
            double baseFigura = 0;
            double altura = 0;
            double radio = 0;
            double area = 0;

            Console.WriteLine("CALCULO DE AREAS");
            Console.WriteLine("1 - Triángulo");
            Console.WriteLine("2 - Rectángulo");
            Console.WriteLine("3 - Círculo");
            Console.WriteLine("--------------------");
            Console.Write("Ingrese el código de la figura: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1: // Triángulo
                    Console.Write("Ingrese la base: ");
                    baseFigura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    area = (baseFigura * altura) / 2;
                    Console.WriteLine("El área del triángulo es: " + area);
                    break;

                case 2: // Rectángulo
                    Console.Write("Ingrese la base: ");
                    baseFigura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());

                    area = baseFigura * altura;
                    Console.WriteLine("El área del rectángulo es: " + area);
                    break;

                case 3: // Círculo
                    Console.Write("Ingrese el radio: ");
                    radio = Convert.ToDouble(Console.ReadLine());

                    area = 3.14 * radio * radio;
                    Console.WriteLine("El área del círculo es: " + area);
                    break;

                default:
                    Console.WriteLine("Código incorrecto.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
