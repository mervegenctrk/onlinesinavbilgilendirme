using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace onlinesinavbilgilendirme
{
    
    public partial class Form4 : Form
    {
        
        SqlConnection connection = Form1.connection;
        //static Random random = new Random();
        //int rand_code = random.Next(10000, 99999);

        
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmddekle = new SqlCommand("Insert into duyurusinav (sinavadi,sinavsaati,sinavsüresi,sinavtarih,sonbasvuru) Values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+dateTimePicker1.Value+"','"+dateTimePicker3.Value+"')",connection);
            SqlDataReader reader = cmddekle.ExecuteReader();
            connection.Close();
            reader.Close();
            MessageBox.Show("Sınav Duyurusu başarılı bir şekilde eklenmiştir.","Duyuru");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Delete from duyurusinav where sinavadi=@sinavadi",connection);
            komut.Parameters.AddWithValue("@sinavadi", textBox4.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sınav Başarılı bir şekilde silinmiştir.");
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void sendmail()
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage();

            client.Credentials = new NetworkCredential("merve_akinci13@hotmail.com", "mervem2525");
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;

            message.To.Add("mail1");
            message.From = new MailAddress("merve_akinci13@hotmail.com", "Sinav Bilgilendirme Sistemi");
            message.Subject = "Sinav Bilgilendirme";
            message.Body = "Yeni Sınav bilgisi eklenmiştir.";
            client.Send(message);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
