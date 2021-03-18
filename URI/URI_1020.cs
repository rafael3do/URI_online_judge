using System;

namespace URI
{
    class URI_1020
    {
        static void Main (string [] args)
        {
            int valor, ano, mes, dias;
            valor = Convert.ToInt32(Console.ReadLine());
            ano = valor / 365;
            valor = valor - (ano * 365);
            mes = valor / 30;
            valor = valor - (mes * 30);
            dias = valor;
            Console.WriteLine(ano + " ano(s)\n" + mes + " mes(es)\n" + dias + " dia(s)");
        }
    }
}
