using System;


namespace Std
{
    class Program
    {
        static int partition(int[] arr, int start, int end )
        {
            int marker = start;
            for(int i = start; i <= end; i++)
            {
                if (arr[end]>=arr[i])
                {
                    (arr[marker], arr[i]) = (arr[i], arr[marker]);
                    marker++;
                }
            }
            return marker - 1;
        }
        static void quicksort(int[] arr, int start, int end)
        {
            if (start >= end)
                return;
            int pivot = partition(arr, start, end);
            quicksort(arr, pivot+1, end);
            quicksort(arr, start, pivot-1);
        }
       
        static void Main(string[] args)
        {
            int[] ar = { 9, 8, 5, 7, 6, 3, 2, 1, 5 };
            quicksort(ar, 0, ar.Length-1);
            
            Console.WriteLine(String.Join(" ", ar));
        }
    }
}