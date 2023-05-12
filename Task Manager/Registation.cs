using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Registation : Form
    {
        public Registation()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point point;
        private void MouseDown_Click(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);     

        }

        public void MouseMove_Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("nikitapoletaev44941@mail.ru", "Tom");
                // кому отправляем
                MailAddress to = new MailAddress("napoletaev@kpfu.ru");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // текст письма
                m.Body = "134235";
                // тема письма
                m.Subject = "Тест";
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.mail.com";
                smtp.Port = 993;
                // логин и пароль
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential(from.Address, "TErhwMu7Y3adFg3qBCTp");
                smtp.Send(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Console.Read();
        }
    }
}
