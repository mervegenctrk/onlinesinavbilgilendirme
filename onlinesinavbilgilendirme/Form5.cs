using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;

namespace onlinesinavbilgilendirme
{
    public partial class Form5 : Form
    {
        public string html;
        public Uri url;
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 1; x <= 2; x++)
            {
                verial("https://duzce.edu.tr/akademik/fakulte/mf/bm/duyurular", "/html/body/main/section[2]/div/div/div[2]/div[1]/div["+x+"]/a", listBox1);

            }
            /*for (int i=1; i<=6;i++)
            {
                verial("https://duzce.edu.tr/akademik/fakulte/mf/bm/duyurular", "/html/body/div[1]/div[2]/div/div[2]/div/div/ul/li["+i+"]/a", listBox1);

            }*/
          

        }
        public void verial(string Url,string XPath, ListBox Cikansonuc)
        {
            try
            {
                url = new Uri(Url);

            }
            catch(UriFormatException)
            {
                if (MessageBox.Show("Hatalı URL", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            catch(ArgumentNullException)
            {
                if (MessageBox.Show("Geçersiz URL", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch(WebException)
            {
                if (MessageBox.Show("Hatalı URL", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                Cikansonuc.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText.Trim());
            }
            catch(NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
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
    }
}
