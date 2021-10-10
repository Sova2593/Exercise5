using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack6.Магический_квадрат
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            int sum_strings = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum_strings += t[i, j];
                }
            }
            int sum_columns = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum_columns += t[j, i];
                }
            }
            int sum_MainDiagonal = 0;
            for (int i = 0; i < n; i++)
                {
                    sum_MainDiagonal += t[i, i];
                }
            int sum_SecDiagonal = 0;
            for (int i = 0; i >0; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) == n - 1)
                    {
                        sum_SecDiagonal += t[i, j];
                    }
                }
            }
            Console.WriteLine();
            if (sum_strings == sum_columns && sum_strings == sum_MainDiagonal && sum_strings== sum_SecDiagonal)
            {
                Console.WriteLine("Введенный массив - магический квадрат");
            }
            else
            {
                Console.WriteLine("Введенный массив - не магический квадрат");
            }
            Console.ReadKey();
        }
    }
}
