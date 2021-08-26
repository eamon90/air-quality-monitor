using AirQualityMonitor.Models;
using AirQualityMonitor.Services.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace AirQualityMonitor.Services
{
    public class MeasurementService
    {
        public IConfiguration Configuration;
        private readonly ApiCaller _apiCaller;

        public MeasurementService(IConfiguration configuration, ApiCaller apiCaller)
        {
            Configuration = configuration;
            _apiCaller = apiCaller;
        }

        public List<Measurement> GetMeasurements(string countryCode, string city)
        {
            var path = Configuration["Paths:GetMeasurements"];
            var from = DateTime.Today.AddYears(-int.Parse(Configuration["Defaults:MaxMeasurementWindowInYears"])).ToString("yyyy-MM-dd");
            var to = DateTime.Today.ToString("yyyy-MM-dd");
            var limit = Configuration["Defaults:ResultLimit"];
            path = string.Format(path, countryCode, city, from, to, limit);
            return _apiCaller.Get<List<Measurement>>(path);
        }
    }
}
