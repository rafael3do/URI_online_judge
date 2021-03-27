using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1038
    {
        static void Main (string [] args)
        {
            double[] lanche = new double[] { 0, 1, 2, 3, 4 };
            string valores = Console.ReadLine();
            int[] valoresint = valores.Split(' ').Select(x => int.Parse(x)).ToArray();
            int item = valoresint[0];
            int quantidade = valoresint[1];
            switch (item)
            {
                case 1:
                    lanche[0] = quantidade * 4;
                    Console.WriteLine("Total: R$ " + String.Format("{0:0.00}", lanche[0]));
                    break;
                case 2:
                    lanche[1] = quantidade * 4.50;
                    Console.WriteLine("Total: R$ " + String.Format("{0:0.00}", lanche[1]));
                    break;
                case 3:
                    lanche[2] = quantidade * 5;
                    Console.WriteLine("Total: R$ " + String.Format("{0:0.00}", lanche[2]));
                    break;
                case 4:
                    lanche[3] = quantidade * 2;
                    Console.WriteLine("Total: R$ " + String.Format("{0:0.00}", lanche[3]));
                    break;
                case 5:
                    lanche[4] = quantidade * 1.50;
                    Console.WriteLine("Total: R$ " + String.Format("{0:0.00}", lanche[4]));
                    break;
            }
        }
    }
}
