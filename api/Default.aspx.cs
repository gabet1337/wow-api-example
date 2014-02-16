using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lol
{
    public partial class _Default : System.Web.UI.Page
    {

        private GuildNews gn;

        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Running");
            Collector col = new Collector();
            gn = col.CollectGuildNews("Lords of the Locker Room"); 
            this.content.InnerHtml = gn.name + "<br />";
            this.content.InnerHtml += GetNews();
        }

        private string GetNews()
        {
            String result = "";
            foreach (News news in gn.news) 
            {
                if (news.type.Equals("guildAchievement"))
                {
                    DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(news.timestamp / 1000d)).ToLocalTime();
                    result += (dt.ToString() + " " + news.achievement.title + "<br />");
                }
            }
            return result;
        }
    }
}