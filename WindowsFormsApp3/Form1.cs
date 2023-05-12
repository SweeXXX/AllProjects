using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.KeyPreview = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            int x = SystemInformation.PrimaryMonitorSize.Width;
            int y = SystemInformation.PrimaryMonitorSize.Height;
            Random random = new Random();
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Cursor.Position = new Point(random.Next(0, x),random.Next(0, y));
            }
        }

        internal void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.E&&e.Alt) 
            {
                button2_Click(sender, e);
            }
            if (e.KeyCode == Keys.K)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
