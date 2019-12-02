using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_1
{
    class Program
    {
        static void PowerA3(double A, out double B)
        {
            B = A * A * A;
        }
        static void Main(string[] args)
        {
            double b;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                PowerA3(a, out b);
                Console.WriteLine("Ответ: {0}", b);
            }
        }
    }
}
