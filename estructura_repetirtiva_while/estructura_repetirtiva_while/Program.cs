using System;

class Program
{
    static void Main(string[] args)
    {
        string nombreusuario = "";
        Console.Write("porfavor igresa tu  nombre ");
        nombreusuario = Console.ReadLine();
        //estructra repetitiva para preguntar por el nombre
        while (nombreusuario != "fin")
        {
            Console.WriteLine("bienvenido(a), senor(a) " + nombreusuario + ".");
            Console.WriteLine();
            Console.WriteLine("por favor, ingresa tu nombre");
            nombreusuario = Console.ReadLine();
            Console.ReadLine();
        }
        Console.WriteLine("fin del programa");
        Console.ReadLine();

    }
}