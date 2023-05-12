using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TypoGraph
{
    public partial class TypoGraph : Form
    {
        public TypoGraph()
        {
            InitializeComponent();
        }
        public static string ReplaceAWithItalicA(string input)
        {
            char italicA = '\u1D2C'; // код курсивной буквы "а" в таблице символов Unicode
            StringBuilder output = new StringBuilder(input);
            int count = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == 'A')
                {
                    count++;
                    if (count % 2 == 0) // заменяем каждую вторую букву "A" на курсивную
                    {
                        output[i] = italicA;
                    }
                }
            }
            return output.ToString();
        }
        public static string ReplaceTsia(string input)
        {
            StringBuilder output = new StringBuilder(input);
            int index = 0;
            while (index < output.Length - 2)
            {
                if (output[index] == 'т' && output[index + 1] == 'с' && output[index + 2] == 'я')
                {
                    output.Insert(index + 1, 'ь'); // вставляем "ь"
                    index += 3; // переходим к следующей тройке символов
                }
                else
                {
                    index++; // переходим к следующему символу
                }
            }
            return output.ToString();
        }

        private void ClearRtb_Click(object sender, EventArgs e)
        {
            rtbEnter.Text = string.Empty;
        }
        public static string ReplaceEllipsis(string input)
        {
            string pattern = @"\.{3}"; // паттерн для поиска количества точек
            string replacement = "…"; // символ для замены
            return Regex.Replace(input, pattern, replacement);
        }
        public static string DeleteSlash(string input)
        {
            return input.Replace("//", "");
        }
        public static string AddNonBreakingSpaceAfterDash(string input)
        {
            //string pattern = @"(\S) - (\S)"; // паттерн для поиска тире между словами
            //string replacement = "$1\u2011$2"; // заменяем тире на слово + непереносимый пробел + слово
            //return Regex.Replace(input, pattern, replacement);
            // заменяем дефисы на тире с непереносимым пробелом
            return input.Replace(" - ", "\u00A0— ").Replace('-', '—');
        }
        public static string Try(string input)
        {
            string pattern = @"\s+"; // паттерн для поиска одного или более пробелов
            string replacement = " "; // заменяем пробелы на один пробел
            return Regex.Replace(input, pattern, replacement); 
        }
        public static string ReplaceAmpersand(string input)
        {
            return Regex.Replace(input, "(?<!&amp;)&(?!amp;)", "&amp;");
        }
        public static string ReplaceSecondQuotes(string text)
        {
            string pattern = @"«([^«»]|(?<=\s))+" + @"(""([^«»""]*)""|«([^«»])*»)*" + @"([^«»]|(?=\s))+»";
            var regex = Regex.Replace(text, pattern, m =>
            {
                string result = m.Value;
                Regex reg = new Regex("\"");
                result = reg.Replace(result, "„", 1);
                result = reg.Replace(result, "“", 1);
                return result;
            });

            return regex;
        }
        public static string ReplaceFirstQuotes(string input)
        {
            int k = input.Count(x => x == '"');

            if (k < 2 || k == 0 || k%2!=0)
            {
                return input;
            }

            StringBuilder sb = new StringBuilder(input);

            int firstQuoteIndex = input.IndexOf('"');
            int lastQuoteIndex = input.LastIndexOf('"');

            if (firstQuoteIndex < lastQuoteIndex)
            {
                int leftIndex = input.IndexOf('«');
                int rightIndex = input.IndexOf('»', leftIndex + 1);

                if (leftIndex < firstQuoteIndex && rightIndex > lastQuoteIndex)
                {
                    return input;
                }
                else
                {
                    sb[firstQuoteIndex] = '«';
                    sb[lastQuoteIndex] = '»';
                    return sb.ToString();
                }
            }
            else
            {
                return input;
            }
        }


        private void TypoGraph_Click(object sender, EventArgs e)
        {
            rtbEnter.Text = Try(rtbEnter.Text);
            rtbEnter.Text = ReplaceFirstQuotes(rtbEnter.Text);
            rtbEnter.Text = ReplaceSecondQuotes(rtbEnter.Text);
            rtbEnter.Text = ReplaceAmpersand(rtbEnter.Text);
            rtbEnter.Text = ReplaceEllipsis(rtbEnter.Text);
            rtbEnter.Text = AddNonBreakingSpaceAfterDash(rtbEnter.Text);
            rtbEnter.Text = ReplaceTsia(rtbEnter.Text);
            rtbEnter.Text = DeleteSlash(rtbEnter.Text);
            rtbEnter.Text = ReplaceAWithItalicA(rtbEnter.Text);
        }
    }
}
