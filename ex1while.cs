using System;

namespace ex1_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int inici, fin;
            Console.Write("Digite o número inicial:");
            inici = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            fin = int.Parse(Console.ReadLine());
            Console.WriteLine(inici);
            while (inici < fin)
            {
                inici= inici + 1;
                Console.WriteLine(inici);
            }
            Console.ReadKey();
        }
    }
    }
    

