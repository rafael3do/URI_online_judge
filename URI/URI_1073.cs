using System;

namespace URI
{
    class URI_1073
    {
        static void Main (string [] args)
        {
            int ciclos = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[ciclos];
            for (int i = 0; i < ciclos; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] < 0 && numeros[i] % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (numeros[i] > 0 && numeros[i] % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (numeros[i] > 0 && numeros[i] % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (numeros[i] < 0 && numeros[i] % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (numeros[i] == 0)
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
