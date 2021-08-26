using Newtonsoft.Json;
using System;

namespace AirQualityMonitor.Models
{
    public class Measurement
    {
        public string Location { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
        public MeasurementDate Date { get; set; }
    }

    public class MeasurementDate
    {
        public DateTime Utc { get; set; }
        public DateTime Local { get; set; }
    }
}
