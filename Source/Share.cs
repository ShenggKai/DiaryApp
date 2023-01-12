using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace DiaryApp.Source
{
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
        }

        private void pGmail_Click(object sender, EventArgs e)
        {
            string text = DiaryItem.instance.Text;
            string toEmail = "maimemdada@gmail.com"; // The email address of the recipient
            string subject = "Chia sẻ nhật ký"; // The subject of the email
            string body = text; // The body of the email, which is the text from the TextBox

            MailMessage mail = new MailMessage("diaryappdev@gmail.com", toEmail);
            mail.To.Add(toEmail);
            mail.Subject = subject;
            mail.Body = DiaryItem.instance.Content;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("diaryappdev@gmail.com", "joqphfdgznfsfkdl");

            smtp.Send(mail);

            MessageBox.Show("Đã chia sẻ", "DiaryApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
