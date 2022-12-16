using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04_11_22
{
    public class Boris { }
    class Rashid : Boris { } //finance director
    class Lukas : Rashid { }
    class Buh : Lukas { }
    class OIlham : Boris { } // automatisation director
    class Orcadiy : OIlham { }
    class Volodya : Orcadiy { }
    class Ilshat : Volodya { } // system
    class Ivanich : Ilshat { }
    class Ilya : Ivanich { }
    class Vitya : Ivanich { }
    class Jeka : Ivanich { }
    class Sergey : Volodya { }// development
    class Lyasan : Sergey { }
    class Marat : Lyasan { }
    class Dina : Lyasan { }
    class Ildar : Lyasan { }
    class Anton : Lyasan { }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кто хочет дать задачу?/Кому хоят дать задачу?/Что за задача? (Введите через пробел)");
            string[] arr = Console.ReadLine().Split();

            Type who_give = Type.GetType("HW" + "." + arr[0], false, true);
            Type who_get = Type.GetType("HW" + "." + arr[1], false, true);
            Console.WriteLine($"От человека {arr[0]} дана задача {arr[2]}  для {arr[1]}.");

            Console.WriteLine("Ответ:");
            if (who_get.IsSubclassOf(who_give)) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}