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
    public partial class AddGuest : Form
    {
        public AddGuest()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public string TBNAME
        {
            get
            {
                return this.tbName.Text;
            }
            set
            {
                this.tbName.Text = value;
            }
        }
        public  string[] Settings()
        {
            string[] result = {$"{this.TBNAME}", $"{tbSName.Text}" , $"{tbTName.Text }", $"{tbDateIN.Text }", $"{tbDateOUT.Text}" };
            return result;
        }
        private void AddClick(object sender, EventArgs e)
        {
            TBNAME = tbName.Text;

        }
    }
}
