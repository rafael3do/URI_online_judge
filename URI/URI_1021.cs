using System;

namespace URI
{
    class URI_1021
    {
        static void Main(string[] args)
        {
            double N;
            int nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda50, moeda25, moeda10, moeda5, moeda01;

            N = Convert.ToDouble(Console.ReadLine());
            int notas = (int)N;
            double moedas = (N - notas) * 100;
            if ((moedas * 1000) % 10 == 9)
            {
                moedas++;
            }
            nota100 = notas / 100;
            notas = notas % 100;
            nota50 = notas / 50;
            notas = notas % 50;
            nota20 = notas / 20;
            notas = notas % 20;
            nota10 = notas / 10;
            notas = notas % 10;
            nota5 = notas / 5;
            notas = notas % 5;
            nota2 = notas / 2;
            notas = notas % 2;

            moeda1 = notas / 1;
            notas = notas % 1;

            moeda50 = (int)moedas / 50;
            moedas = moedas % 50;
            moeda25 = (int)moedas / 25;
            moedas = moedas % 25;
            moeda10 = (int)moedas / 10;
            moedas = moedas % 10;
            moeda5 = (int)moedas / 5;
            moedas = moedas % 5;
            moeda01 = (int)moedas / 1;


            Console.WriteLine("NOTAS:");
            Console.WriteLine((int)nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine((int)nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine((int)nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine((int)nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine((int)nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine((int)nota2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
        }
    }
}
