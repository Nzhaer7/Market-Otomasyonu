using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Formlar.kamiltrn
{
    public partial class Şifre_unuttum_sayfası : Form
    {
        public Şifre_unuttum_sayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rant = new Random();
            string a = rant.Next().ToString();
            string DogrulamaKodu = a;
            mail mail = new mail("testhesab01@hotmail.com", "2316410.a");
            MailMessage mailMessage = new MailMessage();
            mailMessage = mail.BodyAdd("Bu mail Market Otomasyon Şifrenizi Sıfırlamak İçin Gönderilmiştir\n" +
                "Eğer bu isteği siz yapmadıysanız herhangi bir işlem yapmanıza gerek yoktur\n\n" +
                "Doğrulama Kodunuz : " + DogrulamaKodu + "\n Doğrulama kodunu başkasıyla lütfen paylaşmayın", mailMessage);
            mailMessage = mail.SubjectAdd("Şifre Sıfırlama Doğrulama Kodunuz", mailMessage);
            try
            {
                mailMessage = mail.RecipientAdd(textBox1.Text, mailMessage);
                try
                {
                    mail.sendMail(mailMessage);
                    return;
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mail Adresi Geçersiz");
                return;
            }
        }
    }
}
