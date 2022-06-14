using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Formlar.kamiltrn
{
    class mail
    {
        public mail(string senderMail, string senderPassword)
        {
            this.senderMail = senderMail;
            this.senderPassword = senderPassword;
        }
        private string senderMail;
        private string senderPassword;

        public MailMessage RecipientAddList(List<string> recipientList, MailMessage mail)
        {
            foreach (var item in recipientList)
            {
                mail.To.Add(item);
            }
            return mail;
        }
        public MailMessage RecipientAdd(string recipientList, MailMessage mail)
        {
            mail.To.Add(recipientList);
            return mail;
        }
        public MailMessage SubjectAdd(string subject, MailMessage mail)
        {
            mail.Subject = subject;
            return mail;
        }
        public MailMessage BodyAdd(string body, MailMessage mail)
        {
            mail.Body = body;
            return mail;
        }
        public MailMessage AttachmentAdd(Attachment atach, MailMessage mail)
        {
            mail.Attachments.Add(atach);
            return mail;
        }

        public void sendMail(MailMessage mail)
        {
            mail.From = new MailAddress(senderMail);
            SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
            smtp.Credentials = new NetworkCredential(senderMail, senderPassword);
            smtp.EnableSsl = true;
            smtp.SendAsync(mail, (object)mail);
        }

    
    }
}
