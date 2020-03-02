using System;

class Program
{
    static void Main(string[] args)
    {
        string nombreproducto = "";
        Console.Write("porfavor ingresa nombre de un producto ");
        nombreproducto = Console.ReadLine();
        //estructra repetitiva para preguntar por el nombre del producto
        while (nombreproducto != "exit")
        {
            Console.WriteLine("nombre del producto ingresado es " + nombreproducto);
            Console.WriteLine();
            Console.WriteLine("porfavor ingresa nombre de producto ");
            nombreproducto = Console.ReadLine();
            Console.ReadLine();
        }
        Console.WriteLine("fin del programa");
        Console.ReadLine();

    }
}
