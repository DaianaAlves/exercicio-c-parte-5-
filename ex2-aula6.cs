using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_6
{//melhore adicionando recursos visuais como cores, centralizações, molduras etc.
 //2 – Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.
    class Program
    {
        static void Main(string[] args)
        {
            tatic void Main(string[] args)
            {//inicio
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(5, 2);
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
                Console.SetCursorPosition(7, 10;
                Console.WriteLine("▓                           ▓");
                Console.SetCursorPosition(7, 11);
                Console.WriteLine("▓                           ▓");
                Console.SetCursorPosition(7, 12);
                Console.WriteLine("▓                           ▓");
                Console.SetCursorPosition(7, 13);
                Console.WriteLine("▓                           ▓");
                Console.SetCursorPosition(7, 14;
                Console.WriteLine("▓                           ▓");
                Console.SetCursorPosition(7, 15);
                Console.WriteLine("▓                           ▓");
                Console.SetCursorPosition(7, 16);
                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(7, 5);
                Console.WriteLine("1 -Soma");
                Console.SetCursorPosition(7, 6);
                Console.WriteLine("2 -Subtração");
                Console.SetCursorPosition(7, 7);
                Console.WriteLine("3 -Multiplicação");
                Console.SetCursorPosition(7, 8);
                Console.WriteLine("3 -Divisão");
                Console.SetCursorPosition(25, 5);
                Console.Write("[ ]");
                Console.SetCursorPosition(7, 9);
                Console.WriteLine("Digite o primeiro valor:");
                Console.SetCursorPosition(7, 10);
                Console.WriteLine("Digite o segundo valor:");
                Console.SetCursorPosition(26, 5);
                int op = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(25, 8);
                Console.ForegroundColor = ConsoleColor.Green;
                double n1, n2, r;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Opção 1");
                        r = n1 + n2;
                        Console.WriteLine(n1 + " +" + n2 " = " + r);
           

            break;
                    case 2:
                        Console.WriteLine("Opção 2");
                        r = n1 - n2;
                        Console.WriteLine(n1 + " - " + n2 " = " + r);



                        break; 

                     case 3:
                            Console.WriteLine("Opção 3");
                        r = n1 * n2;
                        Console.WriteLine(n1 + " x" + n2 " = " + r);


                        break;
                    case 4:
                        Console.WriteLine("Opção 4");
                        r = n1 / n2;
                        Console.WriteLine(n1 + " / " + n2 " =" + r);


                        break;
                    default:
                           Console.WriteLine("Nenhuma");
            break;
        }
        Console.ReadKey();

            }
}
}
