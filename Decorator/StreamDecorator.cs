namespace Decorator;

public abstract class StreamDecorator(IStream stream) : IStream {
    protected IStream _stream = stream;
    public virtual void Write(string data) => _stream.Write(data);
    public virtual string Read() => _stream.Read();
}

public class CompressionStreamDecorator(IStream stream) : StreamDecorator(stream) {
    public override void Write(string data) => base.Write(FileHelper.Compress(data));
    public override string Read() => FileHelper.Decompress(base.Read());
}

public class EncryptionStreamDecorator(IStream stream) : StreamDecorator(stream) {
    public override void Write(string data) => base.Write(FileHelper.Encrypt(data));
    public override string Read() => FileHelper.Decrypt(base.Read());
}