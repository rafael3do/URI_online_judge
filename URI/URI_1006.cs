using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1006
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("MEDIA = " + (((a*2)+(b*3)+(c*5))/10).ToString("F1"));
            Console.ReadKey();
        }

    }
}
