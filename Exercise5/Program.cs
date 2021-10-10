using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            double sum = 0;
            Console.WriteLine("Введите элементы массива: ");
            for (int i=0; i<7; i++)
            {
                array [i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое элементов массива равно {0:f2}", sum/10);
            Console.ReadKey();
        }
    }
}
