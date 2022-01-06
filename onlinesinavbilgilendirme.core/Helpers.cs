using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Linq;
using onlinesinavbilgilendirme.core.Model;
using HtmlAgilityPack;
using onlinesinavbilgilendirme.core;
using Microsoft.EntityFrameworkCore;

namespace onlinesinavbilgilendirme
{

    public static class DataHelpers
    {
       static ContextDb contextDb = new ContextDb();
       static List<User> users = contextDb.Users.ToList();

        public static HtmlDocument GetHtmlData(string Url)
        {
            string[] result = new string[] { };
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(Url);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(page);
            return doc;
        }

        public static void DuyuruCekDuzce()
        {
            var duzceUrl = "https://duzce.edu.tr/akademik/fakulte/mf/bm/duyurular";

            List<DuzceDuyuru> duzceDuyuru = new List<DuzceDuyuru>();
            EmailSender emailSender = new EmailSender();
            bool duyuruDurum = false;

            foreach (HtmlNode table in GetHtmlData(duzceUrl).DocumentNode.SelectNodes("//*[@class=\"row\"]"))
            {
                foreach (HtmlNode row in table.SelectNodes("div"))
                {
                    if (row.SelectNodes("div/a") != null)
                    {
                        foreach (HtmlNode cell in row.SelectNodes("div/a"))
                        {
                            var duyuru = cell.InnerText.TrimStart().Replace("\r", "").Replace("\n", "").TrimEnd();


                            var duyurular = contextDb.DuzceDuyurular.ToList();

                            var checkExist = duyurular.FirstOrDefault(x => x.Description == duyuru);

                            if (checkExist != null)
                                continue;

                            contextDb.Add(new DuzceDuyuru()
                            {
                                Description = duyuru
                            });
                        }
                    }
                    else
                    {
                        foreach (HtmlNode row2 in row.SelectNodes("div"))
                        {
                            foreach (HtmlNode cell in row2.SelectNodes("div/a"))
                            {
                                var duyuru = cell.InnerText.TrimStart().Replace("\r", "").Replace("\n", "").TrimEnd();


                                var duyurular = contextDb.DuzceDuyurular.ToList();

                                var checkExist = duyurular.FirstOrDefault(x => x.Description == duyuru);

                                if (checkExist != null)
                                    continue;


                                duzceDuyuru.Add(new DuzceDuyuru()
                                {
                                    Description = duyuru
                                });
                                contextDb.Add(new DuzceDuyuru()
                                {
                                    Description = duyuru
                                });
                                duyuruDurum = true;                                
                            }
                        }
                    }


                }
                if (duyuruDurum == true)
                {
                    contextDb.SaveChanges();

                    string body = "";
                    int count = 0;
                    foreach (var item in duzceDuyuru)
                    {
                        count++;
                        body += count.ToString() + "- " + item.Description + "<br>";
                    }

                    foreach (var user in users)
                    {
                        if (user.MailDurum == true)
                        {
                            emailSender.SendEmail(new Email()
                            {
                                Body = body,
                                Subject = "Düzce Üniversitesi Yeni Duyuru",
                                UserEmail = user.Email
                            });
                        }
                    }

                }
            }

        }

        public static void DuyuruCekAnadolu()
        {
            var anadoluUrl = "https://www.anadolu.edu.tr/acikogretim/aof-duyurular";

            List<AnadoluDuyuru> anadoluDuyuru = new List<AnadoluDuyuru>();
            EmailSender emailSender = new EmailSender();
            bool duyuruDurum = false;


            foreach (HtmlNode table in GetHtmlData(anadoluUrl).DocumentNode.SelectNodes("//*[@class=\"list\"]"))
            {
                foreach (HtmlNode row in table.SelectNodes("ul"))
                {
                    foreach (HtmlNode cell in row.SelectNodes("li"))
                    {
                        var duyuru = cell.InnerText.TrimStart().Replace("\r", "").Replace("\n", "").TrimEnd();


                        var duyurular = contextDb.AnadoluDuyurular.ToList();

                        var checkExist = duyurular.FirstOrDefault(x => x.Description == duyuru);

                        if (checkExist != null)
                            continue;


                        anadoluDuyuru.Add(new AnadoluDuyuru()
                        {
                            Description = duyuru
                        });
                        contextDb.Add(new AnadoluDuyuru()
                        {
                            Description = duyuru
                        });
                        duyuruDurum = true;                  
                    }

                }
                if (duyuruDurum == true)
                {
                    contextDb.SaveChanges();

                    string body = "";
                    int count = 0;
                    foreach (var item in anadoluDuyuru)
                    {
                        count++;
                        body += count.ToString() + "- " + item.Description + "<br>";
                    }

                    foreach (var user in users)
                    {
                        if (user.MailDurum == true)
                        {
                            emailSender.SendEmail(new Email()
                            {
                                Body = body,
                                Subject = "Anadolu Üniversitesi Yeni Duyuru",
                                UserEmail = user.Email
                            });
                        }
                    }

                }
            }

        }
        public static void DuyuruCekOsym()
        {
            List<OsymDuyuru> osymDuyuru = new List<OsymDuyuru>();
            EmailSender emailSender = new EmailSender();
            bool duyuruDurum = false;

            var osymUrl = "https://www.osym.gov.tr/TR,20810/2021.html";

            foreach (HtmlNode table in GetHtmlData(osymUrl).DocumentNode.SelectNodes("//*[@id=\"list\"]"))
            {
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        var duyuru = cell.InnerText.TrimStart().Replace("\r", "").Replace("\n", "").TrimEnd();


                        var duyurular = contextDb.OsymDuyurular.ToList();

                        var checkExist = duyurular.FirstOrDefault(x => x.Description == duyuru);

                        if (checkExist != null)
                            continue;

                        osymDuyuru.Add(new OsymDuyuru() 
                        { 
                            Description = duyuru
                        });
                        contextDb.Add(new OsymDuyuru()
                        {
                            Description = duyuru
                        });
                        duyuruDurum = true;
                    }

                }
                if(duyuruDurum == true)
                {
                    contextDb.SaveChanges();

                    string body = "";
                    int count = 0;
                    foreach (var item in osymDuyuru)
                    {
                        count++;
                        body += count.ToString() + "- " + item.Description  + "<br>";
                    }

                    foreach (var user in users)
                    {
                        if(user.MailDurum == true)
                        {
                            emailSender.SendEmail(new Email()
                            {
                                Body = body,
                                Subject = "Osym Yeni Duyuru",
                                UserEmail = user.Email
                            });
                        }
                    }
                    
                }
            }

        }

    }
}
