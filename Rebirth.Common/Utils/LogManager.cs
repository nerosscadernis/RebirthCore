using System;
using System.Collections.Generic;
using System.Text;

namespace Rebirth.Common.Utils
{
    public static class LogManager
    {
        private static Logger _logger;

        public static void Init()
        {
            _logger = new Logger();
        }

        public static Logger GetLoggerClass()
        {
            return _logger;
        }
    }
}
