using System.Text.Json.Serialization;

namespace StarWars.Model
{
    public class Result
    {
     

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("films")]
        public string[] Films { get; set; }
    }
}
