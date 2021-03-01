using System;


namespace URI
{
    class URI_1009
    {

        static void Main (string [] args)
        {
            string name = Console.ReadLine();
            double salary = Convert.ToDouble(Console.ReadLine());
            double sales = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TOTAL = R$ " + ((sales * 0.15) + salary).ToString("F2"));

        }
    }
}
