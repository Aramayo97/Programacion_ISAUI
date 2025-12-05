using System;

class A4
{
    static void Main()
    {
        Console.Write("Precio unitario: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Cantidad: ");
        int cant = int.Parse(Console.ReadLine());

        Console.Write("Código de pago (1=Efectivo, 2=Crédito): ");
        int cod = int.Parse(Console.ReadLine());

        double subtotal = precio * cant;
        double ajuste = 0;
        double total = subtotal;

        if (cod == 1)
        {
            if (subtotal > 10000)
            {
                ajuste = subtotal * 0.10;
                total = subtotal - ajuste;
            }
        }
        else if (cod == 2)
        {
            ajuste = subtotal * 0.30;
            total = subtotal + ajuste;
        }

        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("Ajuste (+/-): " + ajuste);
        Console.WriteLine("Total a pagar: " + total);
    }
}
