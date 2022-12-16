
using System;
using ShakeSort1;

namespace Std
{
    class Program
    {
        
        static void ShakeSort(int[] array )
        {
            int left = 0; int right = array.Length-1;   
            while(left < right)
            {
                for(int i = left; i<right; i++)
                {
                    if (array[i] > array[i+1])
                        (array[i],array[i+1]) = (array[i+1],array[i]);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (array[i-1] > array[i])
                        (array[i-1], array[i]) = (array[i ], array[i-1]);
                }
                left++;
            }
        }
        static void Main(string[] args)
        {
            int[] ar = { 9, 8, 5, 7, 6, 3, 2, 1, 5 };
            ShakeSort shakeSort = new ShakeSort();
            shakeSort.Sort(ar);
            Console.WriteLine(String.Join(" ", ar));
        }
    }
}