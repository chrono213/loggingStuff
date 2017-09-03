using System;
namespace CommonLog
{
    public static class GenericLoggingExtensions
    {
        public static ILogger Log<T>(this T handler)
        {
            var log = LogManager.GetLogger<T>();
            return log;
        }
    }
}
