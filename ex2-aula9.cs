using System;

namespace ex2.aula9
{
    class Program
    {
        
            static int Dados(String texto)
            {
                Console.Write(texto);
                int num = Convert.ToInt32(Console.ReadLine());
                return num;
            }

            static bool VerificaValores(int n1, int n2, int n3)
            {
                bool retornar = false;
                if ((n1 < n2 + n3) && (n2 < n1 + n3) && (n3 < n1 + n2))
                {
                    retornar = true;
                }
                return retornar;
            }
            static void Main()
            {
                int a = 0;
                int b = 0;
                int c = 0;
                Console.WriteLine("Verificque se os valores digitados representam um triangulo");
                a = Dados("Informe o lado A: ");
                b = Dados("Informe o lado B: ");
                c = Dados("Informe o lado C: ");
                bool resposta = VerificaValores(a, b, c);
                if (resposta == true)
                {
                    Console.WriteLine("Esses números rpresentam os lados de um triangulo(É veridico)");
                }
                else
                {
                    Console.WriteLine("Esses números Não representam os lados de um triangulo(É falso)");
                }
            }
    }
    
}
