using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1002
    {
        static void Main(string[] args)
        {
            double n = 3.14159d;
            double raio =double.Parse(Console.ReadLine());
            double area = n * Math.Pow(raio, 2);
            System.Console.WriteLine("A="+area.ToString("0.0000"));

         
        }

    }
}
