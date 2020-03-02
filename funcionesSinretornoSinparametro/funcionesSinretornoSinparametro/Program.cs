using System;

class Program
{
    static void Main(string[] args)
    {
        calculadora();
    }
    public static void calculadora()
    {
        int operacion = 0;
        Console.WriteLine("Seleccione una operacion:");
        Console.WriteLine("1.Suma");
        Console.WriteLine("2.Resta");
        Console.WriteLine("3.Multiplicacion");
        Console.WriteLine("4.Division");
        Int32.TryParse(Console.ReadLine(), out operacion);
        
        switch (operacion)
        {
            case 0:
                Console.WriteLine("Numero de operacion no se puede realizar");
                calculadora();
                break;
            case 1:
                Console.WriteLine("Operacion selecionada es suma");
                suma();
                break;
            case 2:
                Console.WriteLine("Operacion selecionada es resta");
                resta();
                break;
            case 3:
                Console.WriteLine("Operacion selecionada es multiplicacion");
                multiplicacion();
                break;
            case 4:
                Console.WriteLine("Operacion selecionada es division");
                division();
                break;
        }

    }
    public static void suma()
    {
        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.Write("Ingrese el numero 1:");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.Write("Ingrese el numero 2:");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num2 + num1;
        Console.Write("El resltado de la suma es:" + resultado);
        Console.ReadLine();
        pregunta();
    }
    public static void resta()
    {
        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.Write("Ingrese el numero 1:");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.Write("Ingrese el numero 2:");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num2 - num1;
        Console.Write("El resltado de la resta es:" + resultado);
        Console.ReadLine();
        pregunta();
    }
            public static void multiplicacion()
    {
        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.Write("Ingrese el numero 1:");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.Write("Ingrese el numero 2:");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num2*num1;
        Console.Write("El resltado de la multiplicacion es:" + resultado);
        Console.ReadLine();
        pregunta();
    }
        public static void division()
    {
        int resultado = 0;
        int num1 = 0;
        int num2 = 0;
        Console.Write("Ingrese el numero 1:");
        Int32.TryParse(Console.ReadLine(), out num1);
        Console.Write("Ingrese el numero 2:");
        Int32.TryParse(Console.ReadLine(), out num2);
        resultado = num1/num2;
        Console.Write("El resltado de la division es:" + resultado);
        Console.ReadLine();
        pregunta();
    }
        public static void pregunta()
        {
            Console.Write("Desea realizar otra operacion? (Y/N)");
            string respuesta = ""; 
            respuesta=Console.ReadLine();
            if (respuesta == "y")
            {
                calculadora();
            }
            else
            {
                Console.WriteLine("Adios");
                Console.ReadLine();
            }
            
        }
    
}
