using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //RefreshProcesses();
        }
        static int num;
        Process[] processes = Process.GetProcesses();
        private void RefreshProcesses()
        {
            ListViewItem item = new ListViewItem(processes[num].ProcessName);
            item.SubItems.Add(processes[num].Id.ToString());
            item.SubItems.Add(processes[num].PrivateMemorySize64.ToString());
            item.SubItems.Add(processes[num].StartTime.ToString());
            listView1.Items.Add(item);
            num++;
        }

        private void EndProcess()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                Process.GetProcessById(id).Kill();
                RefreshProcesses();
            }
        }

        private void buttonEndTask_Click(object sender, EventArgs e)
        {
            EndProcess();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                EndProcess();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }
    }
}