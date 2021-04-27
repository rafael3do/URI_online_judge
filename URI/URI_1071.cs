using System;

namespace URI
{
    class URI_1071
    {
        static void Main (string [] args)
        {           
            int z = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine(z.ToString());
            }
            else if (x < y)
            {
                for (x = x + 1; x < y; x++)
                {
                    if (x % 2 == 1 || x % 2 == -1)
                    {
                        z += x;
                    }

                }
                Console.WriteLine(z.ToString());
            }
            else if (x > y)
            {
                for (y = y + 1; y < x; y++)
                {
                    if (y % 2 == 1 || y % 2 == -1)
                    {
                        z += y;
                    }
                }
                Console.WriteLine(z.ToString());
            }
        }
    }
}
