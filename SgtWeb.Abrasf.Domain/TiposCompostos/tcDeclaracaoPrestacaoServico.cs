using System.Xml.Serialization;

namespace SgtWeb.Abrasf.Domain.TiposCompostos
{
    public class tcDeclaracaoPrestacaoServico
    {
        [XmlElement(ElementName = "InfDeclaracaoPrestacaoServico")]
        public tcInfDeclaracaoPrestacaoServico InfDeclaracaoPrestacaoServico { get; set; }
        [XmlElement(ElementName = "Signature")]
        public string Signature { get; set; } //Ver com ricado
    }


}
