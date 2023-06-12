using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June7Homework.Data
{
    public static class LITScraper
    {
        public static List<MonthComponent> GetSchedule()
        {
            var html = GetHtml();
            return ParseHtml(html);
        }
        public static string GetHtml()
        {
            var client = new HttpClient();
            var html = client.GetStringAsync("https://lakewoodprogramming.com/#section-curriculum").Result;
            return html;
        }
        public static List<MonthComponent> ParseHtml(string html)
        {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(html);

            var trs = document.QuerySelectorAll("tr");
            var list = new List<MonthComponent>();
            foreach(var tr in trs)
            {
                var month = new MonthComponent();
                list.Add(month);
                var title = tr.QuerySelector("[style*='vertical-align:middle']");
                if(title != null)
                {
                    month.MonthTitle = title.TextContent;
                }

                var ul = tr.QuerySelector("ul");
                if(ul != null)
                {
                    var topics = ul.QuerySelectorAll("li");
                    if (topics != null)
                    {
                        month.Topics = topics.Select(t => t.TextContent).ToList();
                    }
                }
                
            }
            return list;
        }
    }
     
}
