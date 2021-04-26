using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1070
    {
        static void Main (string [] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            int controle = 0;

            for (int i = numero; controle < 6; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    controle++;
                }


            }
        }
    }
}
