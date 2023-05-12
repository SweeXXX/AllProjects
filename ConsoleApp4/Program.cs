//using MailKit.Net.Imap;
//using System.Net;
//using System.Net.Mail;

//class EmailSender
//{
//    public static void Main()
//    {
//        string from = "sweeexxxxxx@gmail.com";
//        string to = "nikitapoletaev44941@mail.ru";
//        string subject = "Test Email";
//        string body = "This is a test email message.";

//        MailMessage message = new MailMessage(from, to, subject, body);


//        ImapClient client = new ImapClient();
//        //SmtpClient client = new SmtpClient("smtp.gmail.com", 465);
//        //client.UseDefaultCredentials = false;
//        ////client.Credentials = new System.Net.NetworkCredential("Testingg", "gmailhueta!");
//        //client.Credentials = new NetworkCredential("sweeexxxxxx@gmail.com", "gmailhueta1");
//        //client.EnableSsl = true;

//        try
//        {
//            client.Send(message);
//            Console.WriteLine("Email sent successfully.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error sending email: " + ex.Message);
//        }
//    }
//}



//using System.Net.Mail;
//using System.Net;
//using System.Text;
//using MailKit;
//using MimeKit;

//class Program
//{
//    static void Main(string[] args)
//    {

//        using (var mess = new MailMessage())
//        {
//            var client = new SmtpClient("smtp.mail.ru", 587); // smtp сервер, номер порта ["smtp.mail.ru",25);]
//            client.Credentials = new NetworkCredential("nikitapoletaev44941@mail.ru", "M3e19PjEPpqv0u6xRAsP");
//            client.EnableSsl = true;
//            mess.From = new MailAddress("nikitapoletaev44941@mail.ru");
//            mess.To.Add(new MailAddress("ssSweeX@yandex.ru"));
//            mess.Subject = Environment.UserName;
//            mess.SubjectEncoding = Encoding.UTF8;
//            mess.Priority = MailPriority.High;
//            mess.IsBodyHtml = false;
//            mess.Body = "Ахуеть работает!!!";
//            try
//            {

//                client.Send(mess);
//            }
//            catch(Exception ex) 
//            { // тут лови исключения}
//                Console.WriteLine(ex.Message); // для отправки сообщения
//                                   // mess?.Dispose(); // освобождение ресурсов
//            }
//        }

//        

//    }
//}



using MailKit.Net.Smtp;
using MimeKit;

class Program
{
    static void Main(string[] args)
    {
        // Создание сообщения
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Отправитель", "nikitapoletaev44941@mail.ru"));
        message.To.Add(new MailboxAddress("Получатель", "ssSweeX@yandex.ru"));
        message.Subject = "Тема сообщения";
        message.Body = new TextPart("plain")
        {
            Text = "Текст сообщения"
        };

        // Подключение к SMTP-серверу и отправка сообщения
        using (var client = new SmtpClient())
        {
            client.Connect("smtp.mail.ru", 587, false);
            try
            {
                
                client.Authenticate("nikitapoletaev44941@mail.ru", "M3e19PjEPpqv0u6xRAsP");
                client.Send(message);
                client.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}