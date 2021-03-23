using System;
using System.Linq;


namespace URI
{
    class URI_1035
    {
        static void Main (string [] args)
        {
            int a, b, c, d;
            string valores = Console.ReadLine();
            int[] valoresint = valores.Split(' ').Select(x => int.Parse(x)).ToArray();
            a = valoresint[0];
            b = valoresint[1];
            c = valoresint[2];
            d = valoresint[3];
            if ((b > c) && (d > a) && ((c + d) > (a + b)) && ((c > 0) && (d > 0)) && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
