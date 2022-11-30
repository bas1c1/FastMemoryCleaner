using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using FastCleanMemory.Properties;

namespace FastCleanMemory
{
  /// <summary>Log Helper</summary>
  internal static class LogHelper
  {
    private static Enums.Log.Level _level = Enums.Log.Level.Debug | Enums.Log.Level.Info | Enums.Log.Level.Warning | Enums.Log.Level.Error;
    private static readonly List<FastCleanMemory.Log> _logs = new List<FastCleanMemory.Log>();

    /// <summary>Sets the log level.</summary>
    /// <value>The log level.</value>
    internal static Enums.Log.Level Level
    {
      set
      {
        switch (value)
        {
          case Enums.Log.Level.Debug:
            LogHelper._level = Enums.Log.Level.Debug | Enums.Log.Level.Info | Enums.Log.Level.Warning | Enums.Log.Level.Error;
            break;
          case Enums.Log.Level.Info:
            LogHelper._level = Enums.Log.Level.Info | Enums.Log.Level.Warning | Enums.Log.Level.Error;
            break;
          case Enums.Log.Level.Warning:
            LogHelper._level = Enums.Log.Level.Warning | Enums.Log.Level.Error;
            break;
          case Enums.Log.Level.Error:
            LogHelper._level = Enums.Log.Level.Error;
            break;
        }
      }
    }

    /// <summary>Gets the logs.</summary>
    /// <value>The logs.</value>
    internal static List<FastCleanMemory.Log> Logs => LogHelper._logs;

    /// <summary>Debug</summary>
    /// <param name="message">Message</param>
    /// <param name="method">Method</param>
    internal static void Debug(string message, [CallerMemberName] string method = null) => LogHelper.Log(Enums.Log.Level.Debug, message, method);

    /// <summary>Error</summary>
    /// <param name="message">Message</param>
    /// <param name="method">Method</param>
    internal static void Error(string message, [CallerMemberName] string method = null) => LogHelper.Log(Enums.Log.Level.Error, message, method);

    /// <summary>Error</summary>
    /// <param name="exception">Exception</param>
    /// <param name="message">Custom message about the Exception</param>
    /// <param name="method">Method</param>
    internal static void Error(Exception exception, string message = null, [CallerMemberName] string method = null)
    {
      if (exception == null)
        return;
      if (exception.InnerException != null)
        LogHelper.Error(exception.InnerException, message, method);
      if (string.IsNullOrWhiteSpace(message))
        message = exception.Message;
      if ((LogHelper._level & Enums.Log.Level.Debug) != Enums.Log.Level.None)
      {
        try
        {
          StackTrace stackTrace = new StackTrace(exception, true);
          StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
          MethodBase method1 = frame.GetMethod();
          if (method1.DeclaringType != (Type) null)
            method = string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} > LN: {1}", (object) (method1.DeclaringType.Name + "." + method1.Name), (object) frame.GetFileLineNumber());
        }
        catch
        {
        }
      }
      LogHelper.Log(Enums.Log.Level.Error, message, method);
    }

    /// <summary>Windows Event</summary>
    /// <param name="message">Message</param>
    /// <param name="type">Type</param>
    private static void Event(string message, EventLogEntryType type = EventLogEntryType.Information)
    {
      try
      {
        EventLog.WriteEntry("Windows Memory Cleaner", message, type);
      }
      catch
      {
      }
    }

    /// <summary>Info</summary>
    /// <param name="message">Message</param>
    /// <param name="method">Method</param>
    internal static void Info(string message, [CallerMemberName] string method = null) => LogHelper.Log(Enums.Log.Level.Info, message, method);

    /// <summary>Log</summary>
    /// <param name="level">Level</param>
    /// <param name="message">Message</param>
    /// <param name="method">Method</param>
    private static void Log(Enums.Log.Level level, string message, [CallerMemberName] string method = null)
    {
      try
      {
                FastCleanMemory.Log log = new FastCleanMemory.Log()
        {
          DateTime = DateTime.Now,
          Level = level,
          Method = method,
          Message = message
        };
        string message1 = string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0}\t{1}\t{2}", (object) log.DateTime.ToString("yyyy-MM-dd HH:mm:ss.fff", (IFormatProvider) CultureInfo.CurrentCulture), (object) log.Level.ToString().ToUpper(CultureInfo.CurrentCulture), string.IsNullOrWhiteSpace(log.Method) ? (object) log.Message : (object) string.Format((IFormatProvider) CultureInfo.CurrentCulture, "[{0}] {1}", (object) log.Method, (object) log.Message));
        switch (level)
        {
          case Enums.Log.Level.Debug:
            if ((LogHelper._level & Enums.Log.Level.Debug) == Enums.Log.Level.None)
              break;
            LogHelper._logs.Add(log);
            LogHelper.Event(message);
            Trace.WriteLine(message1);
            break;
          case Enums.Log.Level.Info:
            if ((LogHelper._level & Enums.Log.Level.Info) == Enums.Log.Level.None)
              break;
            LogHelper._logs.Add(log);
            LogHelper.Event(message);
            Trace.TraceInformation(message1);
            break;
          case Enums.Log.Level.Warning:
            if ((LogHelper._level & Enums.Log.Level.Warning) == Enums.Log.Level.None)
              break;
            LogHelper._logs.Add(log);
            LogHelper.Event(message, EventLogEntryType.Warning);
            Trace.TraceWarning(message1);
            break;
          case Enums.Log.Level.Error:
            if ((LogHelper._level & Enums.Log.Level.Error) == Enums.Log.Level.None)
              break;
            LogHelper._logs.Add(log);
            LogHelper.Event(message, EventLogEntryType.Error);
            Trace.TraceError(message1);
            break;
        }
      }
      catch (Exception ex)
      {
        LogHelper.Event(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.LogHelperCanNotSaveLogException, (object) message, (object) ex.Message), EventLogEntryType.Error);
      }
    }

    /// <summary>Warning</summary>
    /// <param name="message">Message</param>
    /// <param name="method">Method</param>
    internal static void Warning(string message, [CallerMemberName] string method = null) => LogHelper.Log(Enums.Log.Level.Warning, message, method);
  }
}
