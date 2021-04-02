using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1044
    {
        static void Main(string[] args)
        {
            int a, b;
            string valores = Console.ReadLine();
            int[] valoresfloat = valores.Split(' ').Select(x => int.Parse(x)).ToArray();
            a = valoresfloat[0];
            b = valoresfloat[1];
            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
