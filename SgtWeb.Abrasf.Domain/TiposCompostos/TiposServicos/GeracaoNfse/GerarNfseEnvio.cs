using System.ServiceModel;
using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos.TiposServicos.GeracaoNfse
{
    [Serializable]
    public class GerarNfseEnvio
    {
        [XmlElement(ElementName = "Rps")]
        public tcDeclaracaoPrestacaoServico Rps { get; set; }
        
    }
}
