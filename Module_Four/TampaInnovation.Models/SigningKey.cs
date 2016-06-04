using Newtonsoft.Json;

namespace TampaInnovation.Models
{
    public class SigningKey
    {
        [JsonProperty("ts")]
        public string TypeStamp { get; set; }
        [JsonProperty("key")]
        public string PublicKey { get; set; }
        [JsonProperty("sig")]
        public string Signature { get; set; }
    }
}