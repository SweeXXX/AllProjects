using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLitePCL;
using System.Data.Sql;
using Microsoft.Data.Sqlite;

namespace Hostell
{
    public partial class MainForm : Form
    {
        private SqliteConnection BD;
        public MainForm()
        {
            InitializeComponent();
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new Size(textBox1.Width, richTextBox1.Height);
        }
        void MainForm_Load(object sender, EventArgs e)
        {
            //BD = new SqliteConnection("Data Sourse = Test.bd; Version = 3");
            //BD.Open();
        }
        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            lastPoint.X = e.X;
            lastPoint.Y = e.Y;
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X  - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
