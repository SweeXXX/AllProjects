using System;

namespace Std
{
    class Program
    {
        static int FMin(int[] array, int start)
        {
            int min = int.MaxValue;
            for(int i = start; i < array.Length; i++)
            {
                if(array[i] < min)
                    min = i;
            }
            return min;
        }
        static void Vibor(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                (arr[FMin(arr, i)], arr[i]) = (arr[i], arr[FMin(arr, i)]); 
            }
        }
        static void Main(string[] args)
        {

            int[] ar = { 9, 8, 5, 7, 6, 3, 2, 1, 5 };
            Vibor(ar);
            Console.WriteLine(String.Join(" ", ar));
        }
    }
}