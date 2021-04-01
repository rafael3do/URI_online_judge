using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1043
    {
        static void Main (string [] args)
        {
            double a, b, c, perimetro, area;
            string valores = Console.ReadLine();
            double[] valoresfloat = valores.Split(' ').Select(x => double.Parse(x)).ToArray();
            a = valoresfloat[0];
            b = valoresfloat[1];
            c = valoresfloat[2];
            if ((a < (double)(b + c) && (b < (double)(a + c)) && (c < (double)(b + a))))
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = {0:F1}", perimetro);
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = {0:F1}", area);
            }
        }
    }
}
