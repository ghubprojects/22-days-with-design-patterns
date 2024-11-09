namespace Composite;

public interface IFileSystemItem {
    int GetSize();
    void Display(int level);
}

public class File(string name, int size) : IFileSystemItem {
    public string Name { get; } = name;
    public int Size { get; } = size;

    public int GetSize() => Size;
    public void Display(int level = 0) => Console.WriteLine($"{new string('-', level)} File: {Name} - {Size} KB");
}

public class Directory(string name) : IFileSystemItem {
    public string Name { get; } = name;
    private readonly List<IFileSystemItem> items = [];

    public void Add(IFileSystemItem item) => items.Add(item);
    public void Remove(IFileSystemItem item) => items.Remove(item);
    public int GetSize() => items.Sum(i => i.GetSize());
    public void Display(int level = 0) {
        Console.WriteLine($"{new string('-', level)} Directory: {Name} - {GetSize()} KB");
        items.ForEach(i => i.Display(level + 1));
    }
}