using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using XML;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        readonly XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
        MyClass instance1 = new MyClass();
        MyClass instance2;
        private void SerializeButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                instance1.Items.Add("Element" + i);

            }
            using (var stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                serializer.Serialize(stream, instance1);
                this.Text = "Объект сериализован";
            }
        }
        private void DesializeButton_Click(Object sender, EventArgs e)
        {
            try
            {
                using (var stream = new FileStream("Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    instance2 = serializer.Deserialize(stream) as MyClass;
                    this.Text = "Объект десериализован";
                }
                richTextBox1.Text = "ID   :" + instance2.ID + Environment.NewLine+
                    "Size   :" + instance2.Size + Environment.NewLine+
                    "Position  :" + instance2.Position + Environment.NewLine +
                    "List    :" + Environment.NewLine;
                foreach (var item in instance2.Items)
                {
                    richTextBox1.Text += "\n" + item + Environment.NewLine;
                }
                richTextBox1.Text += "Password:" + instance2.Password;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
