using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1010
    {
        static void Main(string [] args)
        {

            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();
            double total;

            string[] valores = linha1.Split(' ');
            int codPeca1 = int.Parse(valores[0]);
            int numPecas1 = int.Parse(valores[1]);
            double valorPeca1 = Convert.ToDouble(valores[2]);

            total = numPecas1 * valorPeca1;

            string[] valores2 = linha2.Split(' ');
            int codPeca2 = int.Parse(valores2[0]);
            int numPecas2 = int.Parse(valores2[1]);
            double valorPeca2 = Convert.ToDouble(valores2[2]);

            total += numPecas2 * valorPeca2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("0.00"));
        }
    }
}
