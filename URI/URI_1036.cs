using System;
using System.Linq;

namespace URI
{
    class URI_1036
    {
        static void Main (string [] args)
        {
            double a, b, c, r1, r2;
            string valores = Console.ReadLine();
            double[] valoresdouble = valores.Split(' ').Select(x => double.Parse(x)).ToArray();
            a = valoresdouble[0];
            b = valoresdouble[1];
            c = valoresdouble[2];

            if (2 * a == 0 || (((b * b) - (4 * a * c)) < 0))
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = ((-b + Math.Sqrt(((b * b) - (4 * a * c)))) / (2 * a));
                r2 = ((-b - Math.Sqrt(((b * b) - (4 * a * c)))) / (2 * a));
                Console.WriteLine("R1 = " + String.Format("{0,0:F5}", r1));
                Console.WriteLine("R2 = " + String.Format("{0,0:F5}", r2));
            }

        }
    }
}
