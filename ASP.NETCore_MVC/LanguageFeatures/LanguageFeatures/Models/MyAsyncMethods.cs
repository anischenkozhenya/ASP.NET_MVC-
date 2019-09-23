using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        // 1  tpl
        //public static Task<long?> GetPageLength()
        //{
        //    tpl
        //    HttpClient client = new HttpClient();
        //    var httpTask = client.GetAsync("http://apress.com");
        //    return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
        //    {
        //        return antecedent.Result.Content.Headers.ContentLength;

        //    });
        //}

        //async await
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
