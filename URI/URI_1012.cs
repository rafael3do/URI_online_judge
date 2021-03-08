using System;

namespace URI
{
    class URI_1012
    {
        static void Main(string [] args)
        {
            double pi = 3.14159;
            string linha = Console.ReadLine();
            String[] valores = linha.Split(' ');
            double a = Double.Parse(valores[0]);
            double b = Double.Parse(valores[1]);
            double c = Double.Parse(valores[2]);
            Console.WriteLine("TRIANGULO: " + ((a * c) / 2).ToString("0.000"));
            Console.WriteLine("CIRCULO: " + (pi * (Math.Pow(c, 2))).ToString("0.000"));
            Console.WriteLine("TRAPEZIO: " + (((a + b) * c) / 2).ToString("0.000"));
            Console.WriteLine("QUADRADO: " + (b * b).ToString("0.000"));
            Console.WriteLine("RETANGULO: " + (a * b).ToString("0.000"));
        }
    }
}
