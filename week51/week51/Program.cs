using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;

namespace week51
{
    class Program
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            Program myc = new Program();
            string starturl = @"http://www.cnblogs.com";
            myc.urls.Add(starturl, false);
            string data = myc.Download(starturl);
            myc.Parse(data, starturl);
            myc.Crawl();
            Console.ReadKey();
            return;
        }
        private void Crawl()//爬取
        {
            Console.WriteLine("开始爬取了");
            while (true)
            {
                string currentUrl = null;
                foreach(string url in urls.Keys)
                {
                    if ((bool)urls[url])//已经下载过的直接跳过
                    {
                        continue;
                    }
                    else
                    {
                        currentUrl = url;
                    }
                }
                if (currentUrl == null || count > 10)
                    break;
                Console.WriteLine("正在爬取{0}页面", currentUrl);
                string html = Download(currentUrl);
                Parse(html, currentUrl);
                urls[currentUrl]=true;//页面下载完成
                count++;
            }
        }
        private string Download(string url){
            try{
            Console.WriteLine("下载了 {0} 页面",url);
            WebClient wc  = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string data  = wc.DownloadString(url);
            return data;
            }catch(Exception e){
                Console.WriteLine(e);
                return "";
            }
        }
        private void Parse(string html,string baseUrl){
            Console.WriteLine("开始对{0} 的链接进行解析", baseUrl);
            string regexHref = @"(href|HREF)=[""'](?<href>((\S*(.php|.html|.jsp|.aspx|.htm))|(./|../|/)[^/]\S*)|/\S$)[""']";
            MatchCollection hrefs = new Regex(regexHref).Matches(html);
            int count = hrefs.Count;
            foreach(Match matchHref in hrefs)
            {
                string rawUrl = matchHref.Result("${href}");
                Console.WriteLine(rawUrl);
                if (rawUrl.Length >= 3 && rawUrl.Substring(0, 3) == "../")
                {
                    rawUrl = baseUrl +"/"+ rawUrl.Substring(3);
                }
                else if (rawUrl[0] == '/' || (rawUrl.Length > 2 && rawUrl.Substring(0, 2) == "./" || rawUrl.Substring(0, 2) == "//"))
                {
                    int index = rawUrl.IndexOf('/');
                    rawUrl = baseUrl +"/"+ rawUrl.Substring(index + 1);
                }
                if (rawUrl[rawUrl.Length - 1] == '/')
                {
                    rawUrl = rawUrl.Remove(rawUrl.Length-1, 1);
                }
                if (urls[rawUrl]==null)
                {
                    urls.Add(rawUrl, false);
                    Console.WriteLine(rawUrl);
                }
            }
            
        }
    }
}
