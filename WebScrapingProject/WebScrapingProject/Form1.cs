using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrapingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scrapebutton_Click(object sender, EventArgs e)
        {
            Program x = new Program();
            List<string> results = x.Scrape();
            foreach (string item in results)
            {
                //resultstextbox.AppendText(String.Format("{0} - {1}",item.Name,item.Price));
                resultstextbox.AppendText(item);
            }
        }
    }
}
