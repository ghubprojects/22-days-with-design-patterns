using Decorator;

var streamFactories = new Dictionary<int, Func<IStream, IStream>>() {
    { 1, stream => stream },
    { 2, stream => new EncryptionStreamDecorator(stream) },
    { 3, stream => new CompressionStreamDecorator(stream) },
    { 4, stream => new EncryptionStreamDecorator(new CompressionStreamDecorator(stream)) },
    { 5, stream => new CompressionStreamDecorator(new EncryptionStreamDecorator(stream)) }
};

while (true) {
    Console.Write("Enter text: ");
    var text = Console.ReadLine() ?? string.Empty;

    Console.Write("Stream type (1: Plain, 2: Encryption, 3: Compression, 4: EncryptionCompression, 5: CompressionEncryption): ");
    if (int.TryParse(Console.ReadLine(), out int type) && streamFactories.TryGetValue(type, out var streamFactory)) {
        var decoratedStream = streamFactory(new Decorator.FileStream("testfile.txt"));
        decoratedStream.Write(text);
        Console.WriteLine("File content: " + decoratedStream.Read());
    }

    Console.WriteLine();
    Thread.Sleep(100);
}
