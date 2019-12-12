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


        public List<Knowledge> GetKnowledges()
        {
            string json;
            List<Knowledge> knowledges = new List<Knowledge>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GetKnowledgeLink);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using(StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }

            knowledges = JsonConvert.DeserializeObject<List<Knowledge>>(json);

            return knowledges;

        }
    }
}
