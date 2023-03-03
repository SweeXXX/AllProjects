using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            int.TryParse(lblNN.Text, out var nn);
            if (nn <= 0)
                lblNN.Text = "00";
            else
                lblNN.Text = (nn-1).ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int.TryParse(lblNN.Text, out var nn);
            lblNN.Text = (nn + 1).ToString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point point;
        private void MouseDown_Click(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }
        private void MouseMove_Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.lblFIO.Text = form.lblFIO.Text; 
        }
    }
}
