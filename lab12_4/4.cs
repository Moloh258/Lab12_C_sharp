using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_4
{
    class Program
    {
        static bool Quarter(int x, int y, out int q)
        {
            q = 0;
            if (x > 0 && y > 0) q = 1;
            if (x < 0 && y > 0) q = 2;
            if (x < 0 && y < 0) q = 3;
            if (x > 0 && y < 0) q = 4;
            return q != 0;
            //if (q == 0)
            //{
            //    throw new Exception("Не на четверти");
            //}
        }
        static void Main(string[] args)
        {
            int r = 1;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Введите координату x");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату y");
                int y = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (Quarter(x, y, out r))
                        Console.WriteLine("{0}ая четверть",r);
                    else
                        Console.WriteLine("Не на четверти");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
