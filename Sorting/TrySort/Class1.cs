using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakeSort1
{
    public class ShakeSort
    {
        public void Sort(int[] arr)
        {
            int left = 0; int right = arr.Length - 1;
            while(left < right)
            {
                for(int i = left; i< right; i++)
                {
                    if (arr[i] > arr[i + 1])
                        (arr[i], arr[i+1]) = (arr[i+1], arr[i]);
                }
                right--;
                for(int i = right; i > left; i--)
                {
                    if (arr[i-1]>arr[i])
                    {
                        (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    }
                }
                left++;
            }
        }
    }
}
