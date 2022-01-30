using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double R, double Pi);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = GeomL;
            myDelegate += GeomS;
            myDelegate += GeomV;
            Console.WriteLine("Введите радиус");
            double R = Convert.ToDouble(Console.ReadLine());
            double Pi = Math.PI;
            myDelegate(R, Pi);
            Console.ReadLine();
        }
        static double GeomL(double R, double Pi)
        {
            double l = 2 * R * Math.PI;
            Console.WriteLine("Длина окружности");
            Console.WriteLine(l);
            return l;
        }
        static double GeomS(double R, double Pi)
        {
            double s = Math.PI* Math.Pow(R,2);
            Console.WriteLine("Площадь круга");
            Console.WriteLine(s);
            return s;
        }
        static double GeomV(double R, double Pi)
        {
            double v = 4/3 * Math.PI*Math.Pow(R,3);
            Console.WriteLine("Объем шара");
            Console.WriteLine(v);
            return v;
        }

    }
}
