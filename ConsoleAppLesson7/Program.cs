using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону 1 треугольника 1 : ");
            double x1_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 2 треугольника 1 : ");
            double x1_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 3 треугольника 1 : ");
            double x1_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 1 треугольника 2 : ");
            double x2_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 2 треугольника 2 : ");
            double x2_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону 3 треугольника 2 : ");
            double x2_3 = Convert.ToDouble(Console.ReadLine());
            if (_triangle_S(x1_1, x1_2, x1_3) > _triangle_S(x2_1, x2_2, x2_3))
            {
                Console.WriteLine(" Большей площадью обладает первый треугольник со сторонами :  {0}  {1}  {2}", x1_1, x1_2, x1_3);
            }
            else
            {
                if (_triangle_S(x1_1, x1_2, x1_3) < _triangle_S(x2_1, x2_2, x2_3))
                {
                    Console.WriteLine(" Большей площадью обладает второй треугольник со сторонами :  {0}  {1}  {2}", x2_1, x2_2, x2_3);
                }
                else Console.WriteLine(" Площади треугольников равны");
            }
            Console.ReadKey();

        }
        static double _triangle_S (double a, double b, double c)
        {
            double _halfPer = (a + b + c) / 2;
            // Console.WriteLine(_halfPer);
            return Math.Sqrt(_halfPer * (_halfPer - a) * (_halfPer - b) * (_halfPer - c)); 
        }
    }
}
