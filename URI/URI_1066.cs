using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1066
    {
        static void Main (string [] args)
        {
            int X, even = 0, odd = 0, positive = 0, negative = 0;
           
            for (int i = 1; i <= 5; i++)
            {
                X = Int32.Parse(Console.ReadLine());
                if (X % 2 == 0)
                {
                    even += 1;
                }
                if (X % 2 != 0)
                {
                    odd += 1;
                }
                if (X > 0)
                {
                    positive += 1;
                }
                if (X < 0)
                {
                    negative += 1;
                }

            }
            Console.WriteLine(even + " valor(es) par(es)");
            Console.WriteLine(odd + " valor(es) impar(es)");
            Console.WriteLine(positive + " valor(es) positivo(s)");
            Console.WriteLine(negative + " valor(es) negativo(s)");
            
        
    }
    }
}
