using System;


namespace URI
{
    class URI_1013
    {
        static void Main (string[] args)
        {
            int a, b, c, MaiorAB, MaiorABC;
            string linha = Console.ReadLine();
            String[] valores = linha.Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
            Console.WriteLine(MaiorABC + " eh o maior");
        }
    }
}
