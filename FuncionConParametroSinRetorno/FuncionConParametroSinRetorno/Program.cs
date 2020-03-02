using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "";
        string apellido = "";
        Console.Write("porfavor escribe tu nombre:");
        nombre = Console.ReadLine();
        Console.Write("porfavor escribe tu apellido:");
        apellido = Console.ReadLine();
        MostrarMensaje(nombre, apellido);

    }
    public static void MostrarMensaje(string nombreuser, string apellidouser)
    {
        Console.WriteLine("bienvenido,sr(@) " + nombreuser + " " + apellidouser);
        Console.ReadLine();
    }
}

