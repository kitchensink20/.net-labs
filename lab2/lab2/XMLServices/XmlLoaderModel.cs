using System.Xml;

namespace lab2
{
    public static class XmlLoaderModel
    {
        public static XmlDocument LoadXMLFile(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            return xmlDoc;
        }
    }
}
