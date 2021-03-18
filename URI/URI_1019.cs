using System;


namespace URI
{
    class URI_1019
    {
        static void Main (string [] args)
        {
            int N, hora, minuto, segundo;
            N = Convert.ToInt32(Console.ReadLine());
            hora = N / 3600;
            N = N - (hora * 3600);
            minuto = N / 60;
            N = N - (minuto * 60);
            segundo = N;
            Console.WriteLine(hora + ":" + minuto + ":" + segundo);            
        }
    }
}
