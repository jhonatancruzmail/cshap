using System;

class Program
{

    static void Main(string[] args)

    {
        aprendiz apsena = new aprendiz();
        apsena.Nombres = "jhonatan stiven";
        apsena.apellidos = "stiven cruz";
        apsena.Direccion = "cll 2 20-39 villas de snatamarta";
        saludo(apsena); 
    }
    private static void saludo(aprendiz apsena)
    {
        Console.WriteLine("bienvenido, sr(a )" + apsena.Nombres);
        Console.WriteLine(apsena.apellidos);
         Console.WriteLine(apsena.Direccion);
        Console.ReadLine();
    }
}

