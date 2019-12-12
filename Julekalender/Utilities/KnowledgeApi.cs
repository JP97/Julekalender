using Julekalender.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Julekalender.Utilities
{
    public class KnowledgeApi
    {
        private string GetKnowledgeLink = "https://localhost:44374/api/Knowledges";
        private string StationærLinkAPi = "https://localhost:44357/api/tipps";


        public List<Tipp> GetKnowledges()
        {
            string json;
            List<Tipp> knowledges = new List<Tipp>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(StationærLinkAPi);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using(StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }

            knowledges = JsonConvert.DeserializeObject<List<Tipp>>(json);

            return knowledges;

        }
    }
}
