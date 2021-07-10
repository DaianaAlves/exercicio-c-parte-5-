using System;

namespace exercicio1.aula9
{
    class Program
    {
        static void Mensagem(String texto)
        {
            Console.WriteLine(texto);
        }

        static Double Dados(String texto)
        {
            Console.Write(texto);
            Double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }

        static Double Somar(Double num1, Double num2)
        {
            Double total = 0;
            total = num1 + num2;
            return total;
            //return num1 + num2;
        }

        static Double Subtrair(Double num1, Double num2)
        {
            Double total = 0;
            total = num1 - num2;
            return total;
            //return num1 + num2;
        }

        static Double Multiplicar(Double num1, Double num2)
        {
            Double total = 0;
            total = num1 * num2;
            return total;
            //return num1 + num2;
        }

        static Double Dividir(Double num1, Double num2)
        {
            Double total = 0;
            if (num2 > 0)
            {
                total = 0;
                total = num1 / num2;
            }
            else
            {
                total = 0;
            }
            return total;
        }

        static void Main()
        {
            Double n1 = 0;
            Double n2 = 0;
            Double total = 0;
            String op = "";

            
            n1 = Dados("Informe o primeiro valor: ");
            n2 = Dados("Informe o segundo valor: ");
            Console.Write("Informe a operação a ser realizada (+ ,-, /, *):");
            op = Console.ReadLine();

            if (op == "+")
            {
                total = Somar(n1, n2);
                Console.WriteLine(n1 + " + " + n2 + " = " + total);
            }

            if (op == "-")
            {
                total = Subtrair(n1, n2);
                Console.WriteLine(n1 + " - " + n2 + " = " + total);
            }

            if (op == "*")
            {
                total = Multiplicar(n1, n2);
                Console.WriteLine(n1 + " * " + n2 + " = " + total);
            }

            if (op == "/")
            {
                total = Dividir(n1, n2);
                Console.WriteLine(n1 + " / " + n2 + " = " + total);
            }

            Console.ReadKey();
        }
    }
}


    
