using System;

namespace ex4.aula7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[20];
            int maior, menor, i;
            for (i = 0; i <= 19; i++)
            {
                Console.WriteLine("Digite um número inteiro:");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            maior = numeros[0];
            for (i = 1; i <= 19; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }
            menor = numeros[0];
            for (i = 1; i <= 19; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];

                }
            }

            Console.WriteLine("O maior número :" + maior);
            Console.WriteLine("O menor número :" + menor);
            Console.ReadKey();
        }
    }
    }

