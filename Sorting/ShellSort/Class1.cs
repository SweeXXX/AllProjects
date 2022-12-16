using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Std
{
    public class ShellSort
    {
        public void Sort(int[] arr)
        {
            int d = arr.Length / 2;
            while(d>=1)
            {
                for(int i = d; i < arr.Length; i++)
                {
                    int j = i;
                    while((j-d)>=0 && (arr[j-d] > arr[j]))
                    {
                        (arr[j - d], arr[j]) = (arr[j], arr[j-d]);
                        j-=d;
                    }
                }
                d /= 2;
            }
        }
    }
}
