using System;


namespace htc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aprendices = new string[3];

            for (int apr = 0; apr <= 2; apr++)
            {
                Console.Write("pórfavor ingrese el aprendiz # " + (apr + 1));
                aprendices[apr] = Console.ReadLine();

            }
            for (int apr = 0; apr <= 2; apr++)
            {
                Console.WriteLine("aprendiz # " + (apr+1) + aprendices[apr]);
            }
            Console.ReadLine();
        }
    }
}
