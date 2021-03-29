using System;
using System.Linq;


namespace URI
{
    class URI_1040
    {
        static void Main (string [] agrs)
        {

            double n1, n2, n3, n4, media, prova, mediap;
            string valores = Console.ReadLine();
            double[] valoresfloat = valores.Split(' ').Select(x => double.Parse(x)).ToArray();
            n1 = valoresfloat[0];
            n2 = valoresfloat[1];
            n3 = valoresfloat[2];
            n4 = valoresfloat[3];
            media = (((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0)) + (n4 * 1.0)) / 10.0;
            mediap = media * 10;
            if (media >= 7.0)
            {

                Console.WriteLine("Media: {0:F1}", mediap / 10);
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5 && media <= 6.9)
            {

                Console.WriteLine("Media: {0:F1}", Math.Floor((Math.Round(mediap, 1))) / 10);
                Console.WriteLine("Aluno em exame.");
                prova = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0:F1}", prova);
                media = (media + prova) / 2;
                mediap = (double)Math.Floor(media * 10);
                if (media >= 5.0)
                {

                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: {0:F1}", Math.Floor((Math.Round(mediap, 1))) / 10);

                }
                else
                {

                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: {0:F1}", media);

                }

            }
            else if (media < 5.0)
            {

                Console.WriteLine("Media: {0:F1}", Math.Floor((Math.Round(mediap, 1))) / 10);
                Console.WriteLine("Aluno reprovado.");
            }


        }
    }
}
