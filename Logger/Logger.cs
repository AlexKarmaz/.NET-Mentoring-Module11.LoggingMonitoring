using System;
using NLog;

namespace MyLogger
{
    public class Logger : ILogger
    {
        private readonly NLog.ILogger _logger = LogManager.GetLogger("MusicStoreLogger");

        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Trace(string message, params object[] args)
        {
            _logger.Trace(message, args);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            _logger.Warn(message, args);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, Exception ex)
        {
            _logger.Error(ex, message);
        }

        public void Error(string message, params object[] args)
        {
            _logger.Error(message, args);
        }

        public void Error(Exception ex)
        {
            _logger.Error(ex);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(Exception ex)
        {
            _logger.Fatal(ex);
        }

        public void Fatal(string message, Exception ex)
        {
            _logger.Fatal(ex, message);
        }

        public void Fatal(string message, params object[] args)
        {
            _logger.Fatal(message, args);
        }
    }
}
