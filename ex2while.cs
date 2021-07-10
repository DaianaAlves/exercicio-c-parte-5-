using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2while
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, p = 0, maiores = 0, dezoito;
            while (p <= 9)
            {
                Console.WriteLine("Digite sua idade");
                id= int.Parse(Console.ReadLine());
                p = p + 1;
                if (id > 18)
                {
                    maiores = maiores + 1;
                }

            }
            Console.Write("Existem entre vocês:" + maiores + " maiores de 18 anos.");
            Console.ReadKey();
        }
    }
}
