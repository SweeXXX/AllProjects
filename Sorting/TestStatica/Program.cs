using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.Print("abcd");
            Console.WriteLine(Test.t);
        }
    }
    class Test
    {
        public static int t;
        public static int v;
        static Test()
        {
            t = 52;
        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}