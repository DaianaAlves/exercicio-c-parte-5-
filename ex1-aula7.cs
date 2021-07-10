using System;

namespace exercicio1_aula7
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n;
            Console.WriteLine("Digite um numero:");
            n = Convert.ToDouble(Console.ReadLine());
            double tab, c;
            Console.WriteLine("A tabuada de :" + n);
            for (c = 0; c <= 10; c++)
            {
                tab = n * c;
                Console.WriteLine(tab);
               
            }
            Console.ReadKey();
        }
    }
}
