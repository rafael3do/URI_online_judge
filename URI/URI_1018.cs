using System;

namespace URI
{
    class URI_1018
    {
        static void Main(string[] args)
        {
            int N , nota100, nota50, nota20, nota10, nota5, nota2, nota1;
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N);
            nota100 = N / 100;
            N -= (nota100 * 100);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");

            nota50 = N / 50;
            N -= (nota50 * 50);
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");

            nota20 = N / 20;
            N -= (nota20 * 20);
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");

            nota10 = N / 10;
            N -= (nota10 * 10);
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");

            nota5 = N / 5;
            N -= (nota5 * 5);
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");

            nota2 = N / 2;
            N -= (nota2 * 2);
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");

            nota1 = N / 1;
            N -= (nota1 * 1);
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
        }
    }
}
