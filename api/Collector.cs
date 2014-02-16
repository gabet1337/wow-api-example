using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
namespace lol
{
    public class Collector
    {

        public GuildNews CollectGuildNews(string guildName)
        {
            string requestString = "http://eu.battle.net/api/wow/guild/Ragnaros/" + guildName + "?fields=news";
            try
            {
                HttpWebRequest request = WebRequest.Create(requestString) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    }
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(GuildNews));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    GuildNews jsonResponse = objResponse as GuildNews;
                    return jsonResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}