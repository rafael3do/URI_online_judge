using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1079
    {
        static void Main(string[] args)
        {
            int N;
            float value1, value2, value3;
            float average;
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                value1 = float.Parse(Console.Read().ToString());
                value2 = float.Parse(Console.Read().ToString());
                value3 = float.Parse(Console.Read().ToString());
                average = (((value1 * 2) + (value2 * 3) + (value3 * 5)))/ 10;
                Console.WriteLine(average.ToString());
            }
            Console.ReadKey();
        }
    }
}
