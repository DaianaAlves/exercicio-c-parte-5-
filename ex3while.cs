using System;

namespace ex3while
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, quant = 0, i = 0;
            while (i < 10)
            {
                Console.WriteLine("Escreva um número:");
                num = int.Parse(Console.ReadLine());
                i = i + 1;
                if (num < 0)
                {
                    quant = quant + 1;
                }
            }

            Console.WriteLine("Apenas: " + quant + " são números  negativos");


            Console.ReadKey();
        }
    }
}
