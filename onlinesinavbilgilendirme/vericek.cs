using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using HtmlAgilityPack;
using System.Net.Mail;

namespace onlinesinavbilgilendirme
{
    public partial class vericek : Form
    {
        SqlConnection connection = Form1.connection;
        public string html;
        public Uri url;
        public vericek()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = DataHelpers.duyurularCek();
            for (int i = 1; i <= items.Count; i++)
            {
                listBox1.Items.Add(items[i]);
            }
        }

        public void vericekilen(string Url, string XPath, ListBox cekilenveri)
        {
            try
            {
                url = new Uri(Url);
                var veri = DataHelpers.duyuruCek(Url, XPath);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* try
             {
                 //SqlCommand komut = new SqlCommand();

                 for (int i = 0; i < listBox1.Items.Count; i++)
                 {
                     //connection.Open();
                     SqlCommand cmd = new SqlCommand("insert into duyurular(duyuru) values (@duyuru)", connection);
                     cmd.Parameters.AddWithValue("@duyuru", listBox1.Items[i].ToString().Trim());
                     //cmd.ExecuteNonQuery();
                 }

                 MessageBox.Show("Veriler eklendi.");

             }
             catch (Exception hata)
             {

                 MessageBox.Show(hata.Message);
             }
             finally
             {
                 connection.Close();
             }
             //connection.Close();*/
            
                SqlCommand komut = new SqlCommand("Select *from onlusername where active='true'");
                SmtpClient client = new SmtpClient();
                MailMessage msg = new MailMessage();

                client.Credentials = new NetworkCredential("merve_akinci13@hotmail.com","mervem2525");
                client.Port = 587;
                client.Host="smtp.live.com";
                client.EnableSsl = true;

                msg.To.Add("mervemakinci@gmail.com");
                msg.From = new MailAddress("merve_akinci13@hotmail.com","Sınav duyuru Bilgilendirme");
                msg.Subject = "Sınav duyuru Bilgilendirme";
                msg.Body = "<html>"+
                "<body>" + "<p>Anadolu üniversitesi açıköğretim duyuruları eklenmiştir.</p>"+
                "<p><a href=https://www.anadolu.edu.tr/acikogretim/aof-duyurular >Duyuruları görüntülemek için tıklayınız !</p>" 
                +"</body>"+
                "</html>";
                 msg.IsBodyHtml = true;
                client.Send(msg);
            MessageBox.Show("Kullanıcılara duyuru emaili gönderildi! ");
            
        }
    }
}
