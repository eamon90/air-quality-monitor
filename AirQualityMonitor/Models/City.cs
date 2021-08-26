using Newtonsoft.Json;

namespace AirQualityMonitor.Models
{
    public class City
    {
        [JsonProperty("city")]
        public string Name { get; set; }
    }
}
