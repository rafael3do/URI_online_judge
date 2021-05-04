using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1075
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10000; i++)
            {
                if (i % numero == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
