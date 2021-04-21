using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1065
    {
        static void Main (string [] args)
        {
            float n1;
            int nos = 0;
            for (int i = 1; i <= 5; i++)
            {
                n1 = float.Parse(Console.ReadLine());
                if (n1 % 2 == 0)
                {
                    nos += 1;
                }
            }
            Console.WriteLine(nos + " valores pares");
        
    }
    }
}
