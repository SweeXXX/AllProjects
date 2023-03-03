using System;
using System.Collections;

namespace Home
{
    class Program
    {
        public static void bubleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        (mas[i], mas[j]) = (mas[j], mas[i]);
                    }
                }
            }
        }
        public static void CoctailSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        (array[j - 1], array[j]) = (array[j], array[j - 1]);
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }
        }
        public static void SS(int[] arr)
        {
            //расстояние между элементами, которые сравниваются
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        (arr[j], arr[j - d]) = (arr[j - d], arr[j]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }
        public static void InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    j--;
                }

                array[j] = key;
            }
        }

        public static void ViborSort(int[] mas)
        {

            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
        }
        public static void Main(string[] args)
        {
            int[] mas = { 5555, 1222, 21432, 512, 332, 7342, 89, 123432, 543, 23 };
            ViborSort(mas);
            Console.WriteLine(String.Join(" ", mas));

        }
       



    }
}
