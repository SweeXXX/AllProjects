using System;
using System.Collections.Generic;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        int c = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for(int i = 0; i < str.Length; i++)
        {
            if(dic.ContainsKey(str[i]))
            {
               
                dic[str[i]]++;
                
            }
            else
            {
                dic.Add(str[i], 1);
            }
        }
        return dic;
    }
    static void Main(string[] args)
    {

        Console.WriteLine($"{Count("aab").Keys}{Count("aab").Values}");
    }
}