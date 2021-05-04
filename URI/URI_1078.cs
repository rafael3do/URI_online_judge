using System;

namespace URI
{
    class URI_1078
    {
        static void Main (string [] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + numero + " = " + i * numero);
            }
        }
    }
}
