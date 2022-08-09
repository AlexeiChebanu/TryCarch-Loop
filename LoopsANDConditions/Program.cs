using System;

namespace LoopsANDConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            try
            {
                x = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            try
            {
                y = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            int sum = 0;
            for (; x <= y; x++)
                sum += x;
            Console.WriteLine(sum);
        }
    }
}
//checked
