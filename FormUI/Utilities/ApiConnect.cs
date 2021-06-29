using Entities.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.Utilities
{
    public class ApiConnect
    {
        public static readonly string BaseUrl = "https://localhost:44318/api/";

        public static async Task<string> GetCustomer()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BaseUrl + $"Customers/Type3?filter=*"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data!=null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }


        public static async Task<string> UserLogin(string UserCode, string UserPass)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BaseUrl + $"Users/Login?Usercode={UserCode}&UserPass={UserPass}"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static dynamic ReadJson(string jsonStr)
        {
            JToken parseJosn = JToken.Parse(jsonStr);
            //return parseJosn.ToString(Formatting.Indented);
            dynamic jsonData = JsonConvert.DeserializeObject(jsonStr);
            return jsonData;
         
        }


        public static dynamic LoadCustomer(string searchValue)
        {
            var request = WebRequest.Create($"https://localhost:44318/api/Customers/Type3?filter={searchValue}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            return jsonData;
        }
    }
}
