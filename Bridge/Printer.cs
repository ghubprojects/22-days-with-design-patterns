namespace Bridge;

public interface IPrinter {
    void Print(string content);
}

public class BlackAndWhitePrinter : IPrinter {
    public void Print(string content) => Console.WriteLine("Printing in black and white: " + content);
}

public class ColorPrinter : IPrinter {
    public void Print(string content) => Console.WriteLine("Printing in color: " + content);
}