using System;

class Program
{

    static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int anio = 0;
            string mesletras = ("mes");

            Console.WriteLine("por favor ingrese dia de naciniento");
            dia=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("por favor ingrese mes de naciniento");
            mes=Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("por favor ingrese año de naciniento");
            anio = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                mesletras = "enero";
                break;
                case 2:
                mesletras = "febrero";
                break;
                case 3:
                mesletras = "marzo";
                break;
                case 4:
                mesletras = "abril";
                break;
                case 5:
                mesletras = "mayo";
                break;
                case 6:
                mesletras = "junio";
                break;
                case 7:
                mesletras = "julio";
                break;
                case 8:
                mesletras = "agosto";
                break;
                case 9:
                mesletras = "septiembre";
                break;
                case 10:
                mesletras = "octubre";
                break;
                case 11:
                mesletras = "noviembre";
                break;
                case 12:
                mesletras = "diciembre";
                break;

                default:
                mesletras="error mes no valido";
                break;

                }
            if (mesletras == "error");
            {
            Console.WriteLine("La fecha ingresada no es valida");

            Console.ReadLine();
            else 
            { 
            Console.WriteLine("el dia de nacimiento es "+ dia+" su mes de nacimiento es"+mesletras+"su año de nacimiento es"+anio);
            }
            }
    }
}
   
