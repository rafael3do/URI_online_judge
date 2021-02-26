using System;


namespace URI
{
    class URI_1008
    {
        static void Main (string [] args)
        {
            int emp = Convert.ToInt32(Console.ReadLine());
            int hour = Convert.ToInt32(Console.ReadLine());
            double value = double.Parse(Console.ReadLine());
            double salary = hour * value;
            Console.WriteLine("NUMBER = " + emp);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));

        }
    }
}
