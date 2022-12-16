using System;
using System.Linq;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Collections;

namespace Home
{
    
    class Program
    {
        static void Main()
        {
            double[] dd = { 1.2, 23.5, 12, 123, 12 };
            double[] kk = { 1, 2, 3, 4 };
            //K2(dd, kk);
            int[] ar = {1,2, 3, 4 };
            static void FirstDouble(int[] array)
            {
                int[] mas = {69,69,69 };
                int i = 0;
                //double each elements value
                foreach (int x in mas)
                {
                    array[i] = x ;
                    i++;
                }

                //create new object and assign its reference to array
                array = new int[] { 11, 12, 13 };
            }
            Console.WriteLine();
            FirstDouble(ar);    
            Console.WriteLine(string.Join(" ", ar));

            static void K2(double[] d, double[] k)
            {
                //d[0]++;
                Console.WriteLine(String.Join(" ", d));
                d = k;
                d[0]++;
                k[1]++;
                Console.WriteLine(string.Join(" ", d));
                Console.WriteLine(string.Join(" ", k));

            }
            //Console.WriteLine();
            //Console.WriteLine(string.Join(" ", dd));
            //Console.WriteLine(string.Join(" ", kk));


            //static void K3(ref string str, out string str2)
            //{
            //    str += "O!";
            //    str2 = str+"МАЙНКРАФТ ЭТО МОЯ ЖИЗНЬ!";
            //}
            //string s = "asfa";
            //string s2 = null;
            //Console.WriteLine();
            //Console.WriteLine(s);
            //Console.WriteLine(s2);
            //K3(ref s,  out s2);
            //Console.WriteLine(s);
            //Console.WriteLine(s2);


        }


    }
    
}
