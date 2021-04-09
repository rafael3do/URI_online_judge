using System;

namespace URI
{
    class URI_1048
    {
        static void Main (string [] args)
        {
            double salario, novosalario, valorreajuste;
            int reajuste = 0;
            salario = double.Parse(Console.ReadLine());
            novosalario = 0;
            valorreajuste = 0;
            if (salario >= 0 && salario <= 400.00)
            {

                reajuste = 15;
                valorreajuste = salario * .15;
                novosalario = salario + valorreajuste;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = 12;
                valorreajuste = salario * .12;
                novosalario = salario + valorreajuste;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = 10;
                valorreajuste = salario * .10;
                novosalario = salario + valorreajuste;
            }
            else if (salario >= 1200.01 && salario <= 2000)
            {
                reajuste = 7;
                valorreajuste = (salario * .07);
                novosalario = salario + valorreajuste;
            }
            else if (salario > 2000)
            {
                reajuste = 4;
                valorreajuste = salario * .04;
                novosalario = salario + valorreajuste;
            }

            Console.WriteLine("Novo salario: {00:F2}", novosalario);
            Console.WriteLine("Reajuste ganho: {00:F2}", valorreajuste);
            Console.WriteLine("Em percentual: " + reajuste + " %");
        }
    }
}
