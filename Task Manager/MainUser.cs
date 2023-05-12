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
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void DrawTab(object sender, EventArgs e)
        {
            tabPage1 = new TabPage();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.Red;  
        }
    }
}
