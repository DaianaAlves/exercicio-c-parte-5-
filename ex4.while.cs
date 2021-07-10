using System;

namespace ex4.
{
    class Program
{
    static void Main(string[] args)
    {

        int[] n1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(n1[i] + ",1 2 3 4 5 6 7 8 9 10");
            i = i + 1;
        }
        Console.ReadKey();
    }
}
