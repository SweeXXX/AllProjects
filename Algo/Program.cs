using System;
// Ввод:
// Ценности предметов (загруженные в массив v)
// Веса предметов (загруженные в массив w)
// Количество предметов (n)
// Грузоподъемность (W)

//for j from 0 to W do:
//    m[0, j] := 0

//for i from 1 to n do:
//    for j from 0 to W do:
//        if w[i] > j then:
//    m[i, j] := m[i - 1, j]
//        else:
//            m[i, j] := max(m[i - 1, j], m[i - 1, j - w[i]] + v[i])

public class MainClass
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int MW = int.Parse(s[0]);
        int n = int.Parse(s[1]);
        int tweigth = 0;
        s = Console.ReadLine().Split();
        int[] mas = new int[n];
        for (int i = 0; i < n; i++)
        {
            mas[i] = int.Parse(s[i]);
        }
        Array.Sort(mas);
        Array.Reverse(mas);

        for (int i = 0; i < n; i++)
        {
            if (MW > tweigth + mas[i])
            {
                tweigth += mas[i];
            }
            else
                break;
        }
        Console.WriteLine(tweigth);
    }
}
