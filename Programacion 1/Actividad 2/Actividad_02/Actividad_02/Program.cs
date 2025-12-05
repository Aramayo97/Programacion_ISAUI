using System;

class A2
{
    static void Main()
    {
        Console.Write("Cantidad: ");
        int cant = int.Parse(Console.ReadLine());
        Console.Write("Precio unitario: ");
        double precio = double.Parse(Console.ReadLine());

        double total = cant * precio;

        if (total > 10000)
            total = total * 0.85; // 15% descuento

        Console.WriteLine("Total a pagar: " + total);
    }
}
