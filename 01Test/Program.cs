using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序 二维数组的声明 这种是锯齿数组
            //int[,] nums = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[] num = new int[] { 11, 2, 4, 5, 8, 1, 4 };
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    int temp = 0;
                    if (num[j] < num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            foreach (int item in num)
            {
                Console.Write(item+"  ");
            }
            Console.ReadKey();
        }
    }
}
