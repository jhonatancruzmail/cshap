using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroproducto = 0;
        int totalcompra = 0;
        int valorproducto = 0;
        int cantidadproducto = 0;
        int total = 0;
        string respuestacompra = "";
        Console.Write("desea ingresar productos Y/N");
        respuestacompra = (Console.ReadLine());
        while (respuestacompra=="Y")
        {
            numeroproducto++;
            Console.Write("porfavor ingresa valor de producto N" + numeroproducto + ":");
            valorproducto = Convert.ToInt32(Console.ReadLine());

            Console.Write("porfavor ingresa cantidad del producto" + numeroproducto + ":");

            cantidadproducto = Convert.ToInt32(Console.ReadLine());

            total = valorproducto * cantidadproducto;

            Console.Write("desea ingresar mas productos Y/N");
            respuestacompra = (Console.ReadLine());

        }







        Console.WriteLine("valor total de la factura: " + total);
        Console.ReadLine();

    }
}