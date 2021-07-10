using System;

namespace ex3_aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioa, salarion, r, dif;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("▓  Escolha uma opção:       ▓");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 15);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("1- Gerente 10%");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("2 -Analista 20%");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("3 - Tecnico 30%");
            Console.SetCursorPosition(20, 8);
            Console.Write("[ ]");
            Console.SetCursorPosition(20, 9);
            int cargo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do seu salario atual:");
            salarioa = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(25, 5);
            Console.SetCursorPosition(26, 5);
            
            Console.SetCursorPosition(25, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            
            switch (cargo)
            {
                case 1:
                    
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("Opção 1");
                    r = salarioa * 1.1;
                    dif = salarioa - r;
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("seu salario atual era:" + salarioa);
                    Console.SetCursorPosition(7, 14);
                    Console.WriteLine("novo salario:" + r);
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("DIFERENÇA:" + dif);




                    break;
                case 2:
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("Opção 1");
                    r = salarioa * 1.2;
                    dif = salarioa - r;
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("seu salario atual era:" + salarioa);
                    Console.SetCursorPosition(7, 14);
                    Console.WriteLine("novo salario:" + r);
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("DIFERENÇA:" + dif);

                    break;

                case 3:
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("Opção 1");
                    r = salarioa * 1.3;
                    dif = salarioa - r;
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("seu salario atual era:" + salarioa);
                    Console.SetCursorPosition(7, 14);
                    Console.WriteLine("novo salario:" + r);
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("DIFERENÇA:" + dif);




                    break;
                default:
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("Nenhuma");
                    break;
            }
            Console.ReadKey();

        }
    }
}
