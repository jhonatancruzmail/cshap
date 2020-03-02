using System;

class Program
{
        static decimal precioproducto = 0;
        static decimal precioproductoconiva=0;
        static int categoriaproducto = 0;

        static void Main(string[] args)
        {


            Console.WriteLine("porfavor ingrese el costo del producto");
            decimal.TryParse(Console.ReadLine(), out precioproducto);
            Console.WriteLine("porfavor ingrese el codigo de producto");
            Int32.TryParse(Console.ReadLine(), out categoriaproducto);

            if (categoriaproducto == 1)
            {
                precioproductoconiva = porcentaje5();
                Console.WriteLine("el precio del productocon iva es: {0:c}" + precioproductoconiva);
            }
            if (categoriaproducto == 2)
            {
                precioproductoconiva = porcentaje10();
                Console.WriteLine("el precio del productocon iva es: {0:c}" + precioproductoconiva);
            }
            if (categoriaproducto == 3)
            {
                precioproductoconiva = porcentaje19();
                Console.WriteLine("el precio del productocon iva es: {0:c}" + precioproductoconiva);
            }
            Console.ReadLine();
        }
        public static decimal porcentaje5()
        {
        decimal aux=0.05M;
        
        precioproducto += (precioproducto * aux);
        return precioproducto;
        }

        public static decimal porcentaje10()
        {
        decimal aux=0.10M;
        
        precioproducto += (precioproducto * aux);
        return precioproducto;
        }

        public static decimal porcentaje19()
        {
        decimal aux=0.19M;
        
        precioproducto += (precioproducto * aux);
        return precioproducto;
        }

}

