using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Linq;

namespace onlinesinavbilgilendirme
{
    public static class DataHelpers
    {
        public static string duyuruCek(string Url, string XPath)
        {
            if (string.IsNullOrEmpty(Url))
                throw new InvalidOperationException("Url is invalid");

            Uri url = new Uri(Url);
            WebClient client = new WebClient();
            string html = "";
            client.Encoding = Encoding.UTF8;
            html = client.DownloadString(url);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            return doc.DocumentNode.SelectSingleNode(XPath).InnerText;
        }
        public static List<string> duyurularCek()
        {
            var list = new List<string>();
            for (int i = 1; i <= 29; i++)
            {
                var veri = duyuruCek("https://www.anadolu.edu.tr/acikogretim/aof-duyurular", "//*[@id='page']/div/div[3]/div[2]/aside[1]/aside/section/div/ul/li[" + i + "]");
                list.Add(veri.Trim());
            }
            return list;
        }

        public static List<string> duyurucekdzce()
        {
            var list1 = new List<string>();
            for (int y = 1; y <= 2; y++)
            {
                var veri = duyuruCek("https://duzce.edu.tr/akademik/fakulte/mf/bm/duyurular", "/html/body/main/section[2]/div/div/div[2]/div[1]/div[" + y + "]/a");

                list1.Add(veri.Trim());
            }
            return list1;
        }
        public static List<string> duyurucekdzce1()
        {
            var list2 = new List<string>();
            for (int x = 1; x <= 2; x++)
            {
                var veri = duyuruCek("https://duzce.edu.tr/akademik/fakulte/mf/bm/duyurular", "/html/body/main/section[2]/div/div/div[2]/div[2]/div[" + x + "]/div[2]/a");
                list2.Add(veri.Trim());
            }
            return list2;
        }



        public static void duyurulariKaydet()
        {
            //var connection = "";
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O7FCNJ8; Initial Catalog=onlinesinav; Integrated Security=TRUE ");

            var ca = new SqlDataAdapter("Select * from duyurular", connection);
            DataTable tablo = new DataTable();
            ca.Fill(tablo);

            var tableResult = tablo.AsEnumerable().Select(r => r.Field<string>("duyuru"));
            var icerdekiDuyurular = new List<string>();
            foreach(var item in tableResult)
            {
                icerdekiDuyurular.Add(item.ToString());
            }

            var list = duyurularCek();
            foreach (var item in list)
            {
                if (!icerdekiDuyurular.Any(z => z.Trim().ToUpper() == item.Trim().ToUpper()))//does not exist
                {
                    var ca2 = new SqlCommand($"INSERT INTO duyurular (duyuru) VALUES ('{item}')", connection);
                    connection.Open();
                    ca2.ExecuteReader();


                    // foreach of all onluusernames email adresleri
                //    foreach (var item in collection)
                //    {
                //        mailsend("mailcontent", customeremail);
                //    }
                }
            }

        }
      //public static  bool mailsend(string emailcontent,string toemail)
      //  {
      //      bool issend = false;

      //      SmtpClient client = new SmtpClient();
      //      MailMessage msg = new MailMessage();

      //      client.Credentials = new NetworkCredential("merve_akinci13@hotmail.com", "mervem2525");
      //      client.Port = 587;
      //      client.Host = "smtp.live.com";
      //      client.EnableSsl = true;

      //      msg.To.Add(toemail);
      //      msg.From = new MailAddress("merve_akinci13@hotmail.com", "Sınav duyuru Bilgilendirme");
      //      msg.Subject = "Sınav duyuru Bilgilendirme";
      //      msg.Body = "<html>" +
      //      "<body>" + "<p>Anadolu üniversitesi açıköğretim duyuruları eklenmiştir.</p>" +
      //      "<p><a href=https://www.anadolu.edu.tr/acikogretim/aof-duyurular >Duyuruları görüntülemek için tıklayınız !</p>"
      //      + "</body>" +
      //      "</html>";
      //      msg.IsBodyHtml = true;
      //      client.Send(msg);




      //      return issend;



      //  }

    }
}
