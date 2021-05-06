using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1080
    {
        static void Main (string[] args)
        {
            int maior = 0, posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (maior > num)
                {
                    maior = maior;
                    posicao = posicao;
                }
                else
                {
                    posicao = i;
                    maior = num;
                }

            }
           Console.Write(maior + "\n" + posicao + "\n");
           
        }
    
    }
}
