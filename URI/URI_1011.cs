using System;


namespace URI
{
    class URI_1011
    {
        static void  Main(string[] args)
        {
            double pi = 3.14159;
            double esfera, volume;
            esfera = double.Parse(Console.ReadLine());
            volume = (4 / 3.0) * pi * (Math.Pow(esfera, 3));
            Console.WriteLine("VOLUME = " + volume.ToString("0.000"));
        }
    }
}
