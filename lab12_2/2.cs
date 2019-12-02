using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_2
{
    class Program
    {
        static int Sign(double x)
        {
            if (x > 0) return 1;
            if (x < 0) return -1;
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два вещественных числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            a = Sign(a) + Sign(b);
            Console.WriteLine("Ответ: {0}", a);
        }
    }
}
