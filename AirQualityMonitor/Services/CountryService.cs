using AirQualityMonitor.Models;
using AirQualityMonitor.Services.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace AirQualityMonitor.Services
{
    public class CountryService
    {
        private readonly IConfiguration _config;
        private readonly ApiCaller _apiCaller;

        public CountryService(IConfiguration configuration, ApiCaller apiCaller)
        {
            _config = configuration;
            _apiCaller = apiCaller;
        }

        public void GetAllCountries()
        {
            var countries = _apiCaller.Get<List<Country>>(_config["Paths:GetAllCountries"]);
            Console.WriteLine("something");
        }
    }
}
