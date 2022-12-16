using System;

namespace Home
{
    class Boris
    {
        static int id = 0;
        static string previd = "B";
        static public string GetFullId { get { return $"{previd}{id}"; } }
        static public string GetName { get { return "Boris"; } }
        
    }
    class Rashid
    {
        static int id = 1;
        static string previd = "R";
        static public string GetFullId { get { return $"{previd}{id}"; } }
        static public string GetName { get { return "Rashid"; } }
        public Rashid(string s) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            string b = "Home.Boris";
            string[] s1 = Console.ReadLine().Split();
            var r1 = 
        }
    }
}