using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRA;

namespace week5
{
    public partial class Form1 : Form
    {
        CRA.CRA myc;
        public Form1()
        {
            InitializeComponent();
            myc = new CRA.CRA();
            this.CrawlbindingSource.DataSource = myc.crawList;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("开始爬取");
            string starturl = this.textBox1.Text;
            myc.urls.Add(starturl, false);
            string data = myc.Download(starturl);
            myc.Parse(data, starturl);
            Task[] tasks =
            {
                Task.Run(()=>myc.Crawl()),
                Task.Run(()=>myc.Crawl())
            };
            Task.WaitAll(tasks);
            CrawlbindingSource.ResetBindings(false);
            return;
        }
    }
}
