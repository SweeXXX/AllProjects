using System;


namespace Div3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int count = int.Parse(Console.ReadLine());
            int len = arr.Length;
            Array.Sort(arr);    


        }
    }
}
