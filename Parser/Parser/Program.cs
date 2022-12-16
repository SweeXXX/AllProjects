using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Pars
{
    class Program
    {
        static void P1()
        {
            WebClient n1 = new WebClient();
            String Response = n1.DownloadString("https://www.cbr.ru/scripts/XML_daily_eng.asp");
            var  r = Regex.Match(Response, @"<Name>US Dollar</Name><Value>([0-9]+.[0-9]+)</Value>").Groups[1].Value;
            Console.WriteLine(r);
        }
        static void P2(string silka)
        {
            System.Net.WebClient k5 = new System.Net.WebClient();
            String Response = k5.DownloadString(silka);
            var r = System.Text.RegularExpressions.Regex.Match(Response, @"<title>(\w+ \w+)").Groups[1].Value;
            Console.WriteLine(r);
        }
        static void P3()
        {
            System.Net.WebClient k1 = new System.Net.WebClient();
            String Response = k1.DownloadString("https://vk.com/vitaly.shpak");
            var r = Regex.Match(Response, @"online").Groups[0].Value;
            Console.WriteLine(r);    
        }
        static void P4()
        {
            string line = "мор, мир, март, марка";
            Regex regex = new Regex(@"м.р\S*");
            MatchCollection col = regex.Matches(line);
            Console.WriteLine(string.Join(" ", col)+ "  " + col.Count);
        }
        static void Main(string[] agrs)
        {
            P2("https://vk.com/zxcvbasdfqwe");
        }
    }
}