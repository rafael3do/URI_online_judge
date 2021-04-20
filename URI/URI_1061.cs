using System;

namespace URI
{
    class URI_1061
    {
        static void Main(string[] args)
        {

            Console.Write("Dia ");
            int diaI = int.Parse(Console.ReadLine());

            // vetor string dados ínicio da festa
            string line = Console.ReadLine();
            string[] tempoI = line.Split(':');
            int horaI = int.Parse(tempoI[0]);
            int minI = int.Parse(tempoI[1]);
            int segI = int.Parse(tempoI[2]);

            Console.Write("Dia ");
            int diaF = int.Parse(Console.ReadLine());

            // vetor string dados encerramento da festa
            string line2 = Console.ReadLine();
            string[] tempoF = line2.Split(':');
            int horaF = int.Parse(tempoF[0]);
            int minF = int.Parse(tempoF[1]);
            int segF = int.Parse(tempoF[2]);

            int diaT = 0, horaT = 0, minT = 0, segT = 0;

            //lógica para verificar tempo
            {
                //segundos
                if (segI > segF)
                    segT = (60 - segI) + segF;
                else if (segI == segF)
                    segT = 0;
                else
                    segT = segF - segI;

                //minutos
                if (minI > minF)
                    minT = (60 - minI) + minF;
                else if (minI == minF)
                    minT = 0;
                else
                    minT = minF - minI;

                //hora
                if (horaI > horaF)
                {
                    horaT = (24 - horaI) + horaF;
                    diaT = (diaF - diaI) - 1;
                }
                else if (horaI == horaF)
                {
                    horaT = 0;
                    diaT = (diaF - diaI) + 1;
                }
                else
                {
                    horaT = horaF - horaI;
                    diaT = (diaF - diaI);
                }

            }

            
            Console.WriteLine("{0} dia(s)", diaT);
            Console.WriteLine("{0} hora(s)", horaT);
            Console.WriteLine("{0} minuto(s)", minT);
            Console.WriteLine("{0} segundo(s)", segT);

            
        }
    }
}
