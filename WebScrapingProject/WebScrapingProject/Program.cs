using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;
namespace WebScrapingProject
{
    public class searchitem
    {
        public string Name
        {
            get;
            set;
        }

        public string Price
        {
            get;
            set;
        }
    }

    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public List<string> Scrape()
        {
            ScrapingBrowser driver = new ScrapingBrowser();
            driver.AllowAutoRedirect = true;
            driver.AllowMetaRedirect = true;
            WebPage searchpage = driver.NavigateToPage(new Uri("https://www.amazon.ca/s/ref=a9_asi_1?rh=i%3Aaps%2Ck%3Ablack+seed+oil&keywords=black+seed+oil&ie=UTF8&qid=1465755388"));
            //HtmlNode searchbar = searchpage.Html.CssSelect("#twotabsearchtextbox").First();

            //PageWebForm searchbar = searchpage.FindForm()

            //List<searchitem> results = new List<searchitem>();
            List<string> results = new List<string>();
            HtmlNodeCollection Table = (HtmlNodeCollection)searchpage.Html.CssSelect("li.a-fixed-left-grid");
            searchitem item = new searchitem();
            foreach (HtmlNode product in Table)
            {
                //item.Name = product.SelectNodes("a-link-normal.s-access-detail-page.a-text-normal").First().InnerText;
                //item.Price = product.SelectNodes("a-size-medium.a-color-price").First().InnerText;
                //results.Add(item);
                results.Add(product.InnerText);
            }
            
            return results;
        }
    }
}