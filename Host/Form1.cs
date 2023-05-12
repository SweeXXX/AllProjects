using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Host
{
    public partial class MainForm : Form
    {
        GuestForm guestForm = new GuestForm();
        AddGuest  addGuest = new AddGuest();
        //Это я пытался данные из GuestForm получить
        //и не только это.
        //(неудачно)
        //не получается ваимодействовать с ListView
        //из другой формы.
        //вся визуальная часть работает.
        //почти весь бэк, который взаимодействует с ListView
        //не работает. Вот как-то так :( 
        //в ReadMe написал что, где, как использовать////////////////////////////
        public MainForm()
        {
            InitializeComponent();
            this.splitContainer2.SplitterDistance = 200;
            Size size = new Size(1193, 600);
            this.Size = size;
            Size size1 = new Size(174, 66);
            this.LeftPanel.Size = size1;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void dataGridViewSort_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numLine = e.RowIndex;
            ////this.lblNumberID.Text = $"ID {dataGridViewSort.Rows[numLine].Cells[0].Value.ToString()}";
            string name = dataGridViewSort.Rows[numLine].Cells[1].Value.ToString();
            string surname = dataGridViewSort.Rows[numLine].Cells[2].Value.ToString();
            string middlename = dataGridViewSort.Rows[numLine].Cells[3].Value.ToString();
            //this.labelSNM.Text = $"{surname} {name} {middlename}";
            //this.labelStatusRiaght.Text = dataGridViewSort.Rows[numLine].Cells[4].Value.ToString();
            //this.lblDateEnter.Text = dataGridViewSort.Rows[numLine].Cells[7].Value.ToString();
            ////this.lblDateExit.Text = dataGridViewSort.Rows[numLine].Cells[8].Value.ToString();
            string way = dataGridViewSort.Rows[numLine].Cells[10].Value.ToString();
            //MessageBox.Show(way);
            //pictureBoxRight.Load(way);
        }

        private void ShowAddForm(object sender, EventArgs e)
        {
            if(tlpAddDeleteCancel.Visible==true)
            {
                tlpAddDeleteCancel.Visible=false;
            }
            else
            {
                tlpAddDeleteCancel.Visible=true;
            }
            if (tableLayoutPanel1.Visible)
                tableLayoutPanel1.Visible = false;
            else
                tableLayoutPanel1.Visible = true;

        }
        private int SpDis = 300;
        private void ShowGuest_DClick(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Enabled = true;
            this.splitContainer2.SplitterDistance = SpDis;
            splitContainer2.Panel2.Show();
            //this.splitContainer2.IsSplitterFixed = false;




        }

        private void ShowInfoForm_Click(object sender, EventArgs e)
        {
            GuestForm form = new GuestForm();
            form.lblFIO = this.lblFIO;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDateEnter.Text = DateTime.Now.ToString();
            lblDateExit.Text = (DateTime.Now.Add(DateTime.Now.TimeOfDay)).ToString();
        }

        private void AddGuest(object sender, EventArgs e)
        {
            addGuest.Show();
        }
        public void NAdd(object sender, EventArgs e)
        {
            
            string[] strings = addGuest.Settings();
            ListViewItem listViewItem = new ListViewItem(strings);
            listView1.Items.Add(listViewItem);
        }
        private void btnCancelTLP_Click(object sender, EventArgs e)
        {
            tlpAddDeleteCancel.Visible = false;
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string[] strings = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            ListViewItem listViewItem = new ListViewItem(strings);
            listView1.Items.Add(listViewItem);
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ShowGuest_DClick(sender,e);
            lblFIO.Text = listView1.FocusedItem.SubItems[0].Text + " " +
                listView1.FocusedItem.SubItems[1].Text + " " +
                listView1.FocusedItem.SubItems[2].Text;
            lblDateEnter.Text = listView1.FocusedItem.SubItems[3].Text;
            lblDateExit.Text = listView1.FocusedItem.SubItems[4].Text;
            
        }

        private void CloseGuestPanel(object sender, MouseEventArgs e)
        {
            SpDis = splitContainer2.SplitterDistance;
            splitContainer2.Panel2.Enabled = false;
            this.splitContainer2.SplitterDistance = 10000;
            splitContainer2.Panel2.Hide();
            //this.splitContainer2.IsSplitterFixed = true;
        }

        private void splitContainer2_MouseClick(object sender, MouseEventArgs e)
        {
            SpDis = this.splitContainer2.SplitterDistance;
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
            catch { }

        }
    }
}
