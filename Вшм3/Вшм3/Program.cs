using System;
using System.Diagnostics.CodeAnalysis;

namespace Div3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            static void zad1()
            {
                int num = int.Parse(Console.ReadLine());//abcde // adcbe
                                                        //int e = num % 10;
                int d = (num % 100) / 10;
                int b = (num / 1000) % 10;
                //int c = (num % 1000) / 100;
                //int a = (num  / 10000);
                //Console.WriteLine($"{a*10000+d*1000+c*100+b*10+e}");
                //Console.WriteLine($"{e},{d},{c},{b},{a}");
                num = num - b * 1000;
                num = num + d * 1000;
                num = num - d * 10;
                num = num + b * 10;
                Console.WriteLine(num);
            }
            static void zad2()
            {
                long num = long.Parse(Console.ReadLine());
                num /= 10;
                int count = 1;
                while(num!=0)
                {
                    num /= 10;
                    count++;
                }
                Console.WriteLine(count);
            }
            static void zad3()
            {
                //Задача 3. Дано число X, (1<=Х<=10^18) числа a и b .
                //Нужно поменять местами цифры номер a и b.
                //Гарантировано что они есть. Нумерация цифр с начала числа
                double num = 123456;
                int a = 5;
                int b = 1;
                num = num - a * (Math.Pow(10, (a - 1)));
                num = num - b * (Math.Pow(10, (b - 1)));
                Console.WriteLine(num);
            }
            static void zad4()
            {

                //Задача 4. У вас есть N рублей на счете в банке (1<=N<=10^10).
                //Вы хотите снять все деньги со счета.
                //В банкомате есть купюры достоинством 5000, 1000, 100, 50 и 10 руб.
                //банкомат выдает так, чтобы суммарное число купюр было минимально.
                //Определите число К - суммарное число купюр.
                long num = long.Parse(Console.ReadLine());
                long k5000 = num / 5000;
                num = num % 5000;
                long k1000 = num/ 1000;
                num = num % 1000;
                long k100 = num / 100;
                num = num % 100;
                long k50 = num / 50;
                num = num % 50;
                long k10 = num / 10;
                num = num % 10;
                long sum = k5000 + k1000 + k100 + k50 + k10;
                Console.WriteLine(sum);
                Console.WriteLine($"{k5000}\n{k1000}\n{k100}\n{k50}\n{k10}");
            }
            static void zad6()
            {
                int num = 29;
                int i = 2;
                while(i<Math.Pow(num,0.5))
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                    else
                        i++;
                }
                Console.WriteLine("YES");
            }
            zad6();
            
        }
    }
    
}
