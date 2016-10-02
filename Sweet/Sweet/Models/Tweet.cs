using Newtonsoft.Json;

namespace Sweet
{
    public class Tweet
    {
        [JsonProperty ("text")]
        public string Text { get; set; }
    }
}
