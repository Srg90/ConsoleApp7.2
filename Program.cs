using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте значение длины ребра куба");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Длина ребра куба = {0}", a);
            double V;
            double S;
            cube(a, out V, out S);
            Console.WriteLine();
            Console.WriteLine("Объем куба составляет = {0}", V);
            Console.WriteLine("Площадь куба составляет = {0}", S);
            Console.WriteLine();
          
         


            Console.ReadKey();
        }
        static void cube(double a, out double V, out double S)
        {

            V = Math.Round(Math.Pow(a, 3), 2);
            S = Math.Round(6 * (Math.Pow(a, 2)), 2);

        }

       
    }
    
}
