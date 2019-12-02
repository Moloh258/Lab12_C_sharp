using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_5
{
    class Program
    {
        static void Fact2(double n, out double y)
        {
            y = 1;
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0) y *= i; 
                }
            }
            if (n % 2 == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1) y *= i;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Fact2(x, out x);
            Console.WriteLine("Ответ: {0}", x);
        }
    }
}
