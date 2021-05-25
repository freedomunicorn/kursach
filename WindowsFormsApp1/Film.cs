using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace WindowsFormsApp1
{
    public static class Film
    {
        public static List<string> nameOfFilms = new List<string>();
        public static List<string> description = new List<string>();
        public static List<string> image = new List<string>();
        public static int a=0;
        private static List<string> NameOfFilms
        {
            get
            {
                return nameOfFilms;
            }
                set
            {
                nameOfFilms = value;             
            }
        }
        private static List<string> Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }

        }
        private static List<string> Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
        public static void GetHtml()
        {
            HtmlWeb ws = new HtmlWeb();
            ws.OverrideEncoding = Encoding.UTF8;
            HtmlDocument doc = ws.Load("https://grodno.in/afisha/kino/");
            ArrayList list = new ArrayList();
            int count = 0;
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//div[contains(@class,'safisha-info')]//a[@href]"))
            {
                count++;
                list.Add("https:" + node.GetAttributeValue("href", null));
                if (count == 10) break;
                 a=count;
            }
            foreach (string o in list)
            {
                doc = ws.Load(o);
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//div[@class='afi']//h1"))
                {
                    Film.nameOfFilms.Add(link.InnerText);
                }
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//div[@class='descr afi-descr afi-descr1']//p"))
                {
                    Film.description.Add(link.InnerText);
                }
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//div[contains(@class,'afi-img-wrap kino')]//img[@src]"))
                {
                    Film.image.Add("https:" + link.GetAttributeValue("src", null));
                }
            }

        }
    }
}
