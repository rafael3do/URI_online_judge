using System;

namespace URI
{
    class URI_1015
    {
        static void Main (string[] args)
        {
            String linha1 = Console.ReadLine();
            String linha2 = Console.ReadLine();            
            String[] valores1 = linha1.Split(' ');
            double x1 = double.Parse(valores1[0]);
            double y1 = double.Parse(valores1[1]);

            String[] valores2 = linha2.Split(' ');
            double x2 = double.Parse(valores2[0]);
            double y2 = double.Parse(valores2[1]);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(distancia.ToString("F4"));
            


        }
    }
}
