using System.Text.Json.Serialization;

namespace PowerplantChallenge.Model {
    public class PowerplantInput
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("efficiency")]
        public decimal Efficiency { get; set; }

        [JsonPropertyName("pmin")]
        public int PMin { get; set; }

        [JsonPropertyName("pmax")]
        public int PMax { get; set; }
    }
}