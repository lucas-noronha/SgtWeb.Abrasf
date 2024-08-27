using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcPedidoCancelamento
    {
        [XmlElement(ElementName = "InfPedidoCancelamento")]
        public tcInfPedidoCancelamento InfPedidoCancelamento { get; set; }
        [XmlElement(ElementName = "Signature")]
        public string Signature { get; set; } //Ver com ricado
    }


}
