using System;

namespace URI
{
    class URI_1072
    {
        static void Main (string [] args)
        {           
            int y = 0;
            int dent = 0;
            int fora = 0;
           int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (y >= 10 && y <= 20)
                {
                    dent++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dent + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
