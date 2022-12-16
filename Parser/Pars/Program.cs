using System;
using System.IO;
using System.Runtime.InteropServices;

namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(day:12, MM:1);
            Date data1 = new Date(12, 13, 59);
            Date dd5 = new Date(data1);
            Console.WriteLine(dd5.year);
        }
    }
    class Date
    {
        public readonly int year;
        public int day;
        public int month;
        public  int MM;
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public Date() : this(13, 14, 15) { }

        //public Date() : this(1970, 1, 58) { }

        public Date(int MM, int day)
        {
            this.MM = MM;
            this.day = day;
        }
        public Date(int year, int day, int month, int mM) : this(year, day, month)
        {
            MM = mM;
        }
        public Date(Date obj) : this(obj.year, obj.month, obj.day) { }
    }

}