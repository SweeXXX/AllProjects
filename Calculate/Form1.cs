using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Text.Equals("0"))
            { label1.Text = "1"; }
            else
            {
                label1.Text += "1" ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            string[] str = label1.Text.Split('-', '*', '+', '/');
            long ll = 0;    
            for(int i = 0; i < str.Length;i++)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Equals("0"))
            { label1.Text = "0"; }
            else
            {
                label1.Text += "*";
            }
        }
    }
}
