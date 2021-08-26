using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace AirQualityMonitor.Services.Helpers
{
    public class ApiCaller
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly LogHelper _log = new LogHelper();

        public T Get<T>(string path)
        {
            _log.Info($"Attempting to GET {path}");
            var response = _client.GetAsync(path);
            var result = response.Result.Content.ReadAsStringAsync().Result;
            return DeserializeJson<T>(JObject.Parse(result)["results"].ToString());
        }

        private T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
