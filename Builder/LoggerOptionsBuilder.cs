namespace Builder;

public interface ILoggerOptionsBuilder {
    ILoggerOptionsBuilder SetLogLevel(string logLevel);
    ILoggerOptionsBuilder EnableTimestamp(bool enableTimestamp);
    ILoggerOptionsBuilder SetLogFile(string filePath);
    ILoggerOptionsBuilder EnableConsoleLogging(bool enableConsole);
    LoggerOptions Build();
}

public class LoggerOptionsBuilder : ILoggerOptionsBuilder {
    private LoggerOptions _loggerOptions = new();

    public LoggerOptionsBuilder() {
        Reset();
    }

    public void Reset() {
        _loggerOptions = new LoggerOptions();
    }

    public ILoggerOptionsBuilder SetLogLevel(string logLevel) {
        _loggerOptions.LogLevel = logLevel;
        return this;
    }

    public ILoggerOptionsBuilder EnableTimestamp(bool enableTimestamp) {
        _loggerOptions.TimestampEnabled = enableTimestamp;
        return this;
    }

    public ILoggerOptionsBuilder SetLogFile(string filePath) {
        _loggerOptions.LogFile = filePath;
        return this;
    }

    public ILoggerOptionsBuilder EnableConsoleLogging(bool enableConsole) {
        _loggerOptions.ConsoleLoggingEnabled = enableConsole;
        return this;
    }

    public LoggerOptions Build() {
        var result = _loggerOptions;
        Reset();
        return result;
    }
}