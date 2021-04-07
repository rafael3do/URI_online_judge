using System;
using System.Linq;

namespace URI
{
    class URI_1047
    {
        static void Main( string[] args)
        {
            int horaini, minutoini, horafim, minutofim, duracaohora, duracaomin;
            string valores = Console.ReadLine();
            int[] valoresint = valores.Split(' ').Select(x => int.Parse(x)).ToArray();
            horaini = valoresint[0];
            minutoini = valoresint[1];
            horafim = valoresint[2];
            minutofim = valoresint[3];
            if (horaini == minutofim && horafim == minutofim && minutofim == minutoini)
            {
                duracaomin = minutoini - minutofim;
                duracaohora = 24 + horaini - horafim;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");

            }
            else if (horaini == horafim && minutofim > minutoini)
            {
                duracaomin = minutofim - minutoini;
                duracaohora = horaini - horafim;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");
            }
            else if (horaini == horafim && minutoini > minutofim)
            {
                duracaomin = 60 - minutoini + minutofim;
                duracaohora = 24 - horaini + horafim - 1;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");
            }
            else if (minutoini == minutofim && horaini < horafim)
            {
                duracaomin = 0;
                duracaohora = horafim - horaini;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");
            }
            else if (minutoini == minutofim && horaini > horafim)
            {
                duracaomin = 0;
                duracaohora = 24 - horaini + horafim;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");
            }
            else if (horafim > horaini && minutofim > minutoini)
            {
                duracaomin = minutofim - minutoini;
                duracaohora = horafim - horaini;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");
            }
            else if (horaini < horafim && minutoini > minutofim)
            {
                duracaomin = 60 - minutoini + minutofim;
                duracaohora = horafim - horaini - 1;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");

            }
            else if (horaini > horafim && minutoini < minutofim)
            {
                duracaomin = minutofim - minutoini;
                duracaohora = 24 - horaini - 1 + horafim;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");
            }
            else if (horaini > horafim && minutoini > minutofim)
            {
                duracaomin = 60 + minutofim - minutoini;
                duracaohora = 24 + horafim - horaini - 1;
                Console.WriteLine("O JOGO DUROU " + duracaohora + " HORA(S) E " + duracaomin + " MINUTO(S)");

            }
        }
    }
}
