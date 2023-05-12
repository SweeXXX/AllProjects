using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int x = SystemInformation.PrimaryMonitorSize.Width;
            int y = SystemInformation.PrimaryMonitorSize.Height;
            Random rnd = new Random();
            int f1 = 0;
            int f2 = 10*10*10*10; 
            while(f1<=f2)
            {
                Cursor.Position = new Point(rnd.Next(0,x), rnd.Next(0,y));  
                System.Threading.Thread.Sleep(100);
                f1+=1;
            }
        }
    }
}
