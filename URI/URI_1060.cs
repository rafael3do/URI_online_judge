using System;

namespace URI
{
    class URI_1060
    {
        static void Main (string [] args)
        {
            float valor1, valor2, valor3, valor4, valor5, valor6;
            int quant = 0;
            valor1 = float.Parse(Console.ReadLine());
            valor2 = float.Parse(Console.ReadLine());
            valor3 = float.Parse(Console.ReadLine());
            valor4 = float.Parse(Console.ReadLine());
            valor5 = float.Parse(Console.ReadLine());
            valor6 = float.Parse(Console.ReadLine());
            if (valor1 > 0)
            {
                quant += 1;
            }
            if (valor2 > 0)
            {
                quant += 1;
            }
            if (valor3 > 0)
            {
                quant += 1;
            }
            if (valor4 > 0)
            {
                quant += 1;
            }
            if (valor5 > 0)
            {
                quant += 1;
            }
            if (valor6 > 0)
            {
                quant += 1;
            }

            Console.WriteLine(quant + " valores positivos");
        }
    }
}
