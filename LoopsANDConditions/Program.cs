using System;

namespace LoopsANDConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            try
            {
                x = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                y = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int sum = 0;
            for (; x <= y; x++)
                sum += x;
            Console.WriteLine(sum);
        }
    }
}

