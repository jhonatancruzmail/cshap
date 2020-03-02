using System;

class Program
{
    static void Main(string[] args)
    {
        int numeronotas = 0;
        Console.WriteLine("====NOTAS====");
        Console.WriteLine("ingrese el numero de notas");
        Int32.TryParse(Console.ReadLine(), out numeronotas);
        string resultado = calcularnotas(numeronotas);
    }

    static string calcularnotas(int numeronotas)
    {
        decimal nota = 0;
        decimal sumanotas = 0;
        decimal promedio = 0;
        
        for (int i = 1; i <= numeronotas; i++)
        {
            Console.WriteLine("ingrese la nota N."+i);
            decimal.TryParse(Console.ReadLine(),out nota);
            sumanotas += nota;
            promedio = sumanotas / i;
            
            

        }
        
        if (promedio >= 6)
        {
            Console.WriteLine("usted ha pasado con un promedio de "+promedio);

        }
        else
        {
            Console.WriteLine("usted ha perdido con un promedio de " + promedio);
        }
        
        Console.ReadLine();
        return "";
    }

}   

