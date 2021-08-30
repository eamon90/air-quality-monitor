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

        public List<Measurement> GetMeasurements(string countryCode, string city, DateTime from, DateTime to, int limit)
        {
            var path = Configuration["Paths:GetMeasurements"];
            path = string.Format(path, countryCode, city, from.ToString("yyyy-MM-dd"), to.ToString("yyyy-MM-dd"), limit);
            return _apiCaller.Get<List<Measurement>>(path);
        }
    }
}
