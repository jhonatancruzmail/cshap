using System;

class Program
{
    static void Main(string[] args)
    {
        int edad = 0;
        string genero = "";
        Console.WriteLine("porfavor ingrese la edad: ");
        Int32.TryParse(Console.ReadLine(), out edad);
        Console.WriteLine("escriba la inicial desu genero M/H: ");
        genero = Console.ReadLine();

        if (edad >= 18  genero == "m")
        {
            Console.WriteLine("bienvenidas");


        }
        else
        {
            Console.WriteLine("no cumple con los requisitos");
        }

        Console.ReadLine();
    }
}
