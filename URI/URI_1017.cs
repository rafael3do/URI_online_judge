using System;

namespace URI
{
    class URI_1017
    {
        static void Main(string [] args)
        {
            float horas, km,distancia;            
            horas = float.Parse(Console.ReadLine());
            km = float.Parse(Console.ReadLine());
            distancia = ((km * horas) / 12);
            Console.WriteLine(distancia.ToString("N3"));
        }

    }
}
