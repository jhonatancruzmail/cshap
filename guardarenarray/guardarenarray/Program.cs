using System;

class Program
{
    static void Main(string[] args)
    {
        string nombreproducto = "";
        int numero = 1;
        Console.Write("porfavor ingresa nombre de un producto " + numero+":");
        nombreproducto = Console.ReadLine();
        //estructra repetitiva para preguntar por el nombre del producto
            while (nombreproducto != "exit")
            {
                numero +=1;
                Console.WriteLine("nombre del producto ingresado es " + nombreproducto );
                Console.WriteLine();
                Console.WriteLine("porfavor ingresa nombre de producto " + numero +":");
                nombreproducto = Console.ReadLine();
                Console.ReadLine();
            }
        Console.WriteLine("fin del programa");
        Console.ReadLine();

    }
}
