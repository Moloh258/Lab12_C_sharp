using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_3
{
    class Program
    {
        static double RingS(double r1, double r2)
        {
            return (3.14 * (r1 * r1 - r2 * r2));
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Введите внешний и внутренний радиусы кольца");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Искомая площадь равна: {0}", RingS(a, b));
            }
        }
    }
}
