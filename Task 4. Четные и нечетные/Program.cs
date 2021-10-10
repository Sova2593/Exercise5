using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Четные_и_нечетные
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i < 21; i+=2)
            {
                    if ((array[i] > 0) && (array[i] % 2 !=0))
                    {
                    sum++;
                    }
            }
            Console.Write("Количество нечетных положительных элементов равно {0} ", sum);
            Console.ReadKey();
        }
    }
}
