using Builder;

var builder = new LoggerOptionsBuilder();

var defaultOptions = builder.Build();
Console.WriteLine($"Default Logger Options: {defaultOptions}");

var debugOptions = builder
    .SetLogLevel("DEBUG")
    .SetLogFile("debug.log")
    .EnableConsoleLogging(false)
    .Build();
Console.WriteLine($"Debug Logger Options: {debugOptions}");
