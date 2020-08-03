using Newtonsoft.Json;

namespace DotNet_Deserialization
{
    public class Info
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonProperty(TypeNameHandling = TypeNameHandling.All)]
        public dynamic Comments{ get; set; }
    }
}
