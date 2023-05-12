using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point point;
        private void MouseDown_Click(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void MouseMove_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
