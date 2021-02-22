using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int i;
            Console.WriteLine("Input 10 numbers:");
            for (i = 0; i < 10; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe numbers in the array are: ");
            PrintElements(Numbers);
            ShellSort(Numbers, Numbers.Length);
            Console.Write("\nArray Sorted Using Shell Sort: ");
            PrintElements(Numbers);
            Console.ReadKey();
        }
        public static void ShellSort(int[] Numbers, int array_size)  //using Shell Sort
        {
            int i, j, temp;
            int interval = 0;

            while (interval < (Numbers.Length / 3))
            {
                interval = interval * 3 + 1;

            }
            while (interval > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = Numbers[i];
                    while ((j >= interval) && (Numbers[j - interval] > temp))
                    {
                        Numbers[j] = Numbers[j - interval];
                        j = j - interval;
                    }
                    Numbers[j] = temp;
                }
                if (interval / 2 != 0)
                    interval = interval / 2;
                else if (interval == 1)
                    interval = 0;
                else
                    interval = 1;
            }
        }
        public static void PrintElements(int[] Numbers)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", Numbers[i]);
            }
        }

    }
}