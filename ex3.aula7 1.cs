using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:
            int num, r = 0, i;
            try
            {

                for (i = 0; i <= 10; i++)
                {
                    Console.Write("Digite um número inteiro:");
                    num = int.Parse(Console.ReadLine());
                    if (num > 10)
                    {

                        r = r + num;
                    }
                }
                Console.Write("O resultado é: " + r);
            }
            catch
            {
                Console.WriteLine("O caractere esta incorreto,por favor tente colocar um número inteiro!");
                goto inicio;
            }
            Console.ReadKey();
        }
    }
}


