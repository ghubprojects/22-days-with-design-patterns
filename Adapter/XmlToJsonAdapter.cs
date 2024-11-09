using Newtonsoft.Json;
using System.Xml;

namespace Adapter;

public class XmlToJsonAdapter(XmlDataProvider xmlDataProvider) : IJsonData {
    private readonly XmlDataProvider _xmlDataProvider = xmlDataProvider;

    public string GetJsonData() {
        var doc = new XmlDocument();
        doc.LoadXml(_xmlDataProvider.GetXmlData());
        return JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
    }
}