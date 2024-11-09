namespace Decorator;

public class FileStream(string filename) : IStream {
    private readonly string _filename = filename;
    public void Write(string data) => File.WriteAllText(_filename, data);
    public string Read() => File.ReadAllText(_filename);
}