using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Page
    {
        int Index { get; set; }//序号
        string url { get; set; }//网址
        string status { get; set; }//下载状态

        public Page(int Id,string newurl,string newstatus)
        {
            Index = Id;
            url = newurl;
            status = newstatus;
        }
    }
}
