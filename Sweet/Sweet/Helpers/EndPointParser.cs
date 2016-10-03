using System.Net.Http;
using Newtonsoft.Json;

namespace Sweet
{
    public static class EndPointParser
    {
        public static T Parse<T> (string url)
        {
            var httpClient = new HttpClient ();
            var responseString = httpClient.GetStringAsync (url).Result;

            var parsedObject = JsonConvert.DeserializeObject<T> (responseString);

            return parsedObject;
        }
    }
}
