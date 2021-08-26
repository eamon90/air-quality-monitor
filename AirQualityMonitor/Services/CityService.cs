using AirQualityMonitor.Models;
using AirQualityMonitor.Services.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<City> GetAllCitiesFor(string countryCode)
        {
            return _apiCaller.Get<List<City>>(string.Format(Configuration["Paths:GetCitiesForSelectedCountry"], countryCode));
        }
    }
}
