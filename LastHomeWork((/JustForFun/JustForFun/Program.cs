using System;

namespace Fun
{
    public class Arrr
    {
        List<int[]> list = new List<int[]>();
        public Arrr(List<int[]> list)
        {
            this.list = list;
        }
        public int[] this[int i]
        {
            get => list[i];
            set => list[i] = value; 
        }
    }
    public class ClS<T> 
    {
        T x, y;
        public ClS(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        ~ClS()
        {
            Console.WriteLine("Слс удалилься!");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            var ns = new ClS<int>(2,4);

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}