using Bridge;

var textDocBW = new TextDocument(new BlackAndWhitePrinter());
textDocBW.PrintDocument();

var imageDocColor = new ImageDocument(new ColorPrinter());
imageDocColor.PrintDocument();
