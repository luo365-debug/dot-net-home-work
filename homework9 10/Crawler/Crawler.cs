using System;
using System.Collections;//Hashtable
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;


namespace Crawler
{
    public class SimpleCrawler//Program
    {
        //起始网址
        public string startUrl { get; set; }
        //已下载网页
        public Hashtable DownLoadurls = new Hashtable();
        //待下载网页，需筛选
        Queue<string> WaitToDownLoad = new Queue<string>();

        //URL解析表达式
        public readonly string Parseurl = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public int MaxPage { get; set; }
        public Encoding HtmlEncoding { get; set; }
        public SimpleCrawler()//构造函数
        {
            MaxPage=50;//最大下载页数
            HtmlEncoding=Encoding.UTF8;//网页编码
        }

        public event Action<SimpleCrawler, string, string> CreatPage; 
        public void Start()//开始操作,按下按钮后开始string startUrl
        {
            DownLoadurls.Clear();//清空之前的已下载网页集
            WaitToDownLoad.Clear();//清空待下载网页
            WaitToDownLoad.Enqueue(startUrl);//把起始网页地址放入待下载网页队列队尾
            while (DownLoadurls.Count < MaxPage && WaitToDownLoad.Count > 0)
            {
                string url = WaitToDownLoad.Dequeue();//取队首元素
                try
                {
                    string html = DownLoad(url);
                    DownLoadurls[url] = true;//key为url,指定与键关联的值
                    CreatPage(this, url, "success");
                    Parse(html, url);//解析并加入新链接
                }
                catch(Exception ex)
                {
                    CreatPage(this, url, "Error:" + ex.Message);
                }

            };
        }

        public string DownLoad(string url)//获取网址内容
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = DownLoadurls.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public string DetectHost { get; set; }
        public string DetectFile { get; set; }
        public void Parse(string html, string url)//解析网址内容，即用正则表达式得到其中的超级链接href
        {
            //string Detecturl = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";//URL检测表达式
            string Detecturl = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
            MatchCollection matches = new Regex(Detecturl).Matches(html);

            foreach(Match match in matches)
            {
                string linkurl = match.Groups["url"].Value;
                if (linkurl == null || linkurl == "" || linkurl.StartsWith("javascript:")) continue;

                linkurl = Complete(linkurl, url);//转绝对路径

                //string Parseurl = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
                Match linkurlMatch = Regex.Match(linkurl, Parseurl);

                string host = linkurlMatch.Groups["host"].Value;
                string file = linkurlMatch.Groups["file"].Value;

                if(Regex.IsMatch(host,DetectHost)
                    &&Regex.IsMatch(file,DetectFile)
                    &&!DownLoadurls.ContainsKey(linkurl))//还未下载
                { 
                    WaitToDownLoad.Enqueue(linkurl);//符合条件加入待下载队列
                }
            }
        }

        private string Complete(string linkurl,string url)//转绝对路径
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(url, Parseurl);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(url, Parseurl);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = url.LastIndexOf('/');
                return Complete(url, url.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return Complete(url.Substring(2), url);
            }
            //非上述开头的相对路径
            int end = url.LastIndexOf("/");
            return url.Substring(0, end) + "/" + url;
        }
    }

    
}
