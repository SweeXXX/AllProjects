using System;

namespace Std
{
    class Program
    {

        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }

        static void ShellSort(int[] array)
        {
            //расстояние между элементами, которые сравниваются
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
        static void Main(string[] args)
        {
            ShellSort s = new ShellSort();  
            int[] ar = { 9, 8, 5, 7, 6, 3, 2, 1, 5 };
            s.Sort(ar);
            Console.WriteLine(String.Join(" ", ar));
        }
    }
}