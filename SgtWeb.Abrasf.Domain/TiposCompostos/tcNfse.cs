using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcNfse
    {
        [XmlElement(ElementName = "InfNfse")]
        public tcInfNfse InfNfse { get; set; }
        [XmlElement(ElementName = "Signature")]
        public string Signature { get; set; } //Ver com ricado
        [XmlElement(ElementName = "versao")]
        public string versao { get; set; }
    }


}
