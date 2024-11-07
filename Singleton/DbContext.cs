namespace Singleton;

public sealed class DbContext {
    private static DbContext? _instance;
    private static readonly object _lock = new();
    public string Value { get; set; } = string.Empty;

    private DbContext() { }

    public static DbContext GetInstance(string value) {
        if (_instance is null) {
            lock (_lock) {
                _instance ??= new DbContext { Value = value };
            }
        }
        return _instance;
    }
}
