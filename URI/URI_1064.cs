using System;

namespace URI
{
    class URI_1064
    {
        static void Main(string [] args)
        {
            double n1, media = 0, nspos = 0;
            int npos = 0;

            for (int i = 1; i <= 6; i++)
            {
                n1 = double.Parse(Console.ReadLine());
                if (n1 > 0)
                {
                    npos += 1;
                    media += n1;
                }
            }
            nspos = media / npos;

            Console.WriteLine(npos + " valores positivos");
            Console.WriteLine("{0:F1}", nspos);

        }
    }
    
}
