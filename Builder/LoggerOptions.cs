namespace Builder;

public class LoggerOptions {
    public string LogLevel { get; set; } = "INFO";
    public bool TimestampEnabled { get; set; } = true;
    public string LogFile { get; set; } = "log.txt";
    public bool ConsoleLoggingEnabled { get; set; } = true;

    public override string ToString() => $"LogLevel: {LogLevel}, TimestampEnabled: {TimestampEnabled}, LogFile: {LogFile}, ConsoleLogging: {ConsoleLoggingEnabled}";
}