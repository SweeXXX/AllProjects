using System;

namespace HHR
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[,] matrix =
            {
                { 0,1,1,0},
                { 1,0,1,0},
                { 1,1,0,1},
                { 0,0,1,0},
            };
            //begin = matrix[0, 0];
            //end = matrix[3, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        Console.Write(i + "->" + j + " ");
                    }
                }
                Console.WriteLine();
            }
            int d1 = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        Console.Write(i + "->" + j + " ");
                        i = j;
                        d1++;
                    }
                }
            }
            Console.WriteLine(d1);
            int d2 = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 4; j++)
                {
                    if (matrix[i, j] != 0)
                    {

                        Console.Write(i + "->" + j + " ");
                        i = j;
                        d2++;
                    }
                }
            }
            Console.WriteLine(d2);

        }
    }
    
}
