using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите r:\t");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate length = Length;
            if (length!=null)
            {
                double l = length(r);
                Console.WriteLine(l);
            }
            MyDelegate area = Area;
            if (length != null)
            {
                double s = area(r);
                Console.WriteLine(s);
            }
            MyDelegate vol = Vol;
            if (length != null)
            {
                double v = vol(r);
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
        static double Length(double r)
        {
            Console.Write("Длина окружности с укзанным радиусом =\t");
            return 2 * Math.PI * r;
        }
        static double Area(double r)
        {
            Console.Write("Площадь круга с укзанным радиусом =\t");
            return Math.PI * Math.Pow(r, 2);
        }
        static double Vol(double r)
        {
            Console.Write("Объем шара с укзанным радиусом =\t");
            return 4 / 3 * Math.PI * Math.Pow(r, 3);
        }
    }
}
