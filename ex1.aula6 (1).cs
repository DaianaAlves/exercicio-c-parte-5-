using System;

namespace exercicio01_aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(7, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(7, 3);
            Console.WriteLine("▓  Escolha uma opção:       ▓");
            Console.SetCursorPosition(7, 4);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 8);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 9);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 10);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 11);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 12);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 13);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 14);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 15);
            Console.WriteLine("▓                           ▓");
            Console.SetCursorPosition(7, 16);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("1 - Bhaskara");
            Console.SetCursorPosition(7, 6);
            Console.WriteLine("2 - Força");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("3 - Velocidade");
            Console.SetCursorPosition(25, 5);
            Console.Write("[ ]");
            Console.SetCursorPosition(26, 5);
            int op = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(25, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            switch (op)
            {
                case 1:
                    Console.WriteLine("Opção 1");
                    double a, b, c, x1, x2, delta;
                    Console.SetCursorPosition(7, 9);
                    Console.Write("Digite o valor de a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor de b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor de c");
                    c = Convert.ToDouble(Console.ReadLine());
                    delta = Math.Pow(b, 2) - 4 * a * c;
                    x1 = (-(b)) + Math.Sqrt(delta) / (2 * a);
                    x2 = (-(b)) + Math.Sqrt(delta) / (2 * a);
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("Delta =" + delta);
                    Console.SetCursorPosition(7, 13);
                    Console.WriteLine("x1=" + x1);
                    Console.SetCursorPosition(7, 14);
                    Console.WriteLine("x2 =" + x2);

                    break;
                case 2:
                    Console.WriteLine("Opção 2");

                    double m, ac, f;
                    Console.SetCursorPosition(7, 9);
                    Console.Write("Digite o valor da massa:");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor de aceleração:");
                    ac = Convert.ToDouble(Console.ReadLine());
                    f = m * ac;
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("Força =" + f);
                    break;

                case 3:
                    Console.WriteLine("Opção 3");
                    double vo, v, acel, t10;
                    
                    Console.SetCursorPosition(7, 9);
                    Console.Write("Digite o valor da velocidade inicial:");
                    vo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor do tempo:");
                    t10 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o valor da aceleração:");
                    acel = Convert.ToDouble(Console.ReadLine());
                    v = vo + acel * t10;
                    Console.SetCursorPosition(7, 12);
                    Console.WriteLine("velocida =" + v);

                    break;
                default:
                    Console.WriteLine("Nenhuma");
                    break;
            }
            Console.ReadKey();
        }
    }
}
