using AirQualityMonitor.Models;
using AirQualityMonitor.Services.Helpers;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace AirQualityMonitor.Services
{
    public class CountryService
    {
        public IConfiguration Configuration;
        private readonly ApiCaller _apiCaller;

        public CountryService(IConfiguration configuration, ApiCaller apiCaller)
        {
            Configuration = configuration;
            _apiCaller = apiCaller;
        }

        public List<Country> GetCountries()
        {
            var countries = _apiCaller.Get<List<Country>>(Configuration["Paths:GetCountries"]);
            countries = countries.FindAll(c => c.Name.Length > 2).OrderBy(c => c.Name).ToList();
            return countries;
        }
    }
}
