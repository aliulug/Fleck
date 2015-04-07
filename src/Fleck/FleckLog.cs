using System;
using System.Collections.Generic;
using AdaGenel.Extensions;
using AdaPublicGenel.Log;

namespace Fleck
{
    public enum LogLevel
    {
        Debug,
        Info,
        Warn,
        Error
    }

    public class FleckLog
    {
        public static LogLevel Level = LogLevel.Info;

        public static Action<LogLevel, string, Exception> LogAction = (level, message, ex) =>
        {
	        if (level >= Level)
	        {
		        string mesaj = message;
		        if (ex != null)
			        mesaj += " Fleck Exception: " + ex.DosyayaLoglanacakStringAl();
				LogMotoru.Logla(mesaj, level == LogLevel.Error ? LogTipi.Hata : LogTipi.Bilgi, "Fleck");
	        }   
        };

        public static void Warn(string message, Exception ex = null)
        {
            LogAction(LogLevel.Warn, message, ex);
        }

        public static void Error(string message, Exception ex = null)
        {
            LogAction(LogLevel.Error, message, ex);
        }

        public static void Debug(string message, Exception ex = null)
        {
            LogAction(LogLevel.Debug, message, ex);
        }

        public static void Info(string message, Exception ex = null)
        {
            LogAction(LogLevel.Info, message, ex);
        }

    }
}
