
using System;



class Program
{
    static void Main(string[] args)
    {
        string [] operaciones = new string[5];
        operaciones[0]="Suma";
        operaciones[1]="Resta";
        operaciones[2] = "Multiplicacion";
        operaciones[3] = "Division";
        operaciones[4] = "Error";

        int opusuario = 0;
        int resultado = 0;
        int num1=0;
        int num2=0;
        string respuestausuario = "";
        Console.Write("Desea realizar alguna operacion? (Y/N): ");
        respuestausuario = Console.ReadLine();
        Console.WriteLine("   ");

        
        while (respuestausuario=="y")
        {
            Console.Write("Escriba un numero: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   ");
            Console.Write("Escriba un numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   ");
            

            for (int op = 0; op <= 3;op++)
            {
                Console.WriteLine((op+1) + ". " + operaciones[op]);
                Console.WriteLine("   ");
            }
            Console.Write("Selecione una operacion: ");
            opusuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   ");

            switch (opusuario)
            { 
                case 1:
                    Console.Write("Operacion selecionada es una suma y el resultado de "+num1+" + "+num2+" = " );
                     resultado = num1 + num2;
                    Console.Write(resultado);
                    Console.WriteLine("   ");
                    break;
                case 2:
                    Console.Write("Operacion selecionada es una resta " + num1 + " - " + num2+" = " );
                    resultado = num1 - num2;
                    Console.Write(resultado);
                    Console.WriteLine("   ");
                    break;
                case 3:
                    Console.Write("Operacion selecionada es una multiplicacion " + num1 + " X " + num2+" = " );
                    resultado = num1 * num2;
                    Console.Write(resultado);
                    Console.WriteLine("   ");
                    break;
                case 4:
                    Console.Write("Operacion selecionada es una division " + num1 + " / " + num2+" = " );
                    resultado = num1 / num2;
                    Console.Write(resultado);
                    Console.WriteLine("   ");
                    break;
            default:
                    Console.Write("Error");
                    Console.WriteLine("   ");
                    break;




            }
            Console.WriteLine("   ");
            Console.WriteLine("Desea realizar alguna otra operacion? (Y/N)");
            respuestausuario = Console.ReadLine();


        }

        Console.ReadLine();


    }
}
