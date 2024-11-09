using Adapter;

var xmlProvider = new XmlDataProvider();
var jsonAdapter = new XmlToJsonAdapter(xmlProvider);
Console.WriteLine($"Analyzing data: {jsonAdapter.GetJsonData()}");
