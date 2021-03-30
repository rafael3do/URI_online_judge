using System;
using System.Linq;


namespace URI
{
    class URI_1041
    {
        static void Main()
        {
            float xponto, yponto;
            string valores = Console.ReadLine();
            float[] valoresfloat = valores.Split(' ').Select(x => float.Parse(x)).ToArray();
            xponto = valoresfloat[0];
            yponto = valoresfloat[1];
            if (yponto == 0.0 && xponto == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (yponto == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (xponto == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (xponto > 0 && yponto > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (xponto < 0 && yponto < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (yponto > 0 && xponto < 0)
            {
                Console.WriteLine("Q2");
            }
            else if (yponto < 0 && xponto > 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
