using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Framework._3rdParty.Swiftype
{
    public class SwiftypeService
    {

        /// <summary>
        /// Gets results from Swiftype
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="engine">The engine.</param>
        /// <returns></returns>
        public SwiftypeResults fetchResults(SwiftypeSearchOptions options, string engine)
        {
            HttpClient _httpClient = new HttpClient();
            //var test = JsonConvert.SerializeObject(options, Formatting.Indented); -- shows what we are posting to swiftype
            var url = "https://api.swiftype.com/api/v1/engines/" + engine + "/document_types/page/search.json";
            HttpResponseMessage response =  _httpClient.PostAsJsonAsync<SwiftypeSearchOptions>("https://api.swiftype.com/api/v1/engines/"+ engine +"/document_types/page/search.json", options).Result;
            string Json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<SwiftypeResults>(Json);
        }

    //    public void crawlURL(string url)
    //    {
    //        SwiftKeyUpdate updateData = new SwiftKeyUpdate(url);
    //        HttpClient _httpClient = new HttpClient();
    //        HttpResponseMessage response = _httpClient.PutAsJsonAsync<SwiftKeyUpdate>("https://api.swiftype.com/api/v1/engines/justflightarticles/domains/53ce800b4bb81c1e6a000001/crawl_url.json", updateData).Result;
    //        if (response.StatusCode != System.Net.HttpStatusCode.OK)
    //        {
    //            var test = 1;
    //        }
    //    }
    }

    //public class SwiftKeyUpdate
    //{
    //    public string auth_token { get { return "C82zzxLkXb7SwH4Fehs5"; } }
    //    public string url { get; set; }

    //    public SwiftKeyUpdate(string url)
    //    {
    //        this.url = url;
    //    }
    //}
}
