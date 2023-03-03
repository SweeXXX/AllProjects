using System;

namespace Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Sun s = Sun.CreateSun(5,5);
            Planet planet = new Planet(100500);
            Console.WriteLine(planet<s);
        }
    }
    class Sun
    {
        static private int? singl = null;
        public double kg;
        double size;//kol-vo km
        //
        private Sun()
        {
            
        }
        private Sun(double kg, double size)
        {
            this.kg = kg;
            this.size = size;
        }

        static public bool operator <(Sun s1, Sun s2)
            { return s1.kg < s2.kg; }
        static public bool operator >(Sun s1, Sun s2)
            { return s1.kg > s2.kg; }
        static public Sun? CreateSun(double kg=5, double size=5)
        {
            if(singl == null)
            {
                singl = 0;
                return new Sun(kg,size);
            }
            Exception e = new Exception("В этой галактике Солнце уже имеется!!");
            throw e;
        }
    }
    class Planet
    {
        double kg;
        public Planet(double kg)
        {
            this.kg = kg;
        }

        public static  bool operator <(Planet p, Sun s)
        {
            if (p.kg < s.kg)
                return true;
            return false;
        }
        public static bool operator >(Planet p, Sun s)
        {
            if (p.kg > s.kg)
                return true;
            return false;
        }

    }
    class Stella
    {

    }
}