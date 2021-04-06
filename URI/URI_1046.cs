using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI
{
    class URI_1046
    {
        static void Main (string [] args)
        {
            int horaini, horafim, duracao;
            string valores = Console.ReadLine();
            int[] valoresint = valores.Split(' ').Select(x => int.Parse(x)).ToArray();
            horaini = valoresint[0];
            horafim = valoresint[1];
            duracao = horaini - horafim;
            if (horaini == horafim)
            {
                duracao = 24 - duracao;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else if (horaini <= horafim)
            {
                duracao = horafim - horaini;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else
            {
                duracao = 24 - duracao;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
        }
    }
}
