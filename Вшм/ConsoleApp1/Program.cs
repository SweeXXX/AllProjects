using System;

namespace KL
{
    class Program
    {
        static void Main(string[] args)
        {
            long A = long.Parse(Console.ReadLine());
            long x = 0;
            long k = A;
            long m = (k + x) / 2;
            
            while (x <= k)
            {
                x = m;

                if (x * x <= A && (x + 1) * (x + 1) > A)
                {
                    Console.WriteLine(x);
                    break;
                }
                else if (x * x < A && (x + 1) * (x + 1) <= A)
                    m++;
                else if(x * x  > A)
                {
                    if ((x - 1) * (x - 1) <= A)
                    {
                        Console.WriteLine(x-1);
                        break;
                    }
                    else
                        m--;

                }
                    
                
            }

        }
    }
}
