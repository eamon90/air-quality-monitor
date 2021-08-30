using AirQualityMonitor.Services.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace AirQualityMonitor
{
    public class Program
    {
        private static readonly LogHelper _log = new LogHelper();

        public static void Main(string[] args)
        {
            _log.Info("Starting AirQualityMonitor web app");
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message, ex.StackTrace);
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
