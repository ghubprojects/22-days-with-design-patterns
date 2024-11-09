namespace Bridge;

public abstract class Document(IPrinter printer) {
    protected IPrinter printer = printer;

    public abstract void PrintDocument();
}

public class TextDocument(IPrinter printer) : Document(printer) {
    public override void PrintDocument() => printer.Print("Text document content");
}

public class ImageDocument(IPrinter printer) : Document(printer) {
    public override void PrintDocument() => printer.Print("Image document content");
}