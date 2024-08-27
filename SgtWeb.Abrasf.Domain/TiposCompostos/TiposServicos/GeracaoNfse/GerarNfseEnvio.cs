using System.ServiceModel;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse
{
    public class GerarNfseEnvio
    {
        [XmlElement(ElementName = "Rps")]
        public string Rps { get; set; }
        
    }
}
