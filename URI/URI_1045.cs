using System;
using System.Linq;


namespace URI
{
    class URI_1045
    {
        static void Main (string [] args)
        {
            double a, b, c, tempa, tempb, tempc;
            string valores = Console.ReadLine();
            double[] valoresfloat = valores.Split(' ').Select(x => double.Parse(x)).ToArray();
            a = valoresfloat[0];
            b = valoresfloat[1];
            c = valoresfloat[2];
            tempb = 0;
            tempc = 0;
            tempa = Math.Max(a, Math.Max(b, c));
            if (tempa == a)
            {
                tempb = Math.Max(b, c);
                tempc = Math.Min(b, c);
            }
            if (tempa == b)
            {
                tempb = Math.Max(a, c);
                tempc = Math.Min(a, c);
            }
            if (tempa == c)
            {
                tempb = Math.Max(b, a);
                tempc = Math.Min(b, a);
            }
            if (tempa >= (tempb + tempc))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");

            }
            else if ((tempa * tempa) > ((tempb * tempb) + (tempc * tempc)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if ((tempa * tempa) == ((tempb * tempb) + (tempc * tempc)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if ((tempa * tempa) < ((tempb * tempb) + (tempc * tempc)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if ((tempa == tempb) && (tempa == tempc))
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if (((tempa == tempb) && (tempa != tempc)) || ((tempa == tempc) && (tempa != tempb)) || ((tempb == tempc) && (tempb != tempa)))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

        }
    }
}
