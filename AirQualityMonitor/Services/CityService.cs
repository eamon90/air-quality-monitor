using AirQualityMonitor.Models;
using AirQualityMonitor.Services.Helpers;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace AirQualityMonitor.Services
{
    public class CityService
    {
        public IConfiguration Configuration;
        private readonly ApiCaller _apiCaller;

        public CityService(IConfiguration configuration, ApiCaller apiCaller)
        {
            Configuration = configuration;
            _apiCaller = apiCaller;
        }

        public List<City> GetCities(string countryCode, int page)
        {
            var path = Configuration["Paths:GetCities"];
            var limit = Configuration["Defaults:ResultLimit"];
            return _apiCaller.Get<List<City>>(string.Format(path, countryCode, page, limit));
        }
    }
}
