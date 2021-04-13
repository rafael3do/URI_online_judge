using System;


namespace URI
{
    class URI_1051
    {
        static void Main (string [] args)
        {
            double valor, saida;
            valor = double.Parse(Console.ReadLine());
            if (valor > 0.00 && valor <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (valor >= 2000.01 && valor <= 3000.00)
            {
                valor -= 2000;
                saida = valor * .08;
                Console.WriteLine("R$ {00:F2}", saida);
            }
            else if (valor >= 3000.01 && valor <= 4500.00)
            {
                valor -= 3000;
                saida = valor * .18 + 80;
                Console.WriteLine("R$ {00:F2}", saida);
            }
            else if (valor > 4500.00)
            {
                saida = (valor - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
                Console.WriteLine("R$ {00:F2}", saida);
            }
        }
    }
}
