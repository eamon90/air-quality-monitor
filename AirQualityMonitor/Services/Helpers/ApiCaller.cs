using System.Net.Http;

namespace AirQualityMonitor.Services.Helpers
{
    public class ApiCaller
    {
        private readonly HttpClient _client = new HttpClient();
        private readonly LogHelper _log = new LogHelper();

        public string Get<T>(string path)
        {
            _log.Info($"Attempting to GET {path}");
            var response = _client.GetAsync(path);
            var result = response.Result.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}
