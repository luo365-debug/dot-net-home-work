using System;
using Crawler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Crawler
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler = new SimpleCrawler();
        BindingSource Pages = new BindingSource();
        Thread thread = null;

        public Form1()
        {
            InitializeComponent();
            textBox.Text = "http://www.cnblogs.com/dstang2000/";

            //dataGridView1.DataSource = bds_Pages;
            dataGridView1.DataSource = Pages;
            crawler.CreatPage += Crawler_CreatPage;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Pages.Clear();
            crawler.startUrl = textBox.Text;

            Match match = Regex.Match(crawler.startUrl, crawler.Parseurl);
            if (match.Length == 0) return;

            string host = match.Groups["host"].Value;//主机过滤
            crawler.DetectHost = "^" + host + "$";

            crawler.DetectFile = "((.html?|.aspx|.jsp|.php)$|^[^.]+$";//文件过滤

            if (thread != null)
            {
                thread.Abort();
            }
            new Thread(crawler.Start).Start();//多线程
        }

        private void Crawler_CreatPage(SimpleCrawler crawler, string url, string status)
        {
            //Page newPage = new Page(Pages.Count + 1,url,status );//序号 网页地址 状态
            var newPage = new{ Index=Pages.Count + 1, url=url, status=status };
            Action action = () => { Pages.Add(newPage); };//绑定的数据源加入新网页
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
