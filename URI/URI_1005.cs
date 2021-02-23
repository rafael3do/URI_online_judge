using System;


namespace URI
{
    class URI_1005
    {
        static void Main (string [] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("MEDIA = "+ (((a*3.5)+(b*7.5))/11).ToString("F5") );

            
        }
    }
}
