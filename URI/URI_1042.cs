using System;
using System.Linq;


namespace URI
{
    class URI_1042
    {
        static void Main (string [] agrs)
        {
            int valor1, valor2, valor3, min, med, max;
            med = 0;
            max = 0;
            string valores = Console.ReadLine();
            int[] valoresfloat = valores.Split(' ').Select(x => int.Parse(x)).ToArray();
            valor1 = valoresfloat[0];
            valor2 = valoresfloat[1];
            valor3 = valoresfloat[2];
            min = Math.Min(valor1, Math.Min(valor2, valor3));
            if (min == valor1)
            {
                med = Math.Min(valor2, valor3);
                max = Math.Max(valor2, valor3);
            }
            if (min == valor2)
            {
                med = Math.Min(valor1, valor3);
                max = Math.Max(valor1, valor3);
            }
            if (min == valor3)
            {
                med = Math.Min(valor2, valor1);
                max = Math.Max(valor2, valor1);
            }
            Console.WriteLine(min + "\n" + med + "\n" + max + "\n");
            Console.WriteLine(valor1 + "\n" + valor2 + "\n" + valor3);
        }
    }
}
