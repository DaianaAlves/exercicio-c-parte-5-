using System;

namespace exercicio2_aula7
{
    class Program
    {
        static void Main(string[] args)
        { 
            double n;
            Console.WriteLine("Digite o valor de n:");
            n = Convert.ToDouble(Console.ReadLine());

            double a;
           
            
            for (a = 1; a <= n; a ++ ) 
            {
                double r;
                r = a ;
                Console.WriteLine(r);
                
            }
            
            Console.ReadKey();
        }
    }
}
