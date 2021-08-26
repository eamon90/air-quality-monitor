using Serilog;
using Serilog.Core;

namespace AirQualityMonitor.Services.Helpers
{
    public class LogHelper
    {
        private readonly Logger _logger = new LoggerConfiguration()
                                                        .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
                                                        .CreateLogger();
        public void Info(string msg)
        {
            _logger.Information(msg);
        }

        public void Error(string msg, string stackTrace)
        {
            _logger.Error($"msg: {msg}");
            _logger.Error($"stack trace: {stackTrace}");
        }
    }
}
