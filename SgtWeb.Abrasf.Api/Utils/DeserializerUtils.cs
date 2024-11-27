using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Api.Utils
{
    public class DeserializerUtils
    {
        internal static string RemoverTagXml(string xml)
        {
            int inicioTagXml = xml.IndexOf("<?xml", StringComparison.InvariantCultureIgnoreCase);

            if (inicioTagXml == -1)
                return xml;

            int fimTagXml = xml.IndexOf("?>");
            string valorTag = xml.Substring(inicioTagXml, fimTagXml - inicioTagXml + 2);
            return xml.Replace(valorTag, string.Empty);
        }

        internal static T DeserializeXML<T>(string xml) where T : class
        {
            var cleanedUserData = RemoverTagXml(xml);

            using var stringReader = new StringReader(cleanedUserData);

            var deserializer = new XmlSerializer(typeof(T));

            if (deserializer.Deserialize(stringReader) is not T request)
                return null;

            return request;
        }

    }
}
